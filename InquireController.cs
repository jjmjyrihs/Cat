using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.Controllers
{
    public class InquireController : Controller
    {
        public ActionResult Index(eSaleModel.Order AllData)
        {
            eSaleService.OrderService OS = new eSaleService.OrderService();
            List<eSaleModel.Order> Data = new List<eSaleModel.Order>();            
            Data = OS.Inquire(AllData);
            ViewBag.Data = Data;
            TempData["Data"] = Data;
            return View();
        }
        
        
        
        
    }
}