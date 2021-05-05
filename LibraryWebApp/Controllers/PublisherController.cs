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

    public class PublisherController : Controller
    {
        private readonly string _dbConn;
        private PublisherBusinessLogic publisherBL;

        public PublisherController() : base()
        {
            _dbConn = System.Configuration.ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
            publisherBL = new PublisherBusinessLogic(_dbConn);
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult GetPublishers()
        {
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
            if (ModelState.IsValid)
            {


                Publisher toAdd = new Publisher();

                toAdd.PublisherID = model.PublisherID;
                toAdd.Name = model.Name;
                toAdd.Address = model.Address;
                toAdd.City = model.City;
                toAdd.State = model.State;
                toAdd.Zip = model.Zip;

                publisherBL.BLCreatePublisher(toAdd);

                return RedirectToAction("GetPublishers", "Publisher");
            }
            else
            {
                return View();
            }
        }

        [HttpGet]
        public ActionResult UpdatePublisher(PublisherModel model, int id)
        {
            model.PublisherID = id;
            return View(model);
        }

        [HttpPost]
        public ActionResult UpdatePublisher(PublisherModel model)
        {
            Publisher toUpdate = new Publisher();

            toUpdate.PublisherID = model.PublisherID;
            toUpdate.Name = model.Name;
            toUpdate.Address = model.Address;
            toUpdate.City = model.City;
            toUpdate.State = model.State;
            toUpdate.Zip = model.Zip;
            

            publisherBL.BLUpdatePublisher(toUpdate);

            return RedirectToAction("GetPublishers", "Publisher");
        }

        [HttpPost]
        public ActionResult DeletePublisher(int id)
        {
            Publisher toDelete = new Publisher();
            toDelete.PublisherID = id;
            publisherBL.BLDeletePublisher(toDelete);

            return RedirectToAction("GetPublishers", "Publisher");
        }

    }
}