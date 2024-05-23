using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using todo.Data;
using todo.Models;

namespace todo.Controllers
{
    public class TaskCommentsController : Controller
    {
        private readonly ToDoAppContext _context;

        public TaskCommentsController(ToDoAppContext context)
        {
            _context = context;
        }

        // GET: TaskComments
        public async Task<IActionResult> Index()
        {
            var toDoAppContext = _context.TaskComments.Include(t => t.Task).Include(t => t.User);
            return View(await toDoAppContext.ToListAsync());
        }

        // GET: TaskComments/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var taskComment = await _context.TaskComments
                .Include(t => t.Task)
                .Include(t => t.User)
                .FirstOrDefaultAsync(m => m.TaskCommentId == id);
            if (taskComment == null)
            {
                return NotFound();
            }

            return View(taskComment);
        }

        // GET: TaskComments/Create
        public IActionResult Create()
        {
            ViewData["TaskId"] = new SelectList(_context.Tasks, "TaskId", "TaskId");
            ViewData["UserId"] = new SelectList(_context.Users, "UserId", "UserId");
            return View();
        }

        // POST: TaskComments/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TaskCommentId,CommentText,CreatedDate,TaskId,UserId")] TaskComment taskComment)
        {
            if (ModelState.IsValid)
            {
                _context.Add(taskComment);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["TaskId"] = new SelectList(_context.Tasks, "TaskId", "TaskId", taskComment.TaskId);
            ViewData["UserId"] = new SelectList(_context.Users, "UserId", "UserId", taskComment.UserId);
            return View(taskComment);
        }

        // GET: TaskComments/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var taskComment = await _context.TaskComments.FindAsync(id);
            if (taskComment == null)
            {
                return NotFound();
            }
            ViewData["TaskId"] = new SelectList(_context.Tasks, "TaskId", "TaskId", taskComment.TaskId);
            ViewData["UserId"] = new SelectList(_context.Users, "UserId", "UserId", taskComment.UserId);
            return View(taskComment);
        }

        // POST: TaskComments/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TaskCommentId,CommentText,CreatedDate,TaskId,UserId")] TaskComment taskComment)
        {
            if (id != taskComment.TaskCommentId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(taskComment);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TaskCommentExists(taskComment.TaskCommentId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["TaskId"] = new SelectList(_context.Tasks, "TaskId", "TaskId", taskComment.TaskId);
            ViewData["UserId"] = new SelectList(_context.Users, "UserId", "UserId", taskComment.UserId);
            return View(taskComment);
        }

        // GET: TaskComments/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var taskComment = await _context.TaskComments
                .Include(t => t.Task)
                .Include(t => t.User)
                .FirstOrDefaultAsync(m => m.TaskCommentId == id);
            if (taskComment == null)
            {
                return NotFound();
            }

            return View(taskComment);
        }

        // POST: TaskComments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var taskComment = await _context.TaskComments.FindAsync(id);
            if (taskComment != null)
            {
                _context.TaskComments.Remove(taskComment);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TaskCommentExists(int id)
        {
            return _context.TaskComments.Any(e => e.TaskCommentId == id);
        }
    }
}
