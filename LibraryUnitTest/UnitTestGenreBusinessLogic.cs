using LibraryBusinessLogicLayer;
using LibraryCommon;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LibraryUnitTest
{
    [TestClass]
    public class UnitTestGenreBusinessLogic
    {

        public string _conn = "Data Source = LAPTOP-286\\SQLEXPRESS;Initial Catalog = TestLibraryDB; Integrated Security = True";
        private GenreBusinessLogic _data;
        Genre testUser = new Genre();

        public UnitTestGenreBusinessLogic()
        {
            _data = new GenreBusinessLogic(_conn);
        }


        [TestMethod]
        public void TestBLGetGenres()
        {

        }

        [TestMethod]
        public void TestBLCreateGenre()
        {

        }

        [TestMethod]
        public void TestBLUpdateGenre()
        {

        }

        [TestMethod]
        public void TestBLDeleteGenre()
        {

        }
    }
}
