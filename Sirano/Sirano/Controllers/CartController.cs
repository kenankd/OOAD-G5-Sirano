using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Sirano.Data;
using Sirano.Models;

namespace Sirano.Controllers
{
    [Authorize]
    public class CartController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CartController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Cart
        public async Task<IActionResult> Index()
        {
            var user = await _context.RegisteredUser.FirstOrDefaultAsync(u => u.Email == User.Identity.Name);
            var cart = await _context.Cart.FirstOrDefaultAsync(c => c.UserID == user.Id && c.Bought == false);
            if (cart == null)
            {
                var newCart = new Cart
                {
                    UserID = user.Id,
                    Size = null,
                    Bought = false
                };
                await _context.Cart.AddAsync(newCart);
                await _context.SaveChangesAsync();
                cart = newCart;
            }
            var products = await _context.Product_Cart
            .Where(pc => pc.CartID == cart.Id)
            .Select(pc => pc.Product)
            .ToListAsync();
            return View(products);
        }
        
        [HttpPost]
        public async Task<IActionResult> AddToCart(int id, string size)
        {
            var user = await _context.RegisteredUser.FirstOrDefaultAsync(u => u.Email == User.Identity.Name);
            var cart = await _context.Cart.FirstOrDefaultAsync(c => c.UserID == user.Id && c.Bought == false);
            if (cart == null)
            {
                var newCart = new Cart
                {
                    UserID = user.Id,
                    Size = null,
                    Bought = false
                };
                await _context.Cart.AddAsync(newCart);
                await _context.SaveChangesAsync();
                var newProductCart = new Product_Cart
                {
                    CartID = newCart.Id,
                    Size = size,
                    ProductID = id
                };
                await _context.Product_Cart.AddAsync(newProductCart);
                await _context.SaveChangesAsync();
            }
            else
            {
                var newProductCart = new Product_Cart
                {
                    CartID = cart.Id,
                    Size = size,
                    ProductID = id
                };
                await _context.Product_Cart.AddAsync(newProductCart);
                await _context.SaveChangesAsync();
            }
            await _context.SaveChangesAsync();
            return RedirectToAction("Details", "Product", new { id = id });
        }
    }
}