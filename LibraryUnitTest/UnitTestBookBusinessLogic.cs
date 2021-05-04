using LibraryBusinessLogicLayer;
using LibraryCommon;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LibraryUnitTest
{
    [TestClass]
    public class UnitTestBookBusinessLogic
    {

        public string _conn = "Data Source = LAPTOP-286\\SQLEXPRESS;Initial Catalog = TestLibraryDB; Integrated Security = True";
        private BookBusinessLogic _data;
        Book testUser = new Book();

        public UnitTestBookBusinessLogic()
        {
            _data = new BookBusinessLogic(_conn);
        }


        [TestMethod]
        public void TestBLGetBooks()
        {

        }

        [TestMethod]
        public void TestBLCreateBook()
        {

        }

        [TestMethod]
        public void TestBLUpdateBook()
        {

        }

        [TestMethod]
        public void TestBLDeleteBook()
        {

        }
    }
}
