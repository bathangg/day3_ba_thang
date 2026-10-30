using day3_ba_thang.Models;
using Microsoft.AspNetCore.Mvc;

namespace day3_ba_thang.Controllers
{
    public class categoryController : Controller
    {
        private static List<category> _categories = new List<category>()
        {
            new category(){ Id = 1, Name = "a" },
            new category(){ Id = 2, Name = "b" },
            new category(){ Id = 3, Name = "c" }
        };

        // GET: category
        public ActionResult Index()
        {
            return View(_categories);
        }

        // GET: category/Details/5
        public ActionResult Details(int id)
        {
            var category = _categories.FirstOrDefault(c => c.Id == id);
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        // GET: category/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: category/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([FromForm] category category)
        {
            if (!ModelState.IsValid)
            {
                return View(category);
            }

            category.Id = _categories.Any() ? _categories.Max(c => c.Id) + 1 : 1;
            _categories.Add(category);
            return RedirectToAction(nameof(Index));
        }

        // GET: category/Edit/5
        public ActionResult Edit(int id)
        {
            var category = _categories.FirstOrDefault(c => c.Id == id);

            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

       
        // POST: category/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, [FromForm] category model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var category = _categories.FirstOrDefault(c => c.Id == id);

            if (category == null)
            {
                return NotFound();
            }

            category.Name = model.Name;

            return RedirectToAction(nameof(Index));
        }


        // GET: category/Delete/5
        public ActionResult Delete(int id)
        {
            var category = _categories.FirstOrDefault(c => c.Id == id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        // POST: category/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var category = _categories.FirstOrDefault(c => c.Id == id);
            if (category != null)
            {
                _categories.Remove(category);
            }
            return RedirectToAction(nameof(Index));
        }
    }
}