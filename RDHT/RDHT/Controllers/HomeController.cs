using RuiDa1.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RuiDa1.Controllers
{
   
    public class HomeController : Controller
    {
        private SqlDB db = new SqlDB();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            bool r = db.OpenConnection();

            

            return View();
        }
    }
}