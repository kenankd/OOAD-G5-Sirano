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
    public class FootwearController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FootwearController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Footwears
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Footwear.Include(f => f.review);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Footwears/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var footwear = await _context.Footwear
                .Include(f => f.review)
                .FirstOrDefaultAsync(m => m.id == id);
            if (footwear == null)
            {
                return NotFound();
            }

            return View(footwear);
        }

        // GET: Footwears/Create
        public IActionResult Create()
        {
            ViewData["reviewID"] = new SelectList(_context.Review, "id", "id");
            return View();
        }

        // POST: Footwears/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,size,category,discount,reviewID,price,colour")] Footwear footwear)
        {
            if (ModelState.IsValid)
            {
                _context.Add(footwear);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["reviewID"] = new SelectList(_context.Review, "id", "id", footwear.reviewID);
            return View(footwear);
        }

        // GET: Footwears/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var footwear = await _context.Footwear.FindAsync(id);
            if (footwear == null)
            {
                return NotFound();
            }
            ViewData["reviewID"] = new SelectList(_context.Review, "id", "id", footwear.reviewID);
            return View(footwear);
        }

        // POST: Footwears/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,size,category,discount,reviewID,price,colour")] Footwear footwear)
        {
            if (id != footwear.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(footwear);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FootwearExists(footwear.id))
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
            ViewData["reviewID"] = new SelectList(_context.Review, "id", "id", footwear.reviewID);
            return View(footwear);
        }

        // GET: Footwears/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var footwear = await _context.Footwear
                .Include(f => f.review)
                .FirstOrDefaultAsync(m => m.id == id);
            if (footwear == null)
            {
                return NotFound();
            }

            return View(footwear);
        }

        // POST: Footwears/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var footwear = await _context.Footwear.FindAsync(id);
            _context.Footwear.Remove(footwear);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FootwearExists(int id)
        {
            return _context.Footwear.Any(e => e.id == id);
        }
    }
}
