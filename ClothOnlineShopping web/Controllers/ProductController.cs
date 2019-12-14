using ClothOnlineShopping.Entities1;
using ClothOnlineShopping.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClothOnlineShopping_web.Controllers
{
    public class ProductController : Controller
    {
        ProductsService ProdService = new ProductsService();
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ProductTable(string search)
        {
           var products =ProdService.GetProduct();
            if (!string.IsNullOrEmpty(search))
            {
                products = products.Where(x =>x.Name !=null && x.Name.ToLower().Contains(search.ToLower())).ToList();
            }
          
            return PartialView(products);
        }
      
        public ActionResult Create()
        {
            return PartialView();
        }
        [HttpPost]
        public ActionResult Create(Product product)
        {
            ProdService.SaveProduct(product);
            return RedirectToAction("ProductTable");
        }
        public ActionResult Edit(int id)
        {
            var product = ProdService.GetProduct(id);
            return PartialView(product);
        }
        [HttpPost]
        public ActionResult Edit(Product product)
        {
            ProdService.UpdateProduct(product);
            return RedirectToAction("ProductTable");
        }
        [HttpPost]
        public ActionResult Delete(int id)
        {
            ProdService.DeleteProduct(id);
            return RedirectToAction("ProductTable");
        }
    }
}