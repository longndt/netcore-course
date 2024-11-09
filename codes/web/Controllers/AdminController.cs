using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using web.Data;
using web.ViewModels;

namespace web.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ApplicationDbContext _context;

        public AdminController(UserManager<IdentityUser> userManager, ApplicationDbContext dbContext)
        {
            _userManager = userManager;
            _context = dbContext;
        }

        public async Task<IActionResult> UserList()
        {
            var users = await _userManager.Users.ToListAsync();
            var userList = new List<UserViewModel>();

            foreach (var user in users)
            {
                var roles = await _userManager.GetRolesAsync(user);
                var isBlocked = await _userManager.IsLockedOutAsync(user);

                userList.Add(new UserViewModel
                {
                    Id = user.Id,
                    Email = user.Email,
                    Roles = roles.ToList(),
                    IsBlocked = isBlocked
                });
            }
            return View(userList);
        }

        [HttpPost]
        public async Task<IActionResult> ResetPass(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user == null)
            {
                TempData["Error"] = "User not found.";
                return RedirectToAction("UserList");
            }

            // Generate a password reset token
            var token = await _userManager.GeneratePasswordResetTokenAsync(user);
            var newPassword = "123@Abc";

            // Reset the password using the token
            var result = await _userManager.ResetPasswordAsync(user, token, newPassword);

            if (result.Succeeded)
            {
                TempData["Message"] = $"Password for {user.Email} has been reset to default (123@Abc)";
            }
            else
            {
                TempData["Error"] = $"Failed to reset password for {user.Email}";
            }

            return RedirectToAction("UserList");
        }

        [HttpPost]
        public async Task<IActionResult> BlockUser(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user == null)
            {
                TempData["Error"] = "User not found.";
                return RedirectToAction("UserList");
            }

            // Set a very far lockout end date to block the user
            var lockoutEndDate = DateTimeOffset.UtcNow.AddYears(100);
            var result = await _userManager.SetLockoutEndDateAsync(user, lockoutEndDate);

            if (result.Succeeded)
            {
                TempData["Message"] = $"User {user.Email} has been blocked.";
            }
            else
            {
                TempData["Error"] = $"Failed to block user {user.Email}.";
            }

            return RedirectToAction("UserList");
        }

        [HttpPost]
        public async Task<IActionResult> UnblockUser(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user == null)
            {
                TempData["Error"] = "User not found.";
                return RedirectToAction("UserList");
            }

            // Set lockout end date to null to unblock the user
            var result = await _userManager.SetLockoutEndDateAsync(user, null);

            if (result.Succeeded)
            {
                TempData["Message"] = $"User {user.Email} has been unblocked.";
            }
            else
            {
                TempData["Error"] = $"Failed to unblock user {user.Email}.";
            }

            return RedirectToAction("UserList");
        }

        public async Task<IActionResult> ActivityLogs(int page = 1, int pageSize = 10)
        {
            var logs = _context.ActivityLogs
                                .OrderByDescending(log => log.AccessedAt)
                                .Skip((page - 1) * pageSize)
                                .Take(pageSize)
                                .ToList();

            ViewData["CurrentPage"] = page;
            return View(logs);
        }
    }
}
