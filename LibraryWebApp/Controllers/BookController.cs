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
    public class BookController : Controller
    {
        private readonly string _dbConn;
        BookBusinessLogic bookBL;
        PublisherBusinessLogic pubBL;
        AuthorBusinessLogic authBL;
        GenreBusinessLogic genBL;


        public BookController() : base()
        {
            _dbConn = System.Configuration.ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
            bookBL = new BookBusinessLogic(_dbConn);
            pubBL = new PublisherBusinessLogic(_dbConn);
            authBL = new AuthorBusinessLogic(_dbConn);
            genBL = new GenreBusinessLogic(_dbConn);
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult GetBooks()
        {
            List<LibraryCommon.Book> _list = bookBL.BLGetBooks();

            BookListVM model = new BookListVM(_list);
            return View(model);
        }

        [HttpGet]
        public ActionResult CreateBook()
        {
            PublisherListVM pubList = new PublisherListVM(pubBL.BLGetPublishers());
            ViewBag.Publishers = new SelectList(pubList.ListOfPublisherModels, "PublisherId", "Name");
            AuthorListVM authList = new AuthorListVM(authBL.BLGetAuthors());
            ViewBag.Authors = new SelectList(authList.ListOfAuthorModels, "AuthorId", "LastName");
            GenreListVM genList = new GenreListVM(genBL.BLGetGenres());
            ViewBag.Genres = new SelectList(genList.ListOfGenreModels, "GenreId", "Name");

            return View();
        }

        [HttpPost]
        public ActionResult CreateBook(BookModel model)
        {
            Book book = new Book();

            
            book.Title = model.Title;
            book.Description = model.Description;
            book.Price = model.Price;
            book.IsPaperback = model.IsPaperback;
            book.PublishDate = model.PublishDate;
            book.AuthorID_FK = model.AuthorID_FK;
            book.GenreID_FK = model.GenreID_FK;
            book.PublisherID_FK = model.PublisherID_FK;

            bookBL.BLCreateBook(book);

            return RedirectToAction("GetBooks", "Book");
        }

        [HttpGet]
        public ActionResult UpdateBook(BookModel model, int id, int authID, int pubID, int genID)
        {
            PublisherListVM pubList = new PublisherListVM(pubBL.BLGetPublishers());
            ViewBag.Publishers = new SelectList(pubList.ListOfPublisherModels, "PublisherId", "Name");
            AuthorListVM authList = new AuthorListVM(authBL.BLGetAuthors());
            ViewBag.Authors = new SelectList(authList.ListOfAuthorModels, "AuthorId", "LastName");
            GenreListVM genList = new GenreListVM(genBL.BLGetGenres());
            ViewBag.Genres = new SelectList(genList.ListOfGenreModels, "GenreId", "Name");

            model.BookID = id;
            model.AuthorID_FK = authID;
            model.GenreID_FK = genID;
            model.PublisherID_FK = pubID;

            return View(model);
        }

        [HttpPost]
        public ActionResult UpdateBook(BookModel model)
        {
            Book book = new Book();

            book.BookID = model.BookID;
            book.Title = model.Title;
            book.Description = model.Description;
            book.Price = model.Price;
            book.IsPaperback = model.IsPaperback;
            book.PublishDate = model.PublishDate;
            book.AuthorID_FK = model.AuthorID_FK;
            book.GenreID_FK = model.GenreID_FK;
            book.PublisherID_FK = model.PublisherID_FK;

            bookBL.BLUpdateBook(book);

            return RedirectToAction("GetBooks", "Book");
        }

        [HttpPost]
        public ActionResult DeleteBook(int id)
        {
            Book toDelete = new Book();

            toDelete.BookID = id;

            bookBL.BLDeleteBook(toDelete);

            return RedirectToAction("GetBooks", "Book");
        }
    }
}