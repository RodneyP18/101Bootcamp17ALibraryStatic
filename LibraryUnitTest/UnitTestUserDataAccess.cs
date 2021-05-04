using LibraryCommon;
using LibraryDatabaseAccessLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace LibraryUnitTest
{
    [TestClass]
    public class UnitTestUserDataAccess
    {
        public string _conn = "Data Source = LAPTOP-286\\SQLEXPRESS;Initial Catalog = TestLibraryDB; Integrated Security = True";
        private UserDataAccess _data;
        User testUser = new User();

        public UnitTestUserDataAccess()
        {
            _data = new UserDataAccess(_conn);
        }

        [TestMethod]
        public void TestGetUser()
        {
            List<User> users = _data.GetUsers();

            Assert.AreEqual(3 , users.Count);

        }

        [TestMethod]
        public void TestCreateUser()
        {
            testUser.FirstName = "Joe";
            testUser.LastName = "Johnson";
            testUser.UserName = "JoeJohnson";
            testUser.Password = "password123";
            testUser.RoleID_FK = 3;

            _data.CreateUser(testUser);

            List<User> users = _data.GetUsers();

            foreach (User user in users)
            {
                if (user.FirstName.Equals("Joe"))
                {
                    Assert.AreEqual("Joe", user.FirstName);
                    Assert.AreEqual("Johnson", user.LastName);
                    Assert.AreEqual("JoeJohnson", user.UserName);
                    Assert.AreEqual("password123", user.Password);
                    Assert.AreEqual(3, user.RoleID_FK);
                }
            }
        }

        [TestMethod]
        public void TestUpdateUser()
        {

            testUser.UserID = 1;
            testUser.FirstName = "Bro";
            testUser.LastName = "Dude";
            testUser.UserName = "BroDude";
            testUser.Password = "password123";
            testUser.RoleID_FK = 3;

            _data.UpdateUser(testUser);

            List<User> users = _data.GetUsers();


            foreach (User user in users)
            {
                if (user.UserID.Equals(1))
                {
                    Assert.AreEqual(1, user.UserID);
                    Assert.AreEqual("Bro", user.FirstName);
                    Assert.AreEqual("Dude", user.LastName);
                    Assert.AreEqual("BroDude", user.UserName);
                    Assert.AreEqual("password123", user.Password);
                    Assert.AreEqual(3, user.RoleID_FK);
                }
            }

        }

        [TestMethod]
        public void TestDeleteUser()
        {
            List<User> users = _data.GetUsers();


            foreach (User user in users)
            {
                if (user.FirstName.Equals("Joe"))
                {
                    testUser.UserID = user.UserID;
                }
            }

            _data.DeleteUser(testUser);

            List<User> testUsers = _data.GetUsers();

            Assert.AreEqual(testUsers.Count, 3);
        }

        [TestMethod]
        public void TestUpdateUserBack()
        {

            testUser.UserID = 1;
            testUser.FirstName = "Rodney";
            testUser.LastName = "Parshall";
            testUser.UserName = "Buddy";
            testUser.Password = "RP";
            testUser.RoleID_FK = 1;

            _data.UpdateUser(testUser);

            List<User> users = _data.GetUsers();


            foreach (User user in users)
            {
                if (user.UserID.Equals(1))
                {
                    Assert.AreEqual(1, user.UserID);
                    Assert.AreEqual("Rodney", user.FirstName);
                    Assert.AreEqual("Parshall", user.LastName);
                    Assert.AreEqual("Buddy", user.UserName);
                    Assert.AreEqual("RP", user.Password);
                    Assert.AreEqual(1, user.RoleID_FK);
                }
            }

        }
    }
}
