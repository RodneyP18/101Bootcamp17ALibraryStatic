using LibraryCommon;
using LibraryDatabaseAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBusinessLogicLayer
{
    public class BookBusinessLogic
    {
        private BookDataAccess _data;

        public BookBusinessLogic()
        {
            _data = new BookDataAccess();
        }

        public BookBusinessLogic(string conn)
        {
            _data = new BookDataAccess(conn);
        }

        public List<Book> BLGetBooks()
        {
            List<Book> _list = _data.GetBooks();
            return _list;
        }

        public void BLCreateBook(Book b)
        {
            _data.CreateBook(b);
        }

        public void BLUpdateBook(Book b)
        {
            _data.UpdateBook(b);
        }

        public void BLDeleteBook(Book b)
        {
            _data.DeleteBook(b);
        }
    }
}
