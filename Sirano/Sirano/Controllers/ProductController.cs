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
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProductController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Products
        public async Task<IActionResult> Index(bool isMen, string productType)
        {
            var products = _context.Product;
            var filteredProducts = products.Where(p => p.Men == isMen);

            if (!string.IsNullOrEmpty(productType))
            {
                switch (productType.ToLower())
                {
                    case "footwear":
                        filteredProducts = filteredProducts.Where(p => p is Footwear && p.Men == isMen);
                        break;
                    case "clothing":
                        filteredProducts = filteredProducts.Where(p => p is Clothing && p.Men == isMen);
                        break;
                }
            }
            return View(await filteredProducts.ToListAsync());
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
