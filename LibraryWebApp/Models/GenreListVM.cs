using LibraryCommon;
using LibraryWebApp.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryWebApp.Models
{
    public class GenreListVM
    {
        Mapper mapper = new Mapper();

        public IEnumerable<GenreModel> ListOfGenreModels { get; set; }

        public GenreListVM(List<Genre> list)
        {
            ListOfGenreModels = mapper.GenreListToGenreModels(list);
        }
    }
}