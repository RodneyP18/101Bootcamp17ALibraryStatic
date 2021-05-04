using LibraryCommon;
using LibraryDatabaseAccessLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data.SqlClient;

namespace LibraryUnitTest
{
    [TestClass]
    public class UnitTestGenreDataAccess
    {
        public string _conn = "Data Source = LAPTOP-286\\SQLEXPRESS;Initial Catalog = TestLibraryDB; Integrated Security = True";
        private GenreDataAccess _data;
        Genre testGenre = new Genre();

        public UnitTestGenreDataAccess()
        {
            _data = new GenreDataAccess(_conn);
        }

        [TestMethod]
        public void TestGetGenre()
        {
            

        }

        [TestMethod]
        public void TestCreateGenre()
        {
            

        }

        [TestMethod]
        public void TestUpdateGenre()
        {
            

        }

        [TestMethod]
        public void TestDeleteGenre()
        {
            

        }
    }
}
