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
    public class GenreController : Controller
    {
        private readonly string _dbConn;
        public GenreController() : base()
        {
            _dbConn = System.Configuration.ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult GetGenres()
        {
            GenreBusinessLogic genreBL = new GenreBusinessLogic(_dbConn);
            List<LibraryCommon.Genre> _list = genreBL.BLGetGenres();
            GenreListVM model = new GenreListVM(_list);
            return View(model);
        }

        [HttpGet]
        public ActionResult CreateGenre()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateGenre(GenreModel model)
        {
            return View();
        }

        [HttpPost]
        public ActionResult UpdateGenre()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DeleteGenre()
        {
            return View();
        }
    }
}