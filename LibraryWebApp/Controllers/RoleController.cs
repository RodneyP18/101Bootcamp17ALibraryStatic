using LibraryBusinessLogicLayer;
using LibraryCommon;
using LibraryWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LibraryWebApp.Controllers
{
    public class RoleController : Controller
    {
        private readonly string _dbConn;

        public RoleController() : base()
        {
            _dbConn = System.Configuration.ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult GetRoles()
        {

            RoleBusinessLogic roleBL = new RoleBusinessLogic(_dbConn);
            List<Role> _list = roleBL.BLGetRoles();
            RoleListVM model = new RoleListVM(_list);
            return View(model);
        }

        [HttpGet]
        public ActionResult CreateRole()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateRole(RoleModel model)
        {
            return View();
        }

        [HttpPost]
        public ActionResult UpdateRole()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DeleteRole()
        {
            return View();
        }
    }
}