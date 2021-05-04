using LibraryBusinessLogicLayer;
using LibraryCommon;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LibraryUnitTest
{
    [TestClass]
    public class UnitTestUserBusinessLogic
    {
        public string _conn = "Data Source = LAPTOP-286\\SQLEXPRESS;Initial Catalog = TestLibraryDB; Integrated Security = True";
        private UserBusinessLogic _data;
        User testUser = new User();

        public UnitTestUserBusinessLogic()
        {
            _data = new UserBusinessLogic(_conn);
        }

        [TestMethod]
        public void TestBLGetUsers()
        {

        }

        [TestMethod]
        public void TestBLCreateUser()
        {

        }

        [TestMethod]
        public void TestBLUpdateUser()
        {

        }

        [TestMethod]
        public void TestBLDeleteUser()
        {

        }
    }
}
