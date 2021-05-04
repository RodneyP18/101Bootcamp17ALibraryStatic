using LibraryCommon;
using LibraryWebApp.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryWebApp.Models
{
    public class RoleListVM
    {
        Mapper mapper = new Mapper();
        public IEnumerable<RoleModel> ListOfRoleModels { get; set; }

        public RoleListVM(List<Role> list)
        {
            ListOfRoleModels = mapper.RoleListToRoleModels(list);
        }
    }

    
}