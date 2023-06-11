using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json.Linq;
using Sirano.Data;
using Sirano.Models;

namespace Sirano.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _context;
        public static Boolean men;

        public ProductController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Products
        public async Task<IActionResult> Index(bool isMen)
        {
            var products = _context.Product;
            men = isMen;
            var filteredProducts = products.Where(p => p.Men == isMen);

            return View(await filteredProducts.ToListAsync());
        }
        public async Task<IActionResult> Index1(string productType)
        {
            var filteredProducts = _context.Product.Where(p => p.Men == men);
            if (!string.IsNullOrEmpty(productType))
            {
                switch (productType.ToLower())
                {
                    case "footwear":
                        filteredProducts = filteredProducts.Where(p => p is Footwear && p.Men == men);
                        break;
                    case "clothing":
                        filteredProducts = filteredProducts.Where(p => p is Clothing && p.Men == men);
                        break;
                }
            }
            return View("Index", await filteredProducts.ToListAsync());
        }
        // GET: Product/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Product
                .FirstOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }


        private bool ProductExists(int id)
        {
            return _context.Product.Any(e => e.Id == id);
        }
    }
}