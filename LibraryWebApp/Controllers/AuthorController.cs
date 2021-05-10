using LibraryBusinessLogicLayer;
using LibraryCommon;
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
        AuthorBusinessLogic authorBL;

        public AuthorController() : base()
        {
            _dbConn = System.Configuration.ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
            authorBL = new AuthorBusinessLogic(_dbConn);
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult GetAuthors()
        {
            
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
            Author author = new Author();

            author.FirstName = model.FirstName;
            author.LastName = model.LastName;
            author.Bio = model.Bio;
            author.DateOfBirth = model.DateOfBirth;
            author.BirthLocation = model.BirthLocation;

            authorBL.BLCreateAuthor(author);

            return RedirectToAction("GetAuthors", "Author");
        }

        [HttpGet]
        public ActionResult UpdateAuthor(AuthorModel model, int id)
        {
            model.AuthorID = id;
            return View(model);
        }

        [HttpPost]
        public ActionResult UpdateAuthor(AuthorModel model)
        {
            Author author = new Author();

            author.AuthorID = model.AuthorID;
            author.FirstName = model.FirstName;
            author.LastName = model.LastName;
            author.Bio = model.Bio;
            author.DateOfBirth = model.DateOfBirth;
            author.BirthLocation = model.BirthLocation;

            authorBL.BLUpdateAuthor(author);

            return RedirectToAction("GetAuthors", "Author");
        }

        [HttpPost]
        public ActionResult DeleteAuthor(int id)
        {
            Author author = new Author();

            author.AuthorID = id;

            authorBL.BLDeleteAuthor(author);

            return RedirectToAction("GetAuthors", "Author");
        }
    }
}