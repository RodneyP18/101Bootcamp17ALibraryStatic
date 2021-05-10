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
    public class GenreController : Controller
    {
        private readonly string _dbConn;
        GenreBusinessLogic genreBL;
        public GenreController() : base()
        {
            _dbConn = System.Configuration.ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
            genreBL = new GenreBusinessLogic(_dbConn);
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult GetGenres()
        {
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
            Genre genre = new Genre();

            genre.GenreID = model.GenreID;
            genre.Name = model.Name;
            genre.Description = model.Description;
            genre.IsFiction = model.IsFiction;

            genreBL.BLCreateGenre(genre);
            return RedirectToAction("GetGenres", "Genre");
        }

        [HttpGet]
        public ActionResult UpdateGenre(GenreModel model, int id)
        {
            model.GenreID = id;
            return View();
        }

        [HttpPost]
        public ActionResult UpdateGenre(GenreModel model)
        {
            Genre genre = new Genre();

            genre.GenreID = model.GenreID;
            genre.Name = model.Name;
            genre.Description = model.Description;
            genre.IsFiction = model.IsFiction;

            genreBL.BLUpdateGenre(genre);
            return RedirectToAction("GetGenres", "Genre");
        }

        [HttpPost]
        public ActionResult DeleteGenre(int id)
        {
            Genre genre = new Genre();

            genre.GenreID = id;

            genreBL.BLDeleteGenre(genre);

            return RedirectToAction("GetGenres", "Genre");
        }
    }
}