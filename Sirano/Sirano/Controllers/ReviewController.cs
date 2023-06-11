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
    public class ReviewController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ReviewController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Review
        public async Task<IActionResult> Index(int id)
        {
            var product = await _context.Product.FirstOrDefaultAsync(r => r.Id == id);
            return View(product);
        }

        public async Task<IActionResult> CreateReview(int id, string comment, int rating)
        {
            var product = await _context.Product.FirstOrDefaultAsync(r => r.Id == id);
            var newReview = new Review
            {
                Comment = comment,
                Rating = rating,
                ProductID = id
            };
            await _context.Review.AddAsync(newReview);
            await _context.SaveChangesAsync();
            return RedirectToAction("Details", "Order");
        }
    }
}
