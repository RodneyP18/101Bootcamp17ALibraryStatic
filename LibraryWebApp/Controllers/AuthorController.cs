using LibraryBusinessLogicLayer;
using LibraryWebApp.Mapping;
using LibraryWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LibraryWebApp.Controllers
{
    public class AuthorController : Controller
    {
        private readonly string _dbConn;
        public AuthorController() : base()
        {
            _dbConn = System.Configuration.ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult GetAuthors()
        {
            AuthorBusinessLogic authorBL = new AuthorBusinessLogic(_dbConn);
            List<LibraryCommon.Author> _list = authorBL.BLGetAuthors();

            AuthorListVM model = new AuthorListVM(_list);
            return View(model);
        }

        [HttpGet]
        public ActionResult CreateAuthor()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateAuthor(AuthorModel model)
        {
            return View();
        }

        [HttpPost]
        public ActionResult UpdateAuthor()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DeleteAuthor()
        {
            return View();
        }
    }
}