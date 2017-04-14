using MyDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewData["Test"] = "哈哈哈";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            List<SelectListItem> lsItem = new List<SelectListItem>();
            lsItem.Add(new SelectListItem() { Value="",Text="请选择" });
            lsItem.Add(new SelectListItem() { Value = "1", Text = "A" });
            lsItem.Add(new SelectListItem() { Value = "2", Text = "B" ,Selected=true });
            ViewData["selectTest"] = lsItem;
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [ChildActionOnly]
        //[ChildActionOnly] 1.表示这个Action只应作为子操作进行调用。也就是说直接通过 controller/action这样的网址是不能访问的，会提示只能由子请求访问的错误。
        //2.必须返回一个PartialView
        public ActionResult GETPartial()
        {
            return PartialView("_PartialHelleWorld");
        }

        public ActionResult ActionGetTime()
        {
            ViewBag.DateTime = DateTime.Now;
            return View();
        }
        [ChildActionOnly]
        public ActionResult PartialGetTime()
        {
            ViewBag.DateTime = DateTime.Now.AddMinutes(-10);
            return PartialView("_PartialGetTime");
        }


        public ActionResult Test2()
        {
            return View();
        }

        public ActionResult UpdateTest(string txtName,string password)
        {
            return View();
        }

        public ActionResult HighCharts()
        {
            ViewBag.CZSTitil = Session["Test"]==null?"找不到session" : Session["Test"].ToString();
            return View();
        }

        public ActionResult MyModelTest()
        {
            Session["Test"] = "aacccffff";
            MyModel m = new MyModel();
            m.Name = "czs";
            m.Password = "123456";
            ViewData.Model = m;
            return View();
        }
    }
}