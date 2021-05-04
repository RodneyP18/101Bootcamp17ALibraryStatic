using LibraryCommon;
using LibraryWebApp.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryWebApp.Models
{
    public class PublisherListVM
    {
        Mapper mapper = new Mapper();

        public IEnumerable<PublisherModel> ListOfPublisherModels { get; set; }

        public PublisherListVM(List<Publisher> list)
        {
            ListOfPublisherModels = mapper.PublisherListToPublisherModels(list);
        }
    }
}