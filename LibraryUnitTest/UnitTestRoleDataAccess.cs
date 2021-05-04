using LibraryCommon;
using LibraryDatabaseAccessLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data.SqlClient;

namespace LibraryUnitTest
{
    [TestClass]
    public class UnitTestRoleDataAccess
    {
        public string _conn = "Data Source = LAPTOP-286\\SQLEXPRESS;Initial Catalog = TestLibraryDB; Integrated Security = True";
        private RoleDataAccess _data;
        Role testRole = new Role();

        public UnitTestRoleDataAccess()
        {
            _data = new RoleDataAccess(_conn);
        }

        [TestMethod]
        public void TestGetRole()
        {
            

        }

        [TestMethod]
        public void TestCreateRole()
        {
            

        }

        [TestMethod]
        public void TestUpdateRole()
        {
            

        }

        [TestMethod]
        public void TestDeleteRole()
        {
            

        }
    }
}
