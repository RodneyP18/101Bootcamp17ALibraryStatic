using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LibraryBusinessLogicLayer;

namespace LibraryWebApp.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult GetRoles()
        {
            string dbconn = "Data Source = LAPTOP-286\\SQLEXPRESS;Initial Catalog = Library; Integrated Security = True";
            RoleBusinessLogic roleBL = new RoleBusinessLogic(dbconn);
            List<LibraryCommon.Role> _list = roleBL.BLGetRoles();
            return View();
        }

        public ActionResult Index()
        {
            var _v = View();
            return _v;
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            var _v = View();
            return _v;
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            // var _code = new HttpStatusCodeResult(System.Net.HttpStatusCode.OK);
            return View();
        }



    }
}