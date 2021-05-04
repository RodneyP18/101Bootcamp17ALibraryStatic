using LibraryCommon;
using LibraryWebApp.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryWebApp.Models
{
    public class BookListVM
    {
        Mapper mapper = new Mapper();

        public IEnumerable<BookModel> ListOfBookModels { get; set; }

        public BookListVM(List<Book> list)
        {
            ListOfBookModels = mapper.BookListToBookModels(list);
        }
    }
}