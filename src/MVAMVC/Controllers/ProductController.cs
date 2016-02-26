using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using MVAMVC.Models;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace MVAMVC.Controllers
{
    public class ProductController : Controller
    {
        private ProductContext _context;

        public ProductController(ProductContext context)
        {
            _context = context;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            //var products = _context.Products.OrderBy(c => c.DisplayName);
            //var categories = from c in _context.Categories
            //                 orderby c.DisplayName
            //                 select c;

            var products = _context.Products.Include( p => p.Category).OrderBy(c => c.DisplayName);

            return View(products.ToList());
        }

        #region Details
        // GET: Category/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Product product = _context.Products.Single(m => m.ProductId == id);

            if (product == null)
            {
                return HttpNotFound();
            }

            ViewData["Categories"] = new SelectList(_context.Categories.Where( c => c.CategoryId == product.CategoryId.GetValueOrDefault()), "CategoryId", "DisplayName");

            return View(product);
        }
        #endregion

        public IActionResult Create()
        {
            ViewData["Categories"] = new SelectList(_context.Categories.OrderBy(c => c.DisplayName), "CategoryId", "DisplayName");

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Product product)
        {
            if ( ModelState.IsValid )
            {
                _context.Products.Add(product);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(product);
        }

        public IActionResult Edit (int id)
        {
            var product = _context.Products
                .Where(c => c.ProductId == id)
                .Single();

            ViewData["Categories"] = new SelectList(_context.Categories.OrderBy(c => c.DisplayName), "CategoryId", "DisplayName");

            return View(product);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit (Product product)
        {
            if (ModelState.IsValid)
            {
                _context.Products.Update(product);
                _context.SaveChanges();
                
                return RedirectToAction("Index");
            }

            return View(product);
        }

        [ActionName("Delete")]
        public IActionResult Delete(int id)
        {
            var product = _context.Products
                .Where(c => c.ProductId == id)
                .Single();

            ViewData["Categories"] = new SelectList(_context.Categories.OrderBy(c => c.DisplayName), "CategoryId", "DisplayName");

            return View(product);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var product = _context.Products
                .Where(c => c.ProductId == id)
                .Single();

            _context.Products.Remove(product);
            _context.SaveChanges();

            return RedirectToAction("Index");

        }
    }
}
