using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LibraryBusinessLogicLayer;
using LibraryWebApp.Models;

namespace LibraryWebApp.Controllers
{
    public class HomeController : Controller
    {

        private readonly string _dbConn;

        // constuctors
        public HomeController() : base()
        {
            _dbConn = System.Configuration.ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
        }

        [HttpGet]
        public ActionResult Login()
        {
            LoginModel model = new LoginModel();
            
            ViewBag.Message = "Login page.";
            return View(model);

        }

        [HttpGet]
        public ActionResult Register()
        {
            UserModel model = new UserModel();

            ViewBag.Message = "Register page.";
            return View(model);
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