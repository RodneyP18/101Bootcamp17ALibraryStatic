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
    public class UserController : Controller
    {
        private readonly string _dbConn;
        private UserBusinessLogic userBL;

        public UserController() : base()
        {
            _dbConn = System.Configuration.ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
            userBL = new UserBusinessLogic(_dbConn);
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult GetUsers()
        {
            List<User> _list = userBL.BLGetUsers();
            UserListVM model = new UserListVM(_list);
            return View(model);
        }

        [HttpGet]
        public ActionResult CreateUser()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateUser(UserModel model)
        {
            if (ModelState.IsValid)
            {


                User toAdd = new User();

                toAdd.FirstName = model.FirstName;
                toAdd.LastName = model.LastName;
                toAdd.UserName = model.UserName;
                toAdd.Password = model.Password;
                toAdd.RoleID_FK = model.RoleID_FK;

                userBL.BLCreateUser(toAdd);

                return RedirectToAction("GetUsers", "User");
            }
            else { 
                return View();
            }
        }

        [HttpGet]
        public ActionResult UpdateUser(UserModel model, int id, int roleID)
        {
            
            model.UserID = id;
            model.RoleID_FK = roleID;
            return View(model);
        }

        [HttpPost]
        public ActionResult UpdateUser(UserModel model)
        {
            User toUpdate = new User();

            toUpdate.UserID = model.UserID;
            toUpdate.FirstName = model.FirstName;
            toUpdate.LastName = model.LastName;
            toUpdate.UserName = model.UserName;
            toUpdate.Password = model.Password;
            toUpdate.RoleID_FK = model.RoleID_FK;

            userBL.BLUpdateUser(toUpdate);

            return RedirectToAction("GetUsers", "User");
        }

        [HttpPost]
        public ActionResult DeleteUser(int id)
        {
            User toDelete = new User();
            toDelete.UserID = id;
            userBL.BLDeleteUser(toDelete);

            return RedirectToAction("GetUsers", "User");
        }

    }
}