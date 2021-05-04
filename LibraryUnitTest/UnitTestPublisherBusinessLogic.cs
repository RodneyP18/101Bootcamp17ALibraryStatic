using LibraryBusinessLogicLayer;
using LibraryCommon;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LibraryUnitTest
{
    [TestClass]
    public class UnitTestPublisherBusinessLogic
    {

        public string _conn = "Data Source = LAPTOP-286\\SQLEXPRESS;Initial Catalog = TestLibraryDB; Integrated Security = True";
        private PublisherBusinessLogic _data;
        Publisher testUser = new Publisher();

        public UnitTestPublisherBusinessLogic()
        {
            _data = new PublisherBusinessLogic(_conn);
        }


        [TestMethod]
        public void TestBLGetPublishers()
        {

        }

        [TestMethod]
        public void TestBLCreatePublisher()
        {

        }

        [TestMethod]
        public void TestBLUpdatePublisher()
        {

        }

        [TestMethod]
        public void TestBLDeletePublisher()
        {

        }
    }
}
