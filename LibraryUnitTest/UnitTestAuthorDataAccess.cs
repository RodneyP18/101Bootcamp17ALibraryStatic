using LibraryCommon;
using LibraryDatabaseAccessLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data.SqlClient;

namespace LibraryUnitTest
{
    [TestClass]
    public class UnitTestAuthorDataAccess
    {
        public string _conn = "Data Source = LAPTOP-286\\SQLEXPRESS;Initial Catalog = TestLibraryDB; Integrated Security = True";
        private AuthorDataAccess _data;
        Author testAuthor = new Author();

        public UnitTestAuthorDataAccess()
        {
            _data = new AuthorDataAccess(_conn);
        }

        [TestMethod]
        public void TestGetAuthor()
        {
            

        }

        [TestMethod]
        public void TestCreateAuthor()
        {
            

        }

        [TestMethod]
        public void TestUpdateAuthor()
        {
            

        }

        [TestMethod]
        public void TestDeleteAuthor()
        {
            

        }
    }
}
