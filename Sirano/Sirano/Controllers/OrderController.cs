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
    public class OrderController : Controller
    {
        private readonly ApplicationDbContext _context;

        public OrderController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Order
        public IActionResult Index()
        {

            return View();
        }

        // GET: Order/Details/5
        public async Task<IActionResult> Details()
        {
            var user = await _context.RegisteredUser.FirstOrDefaultAsync(u => u.Email == User.Identity.Name);
            var products = await _context.Product_Cart
            .Where(pc => pc.Cart.Bought == true && pc.Cart.UserID == user.Id)
            .Select(pc => pc.Product)
            .ToListAsync();
            return View(products);
        }

        [HttpPost]
        // GET: Order/Create
        public async Task<IActionResult> OrderOrFillPayDetails(string paymentMethod)
        {
            if (paymentMethod == "cash-on-delivery")
            {
                var user = await _context.RegisteredUser.FirstOrDefaultAsync(u => u.Email == User.Identity.Name);
                var cart = await _context.Cart.FirstOrDefaultAsync(c => c.UserID == user.Id && c.Bought == false);
                var newOrder = new Order
                {
                    OrderDate = DateTime.Today.ToString("MM/dd/yyyy"),
                    DeliveryDate = DateTime.Today.AddDays(7).ToString("MM/dd/yyyy"),
                    Status = "Ordered Succesfully!",
                    PaymentMethod = (PaymentMethod)3,
                    CartID = cart.Id,
                    CardNumber = null,
                    ExpirationMonth = null,
                    ExpirationYear = null,
                    Cardholder = null,
                    CVV = null
                };
                await _context.Order.AddAsync(newOrder);
                int changes = await _context.SaveChangesAsync();
                if (changes == 1)
                {
                    cart.Bought = true;
                    _context.Cart.Update(cart);
                    await _context.SaveChangesAsync();
                }
                return View("~/Views/Home/Privacy.cshtml");
            }

            return View("Create");
        }
        [HttpPost]
        public async Task<IActionResult> OrderWithCreditCard(string creditCardNumber, int expirationMonth, int expirationYear, string cardHolder, int cvv2)
        {
            var user = await _context.RegisteredUser.FirstOrDefaultAsync(u => u.Email == User.Identity.Name);
            var cart = await _context.Cart.FirstOrDefaultAsync(c => c.UserID == user.Id && c.Bought == false);
            var newOrder = new Order
            {
                OrderDate = DateTime.Today.ToString("MM/dd/yyyy"),
                DeliveryDate = DateTime.Today.AddDays(7).ToString("MM/dd/yyyy"),
                Status = "Ordered Succesfully!",
                PaymentMethod = PaymentMethod.Card,
                CartID = cart.Id,
                CardNumber = creditCardNumber,
                ExpirationMonth = expirationMonth,
                ExpirationYear = expirationYear,
                Cardholder = cardHolder,
                CVV = cvv2
            };
            await _context.Order.AddAsync(newOrder);
            int changes = await _context.SaveChangesAsync();
            if (changes == 1)
            {
                cart.Bought = true;
                _context.Cart.Update(cart);
                await _context.SaveChangesAsync();
            }
            return View("~/Views/Home/Privacy.cshtml");
        }
        // POST: Order/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,OrderDate,DeliveryDate,Status,PaymentMethod,CartID")] Order order)
        {
            if (ModelState.IsValid)
            {
                _context.Add(order);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CartID"] = new SelectList(_context.Cart, "Id", "Id", order.CartID);
            return View(order);
        }

        // GET: Order/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Order.FindAsync(id);
            if (order == null)
            {
                return NotFound();
            }
            ViewData["CartID"] = new SelectList(_context.Cart, "Id", "Id", order.CartID);
            return View(order);
        }

        // POST: Order/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,OrderDate,DeliveryDate,Status,PaymentMethod,CartID")] Order order)
        {
            if (id != order.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(order);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrderExists(order.Id))
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
            ViewData["CartID"] = new SelectList(_context.Cart, "Id", "Id", order.CartID);
            return View(order);
        }

        // GET: Order/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Order
                .Include(o => o.Cart)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }

        // POST: Order/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var order = await _context.Order.FindAsync(id);
            _context.Order.Remove(order);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OrderExists(int id)
        {
            return _context.Order.Any(e => e.Id == id);
        }
    }
}