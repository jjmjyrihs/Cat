using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.Controllers
{
    public class DelectController : Controller
    {
        public ActionResult Index(eSaleModel.Order AllData)
        {
            eSaleService.OrderService OS = new eSaleService.OrderService();
            ViewBag.Data = AllData;
            return RedirectToAction("Index","Inquire",AllData);
        }
    }
}