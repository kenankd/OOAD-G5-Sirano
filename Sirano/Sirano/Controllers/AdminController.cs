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
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AdminController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin
        public async Task<IActionResult> Index()
        {
            return View(await _context.Product.ToListAsync());
        }

        // GET: Clothing
        public async Task<IActionResult> Clothing()
        {
            return View(await _context.Clothing.ToListAsync());
        }

        // GET: Footwear
        public async Task<IActionResult> Footwear()
        {
            return View(await _context.Footwear.ToListAsync());
        }

        // GET: Clothing/Create
        public IActionResult ClothingCreate()
        {
            return View();
        }

        // POST: Clothing/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ClothingCreate([Bind("Category,Id,Price,Colour,Image,Name,Men,Summary")] Clothing clothing)
        {
            if (ModelState.IsValid)
            {
                _context.Add(clothing);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Clothing));
            }
            return View(clothing);
        }

        // GET: Footwear/Create
        public IActionResult FootwearCreate()
        {
            return View();
        }

        // POST: Footwear/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> FootwearCreate([Bind("Category,Id,Price,Colour,Image,Name,Men,Summary")] Footwear footwear)
        {
            if (ModelState.IsValid)
            {
                _context.Add(footwear);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Footwear));
            }
            return View(footwear);
        }

        // GET: Clothing/Edit/5
        public async Task<IActionResult> ClothingEdit(int? id)
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
            return View(clothing);
        }

        // POST: Clothing/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ClothingEdit(int id, [Bind("Category,Id,Price,Colour,Image,Name,Men,Summary")] Clothing clothing)
        {
            if (id != clothing.Id)
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
                    if (!ClothingExists(clothing.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Clothing));
            }
            return View(clothing);
        }

        // GET: Footwear/Edit/5
        public async Task<IActionResult> FootwearEdit(int? id)
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
        public async Task<IActionResult> FootwearEdit(int id, [Bind("Category,Id,Price,Colour,Image,Name,Men,Summary")] Footwear footwear)
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
                return RedirectToAction(nameof(Footwear));
            }
            return View(footwear);
        }

        // GET: Clothing/Delete/5
        public async Task<IActionResult> ClothingDelete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clothing = await _context.Clothing
                .FirstOrDefaultAsync(m => m.Id == id);
            if (clothing == null)
            {
                return NotFound();
            }

            return View(clothing);
        }

        // POST: Clothing/Delete/5
        [HttpPost, ActionName("ClothingDelete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ClothingDeleteConfirmed(int id)
        {
            var clothing = await _context.Clothing.FindAsync(id);
            _context.Clothing.Remove(clothing);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Clothing));
        }

        private bool ClothingExists(int id)
        {
            return _context.Clothing.Any(e => e.Id == id);
        }

        // GET: Footwear/Delete/5
        public async Task<IActionResult> FootwearDelete(int? id)
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
        [HttpPost, ActionName("FootwearDelete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> FootwearDeleteConfirmed(int id)
        {
            var footwear = await _context.Footwear.FindAsync(id);
            _context.Footwear.Remove(footwear);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Footwear));
        }

        private bool FootwearExists(int id)
        {
            return _context.Footwear.Any(e => e.Id == id);
        }

        // GET: Clothing/Details/5
        public async Task<IActionResult> ClothingDetails(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clothing = await _context.Clothing
                .FirstOrDefaultAsync(m => m.Id == id);
            if (clothing == null)
            {
                return NotFound();
            }

            return View(clothing);
        }
        // GET: Footwear/Details/5
        public async Task<IActionResult> FootwearDetails(int? id)
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


        
    }
}
