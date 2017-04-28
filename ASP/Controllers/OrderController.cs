using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.Controllers
{
    public class OrderController : Controller
    {
        // GET: Order
        public ActionResult Index()
        {
            eSaleService.OrderService orderService = new eSaleService.OrderService();
            ViewBag.data = orderService.GetOrderById("1").CustId;
            return View();
        }
    }
}