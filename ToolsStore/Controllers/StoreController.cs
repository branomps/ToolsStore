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
    }
}