using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using MVAMVC.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace MVAMVC.Controllers
{
    public class CategoryController : Controller
    {
        private ProductContext _context;

        public CategoryController(ProductContext context)
        {
            _context = context;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var categories = _context.Categories
                .OrderBy(c => c.DisplayName);
            //var categories = from c in _context.Categories
            //                 orderby c.DisplayName
            //                 select c;

            return View(categories.ToArray());
        }

        #region Details
        // GET: Category/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Category category = _context.Categories.Single(m => m.CategoryId == id);

            if (category == null)
            {
                return HttpNotFound();
            }

            return View(category);
        }
        #endregion

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Category category)
        {
            if ( ModelState.IsValid )
            {
                _context.Categories.Add(category);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(category);
        }

        public IActionResult Edit (int id)
        {
            var category = _context.Categories
                .Where(c => c.CategoryId == id)
                .Single();

            return View(category);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit (Category category)
        {
            if (ModelState.IsValid)
            {
                _context.Categories.Update(category);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(category);
        }

        [ActionName("Delete")]
        public IActionResult Delete(int id)
        {
            var category = _context.Categories
                .Where(c => c.CategoryId == id)
                .Single();
            return View(category);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var category = _context.Categories
                .Where(c => c.CategoryId == id)
                .Single();

            _context.Categories.Remove(category);
            _context.SaveChanges();

            return RedirectToAction("Index");

        }
    }
}
