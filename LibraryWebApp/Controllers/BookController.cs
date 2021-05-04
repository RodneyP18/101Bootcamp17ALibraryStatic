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
    public class BookController : Controller
    {
        private readonly string _dbConn;
        public BookController() : base()
        {
            _dbConn = System.Configuration.ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult GetBooks()
        {
            BookBusinessLogic BookBL = new BookBusinessLogic(_dbConn);
            List<LibraryCommon.Book> _list = BookBL.BLGetBooks();

            BookListVM model = new BookListVM(_list);
            return View(model);
        }

        [HttpGet]
        public ActionResult CreateBook()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateBook(BookModel model)
        {
            return View();
        }

        [HttpPost]
        public ActionResult UpdateBook()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DeleteBook()
        {
            return View();
        }
    }
}