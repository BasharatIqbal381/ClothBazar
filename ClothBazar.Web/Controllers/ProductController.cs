using ClothBazar.Entities;
using ClothBazar.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClothBazar.Web.Controllers
{
    public class ProductController : Controller
    {
        ProductsService productsService = new ProductsService();

        public object PName { get; private set; }

        // GET: Product
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult ProductTable(string search)
        {
            var products = productsService.GetProducts();
            if(search != null)
            {
                products = products.Where(p =>p.Name  != null && p.Name.ToLower().Contains(search.ToLower())).ToList();
            }
            return PartialView(products);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return PartialView();
        }
        [HttpPost]
        public ActionResult Create(Product product )
        {
            productsService.SaveProduct(product);
            return RedirectToAction("ProductTable");
        }
        
    }
}