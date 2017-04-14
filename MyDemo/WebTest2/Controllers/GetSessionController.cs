using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebTest2.Controllers
{
    public class GetSessionController : Controller
    {
        // GET: GetSession
        public ActionResult Index()
        {
            ViewBag.CZSTitil = Session["Test"] == null ? "找不到session" : Session["Test"].ToString();
            return View();
        }
    }
}