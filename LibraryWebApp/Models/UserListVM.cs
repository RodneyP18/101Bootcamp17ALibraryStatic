using LibraryCommon;
using LibraryWebApp.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryWebApp.Models
{
    public class UserListVM
    {
        Mapper mapper = new Mapper();

        public IEnumerable<UserModel> ListOfUserModels { get; set; }
       
        public UserListVM(List<User> list)
        {
            ListOfUserModels = mapper.UserListToUserModels(list);
        }
    }
}