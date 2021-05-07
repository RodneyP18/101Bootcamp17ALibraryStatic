using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LibraryBusinessLogicLayer;
using LibraryCommon;
using LibraryCommon.DataEntity;
using LibraryWebApp.Mapping;
using LibraryWebApp.Models;

namespace LibraryWebApp.Controllers
{
    public class HomeController : Controller
    {

        private readonly string _dbConn;
        private UserBusinessLogic userBL;

        // constuctors
        public HomeController() : base()
        {
            _dbConn = System.Configuration.ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
            userBL = new UserBusinessLogic(_dbConn);
        }

        [HttpGet]
        public ActionResult Search()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            LoginModel model = new LoginModel();
            
            ViewBag.Message = "Login page.";
            return View(model);

        }

        [HttpPost]
        public ActionResult Login(LoginModel model)
        {

            if (ModelState.IsValid)
            {

                User user = new User();
                user.UserName = model.UserName;
                user.Password = model.Password;


                ResultUser _result = userBL.LoginUser(user);

                
                UserModel _userModel = Mapper.UserToUserModel(_result.User);


                Session["UserSession"] = _userModel;


                return RedirectToAction("Search", "Home");
            }

            else
            {
                return View(model);
            }

        }


        [HttpGet]
        public ActionResult Logout()
        {
            
            Session.Abandon();
            return RedirectToAction("Search", "Home");

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
           
            return View();
        }



    }
}