using LibraryCommon;
using LibraryWebApp.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryWebApp.Models
{
    public class AuthorListVM
    {
        Mapper mapper = new Mapper();

        public IEnumerable<AuthorModel> ListOfAuthorModels { get; set; }

        public AuthorListVM(List<Author> list)
        {
            ListOfAuthorModels = mapper.AuthorListToAuthorModels(list);
        }
    }
}