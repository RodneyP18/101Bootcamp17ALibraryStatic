using LibraryBusinessLogicLayer.Hashing;
using LibraryCommon;
using LibraryCommon.DataEntity;
using LibraryDatabaseAccessLayer;
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

        public ResultUser LoginUser(User userToCheck)
        {
            string salt;
            string hashed = "";
            ResultUser r = new ResultUser();
            List<User> users = BLGetUsers();
            User _foundUser = new User();

            foreach (User current in users)
            {
                if (current.UserName == userToCheck.UserName)
                {
                    _foundUser = current;
                }
            }

            //User _foundUser = users.Where(u => u.UserName == userToCheck.UserName).FirstOrDefault();

            if (_foundUser != null)
            {
                salt = _foundUser.Salt;
                
                hashed = hash.ComputeSHA256Hash(salt + userToCheck.Password);

            }

            if (hashed == _foundUser.Password)
            {
                
                r.User = _foundUser;
                
            }

            return r;
        }

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
