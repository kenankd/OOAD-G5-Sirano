using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Sirano.Data;
using Sirano.Models;

namespace Sirano.Controllers
{
    public class ClothingsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ClothingsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Clothings
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Clothing.Include(c => c.review);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Clothings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clothing = await _context.Clothing
                .Include(c => c.review)
                .FirstOrDefaultAsync(m => m.id == id);
            if (clothing == null)
            {
                return NotFound();
            }

            return View(clothing);
        }

        // GET: Clothings/Create
        public IActionResult Create()
        {
            ViewData["reviewID"] = new SelectList(_context.Review, "id", "id");
            return View();
        }

        // POST: Clothings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,size,category,discount,reviewID,price,colour")] Clothing clothing)
        {
            if (ModelState.IsValid)
            {
                _context.Add(clothing);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["reviewID"] = new SelectList(_context.Review, "id", "id", clothing.reviewID);
            return View(clothing);
        }

        // GET: Clothings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clothing = await _context.Clothing.FindAsync(id);
            if (clothing == null)
            {
                return NotFound();
            }
            ViewData["reviewID"] = new SelectList(_context.Review, "id", "id", clothing.reviewID);
            return View(clothing);
        }

        // POST: Clothings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,size,category,discount,reviewID,price,colour")] Clothing clothing)
        {
            if (id != clothing.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(clothing);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClothingExists(clothing.id))
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
            ViewData["reviewID"] = new SelectList(_context.Review, "id", "id", clothing.reviewID);
            return View(clothing);
        }

        // GET: Clothings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clothing = await _context.Clothing
                .Include(c => c.review)
                .FirstOrDefaultAsync(m => m.id == id);
            if (clothing == null)
            {
                return NotFound();
            }

            return View(clothing);
        }

        // POST: Clothings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var clothing = await _context.Clothing.FindAsync(id);
            _context.Clothing.Remove(clothing);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ClothingExists(int id)
        {
            return _context.Clothing.Any(e => e.id == id);
        }
    }
}
