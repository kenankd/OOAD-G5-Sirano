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

        // GET: Footwear
        public async Task<IActionResult> Index()
        {
            return View(await _context.Footwear.ToListAsync());
        }

        // GET: Footwear/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var footwear = await _context.Footwear
                .FirstOrDefaultAsync(m => m.Id == id);
            if (footwear == null)
            {
                return NotFound();
            }

            return View(footwear);
        }

        // GET: Footwear/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Footwear/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Category,Id,Price,Colour,Image,Name,Men,Summary")] Footwear footwear)
        {
            if (ModelState.IsValid)
            {
                _context.Add(footwear);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(footwear);
        }

        // GET: Footwear/Edit/5
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
            return View(footwear);
        }

        // POST: Footwear/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Category,Id,Price,Colour,Image,Name,Men,Summary")] Footwear footwear)
        {
            if (id != footwear.Id)
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
                    if (!FootwearExists(footwear.Id))
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
            return View(footwear);
        }

        // GET: Footwear/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var footwear = await _context.Footwear
                .FirstOrDefaultAsync(m => m.Id == id);
            if (footwear == null)
            {
                return NotFound();
            }

            return View(footwear);
        }

        // POST: Footwear/Delete/5
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
            return _context.Footwear.Any(e => e.Id == id);
        }
    }
}
