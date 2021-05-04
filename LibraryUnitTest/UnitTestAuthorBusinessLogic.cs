using LibraryBusinessLogicLayer;
using LibraryCommon;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LibraryUnitTest
{
    [TestClass]
    public class UnitTestAuthorBusinessLogic
    {

        public string _conn = "Data Source = LAPTOP-286\\SQLEXPRESS;Initial Catalog = TestLibraryDB; Integrated Security = True";
        private AuthorBusinessLogic _data;
        Author testUser = new Author();

        public UnitTestAuthorBusinessLogic()
        {
            _data = new AuthorBusinessLogic(_conn);
        }


        [TestMethod]
        public void TestBLGetAuthors()
        {

        }

        [TestMethod]
        public void TestBLCreateAuthor()
        {

        }

        [TestMethod]
        public void TestBLUpdateAuthor()
        {

        }

        [TestMethod]
        public void TestBLDeleteAuthor()
        {

        }
    }
}
