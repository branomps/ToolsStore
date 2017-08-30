using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ToolsStore.Models;

namespace ToolsStore.Controllers
{
    public class StoreController : Controller
    {
        ToolsStoreDB storeDB = new ToolsStoreDB();
        // GET: Store
        public ActionResult Index()
        {
            var products = GetRandomProducts();
            return View(products);
        }

        public ActionResult Browse(string category)
        {
            // Retrieve Category and its Associated Products from database
            var categoryModel = storeDB.Categories.Include("Products").Single(c => c.Name == category);

            return View(categoryModel);
        }
        // GET: /Store/Details/5

        public ActionResult Details(int id)
        {
            var product = storeDB.Products.Find(id);

            return View(product);
        }

        //
        // GET: /Store/CategoryMenu

        [ChildActionOnly]
        public ActionResult CategoryMenu()
        {
            var category = storeDB.Categories.ToList();

            return PartialView(category);
        }

        private List<Product> GetRandomProducts()
        {
            var _db = storeDB.Products.ToList();
            List<Product> randomProduct = new List<Product>();
            var productsCount = storeDB.Products.Count();
            Random rmd = new Random();
            for (int i =1;i <=9; i++)
            {
                int rmdItem = rmd.Next(1, productsCount);
                foreach(var item in _db)
                {
                    if (item.ProductId == rmdItem)
                    {
                        randomProduct.Add(item);
                        
                    }
                }
            }

            return randomProduct;
        }
    }
}