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
        RoleBusinessLogic roleBL;

        public RoleController() : base()
        {
            _dbConn = System.Configuration.ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
            roleBL = new RoleBusinessLogic(_dbConn);
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult GetRoles()
        {
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
            Role role = new Role();

            role.RoleName = model.RoleName;

            roleBL.BLCreateRole(role);

            return RedirectToAction("GetRoles", "Role");
        }

        [HttpGet]
        public ActionResult UpdateRole()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UpdateRole(RoleModel model, int id)
        {
            return RedirectToAction("GetRoles", "Role");
        }

        [HttpPost]
        public ActionResult DeleteRole()
        {
            return RedirectToAction("GetRoles", "Role");
        }
    }
}