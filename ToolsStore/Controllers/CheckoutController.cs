using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ToolsStore.Models;

namespace ToolsStore.Controllers
{
    [Authorize]
    public class CheckoutController : Controller
    {
        ToolsStoreDB storeDB = new ToolsStoreDB(); 

        // GET: Checkout
        public ActionResult AddressAndPayment()
        {
            return View();
        }
        [HttpPost]
        //Post : checkout
        public ActionResult AddressAndPayment(FormCollection values)
        {
            var order = new Order();
            TryUpdateModel(order);

            try
            {
                order.UserName = User.Identity.Name;
                order.OrderDate = DateTime.Now;

                //Save order
                storeDB.Orders.Add(order);
                storeDB.SaveChanges();

                //Process the order
                var cart = ShoppingCart.GetCart(this.HttpContext);
                cart.CreateOrder(order);
                return RedirectToAction("Complete", new { id = order.OrderId });
            }
            catch
            {
                return View(order);
            }
        }

        // GET: /Checkout/Complete
        public ActionResult Complete(int id)
        {
            // Validate customer owns this order
            bool isValid = storeDB.Orders.Any( o => o.OrderId == id && o.UserName == User.Identity.Name);
            if (isValid)
            {
                return View(id);
            }
            else
            {
                return View("Error");
            }
        }

    }
}