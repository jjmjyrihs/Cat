using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.Controllers
{
    public class OrderController : Controller
    {
        

        
        eSaleModel.CodeService CodeService = new eSaleModel.CodeService();
        
        public ActionResult Index()
        {
            eSaleService.OrderService orderService = new eSaleService.OrderService();

            List<eSaleModel.Order> Data = new List<eSaleModel.Order>();
            Data = orderService.GetOrderById("34");
            DropDownListMake();
            ViewBag.Data = Data;

            return View();
        }

        public void DropDownListMake()
        {
            List<SelectListItem> EmpName = new List<SelectListItem>();

            EmpName.Add(new SelectListItem()
            {
                Text = "Davis-Sara",
                Value = "1"                
            });
            EmpName.Add(new SelectListItem()
            {
                Text = "Funk-Don",
                Value = "2"
            });
            EmpName.Add(new SelectListItem()
            {
                Text = "Lew-Judy",
                Value = "3"
            });
            EmpName.Add(new SelectListItem()
            {
                Text = "Peled-Yael",
                Value = "4"
            });
            EmpName.Add(new SelectListItem()
            {
                Text = "Buck-Sven",
                Value = "5"
            });
            EmpName.Add(new SelectListItem()
            {
                Text = "Suurs-Paul",
                Value = "6"
            });
            EmpName.Add(new SelectListItem()
            {
                Text = "King-Russell",
                Value = "7"
            });
            EmpName.Add(new SelectListItem()
            {
                Text = "Cameron-Maria",
                Value = "8"
            });
            EmpName.Add(new SelectListItem()
            {
                Text = "Dolgopyatova-Zoya",
                Value = "9"
            });
            EmpName.Add(new SelectListItem()
            {
                Text = "Brown-John",
                Value = "11"
            });
            EmpName.Add(new SelectListItem()
            {
                Text = "Harris-Bill",
                Value = "12"
            });
            ViewBag.EmpName = EmpName;
        }
    }
}