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
            var categories = storeDB.Categories.ToList();
            return View(categories);
        }

        public ActionResult Browse(string category)
        {
            // Retrieve Genre and its Associated Albums from database
            var categoryModel = storeDB.Categories.Include("Product")
                .Single(c => c.Name == category);

            return View(categoryModel);
        }
        // GET: /Store/Details/5

        public ActionResult Details(int id)
        {
            var product = storeDB.Products.Find(id);

            return View(product);
        }

        //
        // GET: /Store/GenreMenu

        [ChildActionOnly]
        public ActionResult GenreMenu()
        {
            var category = storeDB.Categories.ToList();

            return PartialView(category);
        }
    }
}