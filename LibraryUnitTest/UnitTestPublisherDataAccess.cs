using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data.SqlClient;
using LibraryDatabaseAccessLayer;
using LibraryCommon;

namespace LibraryUnitTest
{
    [TestClass]
    public class UnitTestPublisherDataAccess
    {

        public string _conn = "Data Source = LAPTOP-286\\SQLEXPRESS;Initial Catalog = TestLibraryDB; Integrated Security = True";
        private PublisherDataAccess _data;
        Publisher testPub = new Publisher();

        public UnitTestPublisherDataAccess()
        {
            _data = new PublisherDataAccess(_conn);
        }

        [TestMethod]
        public void TestGetPublisher()
        {
            

        }

        [TestMethod]
        public void TestCreatePublisher()
        {
            

        }

        [TestMethod]
        public void TestUpdatePublisher()
        {
            

        }

        [TestMethod]
        public void TestDeletePublisher()
        {
            

        }
    }
}
