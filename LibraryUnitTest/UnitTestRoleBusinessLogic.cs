using LibraryBusinessLogicLayer;
using LibraryCommon;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LibraryUnitTest
{
    [TestClass]
    public class UnitTestRoleBusinessLogic
    {

        public string _conn = "Data Source = LAPTOP-286\\SQLEXPRESS;Initial Catalog = TestLibraryDB; Integrated Security = True";
        private RoleBusinessLogic _data;
        Role testUser = new Role();

        public UnitTestRoleBusinessLogic()
        {
            _data = new RoleBusinessLogic(_conn);
        }


        [TestMethod]
        public void TestBLGetRoles()
        {

        }

        [TestMethod]
        public void TestBLCreateRole()
        {

        }

        [TestMethod]
        public void TestBLUpdateRole()
        {

        }

        [TestMethod]
        public void TestBLDeleteRole()
        {

        }
    }
}
