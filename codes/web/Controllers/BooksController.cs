using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using web.Data;
using web.Models;

namespace web.Controllers
{
    public class BooksController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IMemoryCache _cache;

        public BooksController(ApplicationDbContext context, IMemoryCache cache)
        {
            _context = context;
            _cache = cache;
        }

        public async Task<IActionResult> RecentBooks()
        {
            const string cacheKey = "recentBooks";
            if (!_cache.TryGetValue(cacheKey, out List<Book> recentBooks))
            {
                recentBooks = await _context.Book
                    .OrderByDescending(b => b.BookId)
                    .Take(5)  //take 5 latest book
                    .ToListAsync();
                var cacheOptions = new MemoryCacheEntryOptions
                {
                    AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(10)
                };
                _cache.Set(cacheKey, recentBooks, cacheOptions);
            }
            return View(recentBooks);
        }

        // GET: Books
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Book.Include(b => b.Genre);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Books/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var book = await _context.Book
                .Include(b => b.Genre)
                .FirstOrDefaultAsync(m => m.BookId == id);
            if (book == null)
            {
                return NotFound();
            }

            return View(book);
        }

        // GET: Books/Create
        public IActionResult Create()
        {
            ViewData["GenreId"] = new SelectList(_context.Genre, "GenreId", "GenreName");
            return View();
        }

        // POST: Books/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Book book, IFormFile BookCover)
        {
            if (ModelState.IsValid)
            {
                //validate image is valid or not
                if (BookCover != null && BookCover.Length > 0)
                {
                    //set new image file name
                    //Note: use Guid to generate unique file name
                    var fileName = Guid.NewGuid().ToString() + "_" + Path.GetFileName(BookCover.FileName);
                    //set image file location
                    //Note: create a subfolder named "images" in "wwwroot" to store all images
                    var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images", fileName);

                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        //copy (upload) image file from orignal location to project folder
                        BookCover.CopyTo(stream);
                    }

                    //set image file name for book cover
                    book.BookCover = "/images/" + fileName;
                }
                _context.Add(book);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["GenreId"] = new SelectList(_context.Genre, "GenreId", "GenreName", book.GenreId);
            return View(book);
        }

        // GET: Books/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var book = await _context.Book.FindAsync(id);
            if (book == null)
            {
                return NotFound();
            }
            ViewData["GenreId"] = new SelectList(_context.Genre, "GenreId", "GenreName", book.GenreId);
            return View(book);
        }

        // POST: Books/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Book book, IFormFile BookCover)
        {
            if (id != book.BookId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    //check if a new image file is uploaded or not
                    if (BookCover != null && BookCover.Length > 0)
                    {
                        //set new image file name
                        //Note: use Guid to generate unique file name
                        var fileName = Guid.NewGuid().ToString() + "_" + Path.GetFileName(BookCover.FileName);
                        //set image file location
                        //Note: create a subfolder named "images" in "wwwroot" to store all images
                        var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images", fileName);

                        using (var stream = new FileStream(filePath, FileMode.Create))
                        {
                            //copy (upload) image file from orignal location to project folder
                            BookCover.CopyTo(stream);
                        }

                        //set image file name for book cover
                        book.BookCover = "/images/" + fileName;
                    } 
                    //use the existing image file if no image file is uploaded
                    else
                    {
                        var existingBook = _context.Book.AsNoTracking().FirstOrDefault(b => b.BookId == book.BookId);
                        book.BookCover = existingBook.BookCover;
                    }
                    _context.Update(book);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BookExists(book.BookId))
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
            ViewData["GenreId"] = new SelectList(_context.Genre, "GenreId", "GenreName", book.GenreId);
            return View(book);
        }

        // GET: Books/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var book = await _context.Book
                .Include(b => b.Genre)
                .FirstOrDefaultAsync(m => m.BookId == id);
            if (book == null)
            {
                return NotFound();
            }

            return View(book);
        }

        // POST: Books/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var book = await _context.Book.FindAsync(id);
            _context.Book.Remove(book);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BookExists(int id)
        {
            return _context.Book.Any(e => e.BookId == id);
        }

        [HttpPost]
        public async Task<IActionResult> SearchByTitle(string title)
        {
            var books = _context.Book.Include(b => b.Genre).Where(b => b.BookTitle.Contains(title));
            return View("Index", await books.ToListAsync());
        }

        public async Task<IActionResult> SortPriceAsc()
        {
            var books = _context.Book.Include(b => b.Genre).OrderBy(b => b.BookPrice);
            return View("Index", await books.ToListAsync());
        }

        public async Task<IActionResult> SortPriceDesc()
        {
            var books = _context.Book.Include(b => b.Genre).OrderByDescending(b => b.BookPrice);
            return View("Index", await books.ToListAsync());
        }
    }
}
