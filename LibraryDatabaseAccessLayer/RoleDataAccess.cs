using LibraryCommon;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDatabaseAccessLayer
{
    public class RoleDataAccess
    {

        private string _conn = "";

        public RoleDataAccess()
        {

        }
        public RoleDataAccess(string conn)
        {
            _conn = conn;
        }

        public List<Role> GetRoles()
        {
            List<Role> _list = new List<Role>();

            using (SqlConnection con = new SqlConnection(_conn))
            {
                using (SqlCommand _sqlCommand = new SqlCommand("spGetRole", con))
                {
                    _sqlCommand.CommandType = CommandType.Text;
                    _sqlCommand.CommandTimeout = 35;

                    con.Open();
                    Role _role;

                    using (SqlDataReader reader = _sqlCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            _role = new Role
                            {
                                RoleID = reader.GetInt32(reader.GetOrdinal("RoleID")),
                                RoleName = (string)reader["RoleName"],

                            };
                            _list.Add(_role);
                        }
                    }
                    con.Close();
                }
            }
            return _list;
        }

        public void CreateRole(Role r)
        {


            using (SqlConnection con = new SqlConnection(_conn))
            {
                using (SqlCommand _sqlCommand = new SqlCommand("spCreateRole", con))
                {
                    _sqlCommand.CommandType = CommandType.StoredProcedure;
                    _sqlCommand.CommandTimeout = 30;
                    

                    SqlParameter _paramRoleName = _sqlCommand.CreateParameter();
                    _paramRoleName.DbType = DbType.String;
                    _paramRoleName.ParameterName = "@ParamRoleName";
                    _paramRoleName.Value = r.RoleName;
                    _sqlCommand.Parameters.Add(_paramRoleName);


                    //SqlParameter _paramRoleIDReturn = _sqlCommand.CreateParameter();
                    //_paramRoleIDReturn.DbType = DbType.Int32;
                    //_paramRoleIDReturn.ParameterName = "@ParamOutRoleID";
                    //var pk = _sqlCommand.Parameters.Add(_paramRoleIDReturn);
                    //_paramRoleIDReturn.Direction = ParameterDirection.Output;


                    con.Open();
                    _sqlCommand.ExecuteNonQuery();   // calls the sp 
                    
                    con.Close();
                    
                }
            }
        }


        public void DeleteRole(Role r)
        {
            using (SqlConnection con = new SqlConnection(_conn))
            {
                using (SqlCommand _sqlCommand = new SqlCommand("spDeleteRole", con))
                {
                    _sqlCommand.CommandType = CommandType.StoredProcedure;
                    _sqlCommand.CommandTimeout = 30;
                    SqlParameter _parameter = _sqlCommand.CreateParameter();
                    _parameter.DbType = DbType.Int32;
                    _parameter.ParameterName = "@ParamRoleID";
                    _parameter.Value = r.RoleID;
                    _sqlCommand.Parameters.Add(_parameter);


                    con.Open();
                    _sqlCommand.ExecuteNonQuery();   // calls the sp                 
                    con.Close();
                }
            }
        }


        public void UpdateRole(Role r)
        {
            using (SqlConnection con = new SqlConnection(_conn))
            {
                using (SqlCommand _sqlCommand = new SqlCommand("spUpdateRole", con))
                {
                    _sqlCommand.CommandType = CommandType.StoredProcedure;
                    _sqlCommand.CommandTimeout = 30;


                    SqlParameter _paramRoleName = _sqlCommand.CreateParameter();
                    _paramRoleName.DbType = DbType.String;
                    _paramRoleName.ParameterName = "@ParamRoleName";
                    _paramRoleName.Value = r.RoleName;
                    _sqlCommand.Parameters.Add(_paramRoleName);


                    SqlParameter _paramRoleID = _sqlCommand.CreateParameter();
                    _paramRoleID.DbType = DbType.Int32;
                    _paramRoleID.ParameterName = "@ParamRoleID";
                    _paramRoleID.Value = r.RoleID;
                    _sqlCommand.Parameters.Add(_paramRoleID);


                    con.Open();
                    _sqlCommand.ExecuteNonQuery();   // calls the sp                 
                    con.Close();
                }
            }
        }
    }
}
