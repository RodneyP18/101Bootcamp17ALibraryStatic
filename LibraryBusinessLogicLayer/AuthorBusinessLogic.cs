using LibraryCommon;
using LibraryDatabaseAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBusinessLogicLayer
{
    public class AuthorBusinessLogic
    {
        private AuthorDataAccess _data;

        public AuthorBusinessLogic()
        {
            _data = new AuthorDataAccess();
        }

        public AuthorBusinessLogic(string conn)
        {
            _data = new AuthorDataAccess(conn);
        }

        public List<Author> BLGetAuthors()
        {
            List<Author> _list = _data.GetAuthors();
            return _list;
        }

        public void BLCreateAuthor(Author a)
        {
            _data.CreateAuthor(a);
        }

        public void BLUpdateAuthor(Author a)
        {
            _data.UpdateAuthor(a);
        }

        public void BLDeleteAuthor(Author a)
        {
            _data.DeleteAuthor(a);
        }
    }
}
