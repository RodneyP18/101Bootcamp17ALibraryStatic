using LibraryCommon;
using LibraryDatabaseAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBusinessLogicLayer
{
    public class RoleBusinessLogic
    {
        private RoleDataAccess _data;

        public RoleBusinessLogic()
        {
            _data = new RoleDataAccess();
        }

        public RoleBusinessLogic(string conn)
        {
            _data = new RoleDataAccess(conn);
        }

        public List<Role> BLGetRoles()
        {
            List<Role> _list = _data.GetRoles();
            return _list;
        }

        public void BLCreateRole(Role r)
        {
            _data.CreateRole(r);
        }

        public void BLUpdateRole(Role r)
        {
            _data.UpdateRole(r);
        }

        public void BLDeleteRole(Role r)
        {
            _data.DeleteRole(r);
        }
    }
}

