using ClothOnlineShopping.Entities1;
using ClothOnlineShopping.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClothOnlineShopping_web.Controllers
{
    public class CategoryController : Controller
    {
        CategoriesService CatService = new CategoriesService();

        public ActionResult Index()
        {
            var categories = CatService.GetCategory();
            return View(categories);
        }
        // GET: Category
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Category category)
        {
            CatService.SaveCategory(category);
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int id)
        {
            var category = CatService.GetCategory(id);
            return View(category);
        }
        [HttpPost]
        public ActionResult Edit(Category category)
        {
            CatService.UpdateCategory(category);
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            var category = CatService.GetCategory(id);
            return View(category);
        }
        [HttpPost]
        public ActionResult Delete(Category category)
        {
            CatService.DeleteCategory(category.Id);
            return RedirectToAction("Index");
        }
    }
}