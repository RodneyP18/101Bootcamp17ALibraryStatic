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

    public class PublisherController : Controller
    {
        private readonly string _dbConn;
        public PublisherController() : base()
        {
            _dbConn = System.Configuration.ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult GetPublishers()
        {
            PublisherBusinessLogic publisherBL = new PublisherBusinessLogic(_dbConn);
            List<LibraryCommon.Publisher> _list = publisherBL.BLGetPublishers();
            PublisherListVM model = new PublisherListVM(_list);
            return View(model);
        }

        [HttpGet]
        public ActionResult CreatePublisher()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreatePublisher(PublisherModel model)
        {
            return View();
        }

        [HttpPost]
        public ActionResult UpdatePublisher()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DeletePublisher()
        {
            return View();
        }
    }
}