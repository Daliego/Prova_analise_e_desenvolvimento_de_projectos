#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using secondProject.Models;

namespace secondProject.Controllers
{
    public class ReferenceBookController : Controller
    {
        private readonly MyDbContext _context;

        public ReferenceBookController(MyDbContext context)
        {
            _context = context;
        }

        // GET: ReferenceBook
        public async Task<IActionResult> Index()
        {
            return View(await _context.ReferenceBook.ToListAsync());
        }

        // GET: ReferenceBook/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var referenceBook = await _context.ReferenceBook
                .FirstOrDefaultAsync(m => m.Id == id);
            if (referenceBook == null)
            {
                return NotFound();
            }

            return View(referenceBook);
        }

        // GET: ReferenceBook/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ReferenceBook/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,AuthorName,NumberOfBook")] ReferenceBook referenceBook)
        {
            if (ModelState.IsValid)
            {
                _context.Add(referenceBook);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(referenceBook);
        }

        // GET: ReferenceBook/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var referenceBook = await _context.ReferenceBook.FindAsync(id);
            if (referenceBook == null)
            {
                return NotFound();
            }
            return View(referenceBook);
        }

        // POST: ReferenceBook/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,AuthorName,NumberOfBook")] ReferenceBook referenceBook)
        {
            if (id != referenceBook.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(referenceBook);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReferenceBookExists(referenceBook.Id))
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
            return View(referenceBook);
        }

        // GET: ReferenceBook/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var referenceBook = await _context.ReferenceBook
                .FirstOrDefaultAsync(m => m.Id == id);
            if (referenceBook == null)
            {
                return NotFound();
            }

            return View(referenceBook);
        }

        // POST: ReferenceBook/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var referenceBook = await _context.ReferenceBook.FindAsync(id);
            _context.ReferenceBook.Remove(referenceBook);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReferenceBookExists(int id)
        {
            return _context.ReferenceBook.Any(e => e.Id == id);
        }
    }
}
