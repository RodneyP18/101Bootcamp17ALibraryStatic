using LibraryCommon;
using LibraryDatabaseAccessLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data.SqlClient;

namespace LibraryUnitTest
{
    [TestClass]
    public class UnitTestBookDataAccess
    {
        public string _conn = "Data Source = LAPTOP-286\\SQLEXPRESS;Initial Catalog = TestLibraryDB; Integrated Security = True";
        private BookDataAccess _data;
        Book testBook = new Book();

        public UnitTestBookDataAccess()
        {
            _data = new BookDataAccess(_conn);
        }

        [TestMethod]
        public void TestGetBook()
        {
            

        }

        [TestMethod]
        public void TestCreateBook()
        {
            

        }

        [TestMethod]
        public void TestUpdateBook()
        {
            

        }

        [TestMethod]
        public void TestDeleteBook()
        {
            

        }
    }
}
