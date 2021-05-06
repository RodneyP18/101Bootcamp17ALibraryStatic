using LibraryCommon;
using LibraryDatabaseAccessLayer;
using LibraryWebApp.Hashing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBusinessLogicLayer
{
    public class UserBusinessLogic
    {
        private UserDataAccess _data;
        Hasher hash = new Hasher();

        public UserBusinessLogic()
        {
            _data = new UserDataAccess();
        }

        public UserBusinessLogic(string conn)
        {
            _data = new UserDataAccess(conn);
        }

        private static string CreateSalt(int size)
        {
            
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();

            byte[] buff = new byte[size];
            rng.GetBytes(buff);
            
            return Convert.ToBase64String(buff);
        }

        public List<User> BLGetUsers()
        {
            List<User> _list = _data.GetUsers();
            return _list;
        }

        //public User BLGetUserById(int id)
        //{
        //    List<User> users = BLGetUsers();
        //    User user = new User();

        //    foreach (User current in users)
        //    {
        //        if (current.UserID == id)
        //        {
        //            return current;
                    
        //        }
        //    }
        //    return null;
        //}

        public void BLCreateUser(User u)
        {
            string salt = CreateSalt(u.Password.Length);
            string salted = salt + u.Password;
            String toHash = hash.ComputeSHA256Hash(salted);
            u.Password = toHash;
            u.Salt = salt;
            _data.CreateUser(u);
        }

        public void BLUpdateUser(User u)
        {
            
            string salted = u.Salt + u.Password;
            String toHash = hash.ComputeSHA256Hash(salted);
            u.Password = toHash;
            _data.UpdateUser(u);
        }

        public void BLDeleteUser(User u)
        {
            _data.DeleteUser(u);
        }
    }
}
