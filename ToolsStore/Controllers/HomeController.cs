using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ToolsStore.Models;

namespace ToolsStore.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        ToolsStoreDB storeDB = new ToolsStoreDB();
       
        public ActionResult Index()
        {
            var products = GetTopSellingProducts(6); 
           
            return View(products);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        private List<Product> GetTopSellingProducts(int count)
        {
            // Group the order details by product and return 
            // the productss with the highest count
            return storeDB.Products.OrderByDescending(a => a.OrderDetails.Count()).Take(count).ToList();
        }

    }
}