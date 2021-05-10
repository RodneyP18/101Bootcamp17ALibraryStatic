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
    public class GenreDataAccess
    {

        private string _conn = "";

        public GenreDataAccess()
        {

        }
        public GenreDataAccess(string conn)
        {
            _conn = conn;
        }

        public List<Genre> GetGenres()
        {
            List<Genre> genres = new List<Genre>();
            List<Genre> _list = genres;


            using (SqlConnection con = new SqlConnection(_conn))
            {
                using (SqlCommand _sqlCommand = new SqlCommand("spGetGenre", con))
                {
                    _sqlCommand.CommandType = CommandType.StoredProcedure;
                    _sqlCommand.CommandTimeout = 35;
                    
                    con.Open();
                    Genre _Genre;
                    using (SqlDataReader reader = _sqlCommand.ExecuteReader())
                    {


                        while (reader.Read())
                        {


                            _Genre = new Genre
                            {
                                GenreID = reader.GetInt32(reader.GetOrdinal("GenreID")),
                                Name = (string)reader["Name"],
                                Description = (string)reader["Description"],
                                IsFiction = (bool)reader["isFiction"],


                            }; _list.Add(_Genre);
                        }


                    }
                    con.Close();


                }
                return _list;
            }
        }

       
        public void CreateGenre(Genre g)
        {
            using (SqlConnection con = new SqlConnection(_conn))
            {


                using (SqlCommand _sqlCommand = new SqlCommand("spCreateGenre", con))
                {

                    _sqlCommand.CommandType = CommandType.StoredProcedure;
                    _sqlCommand.CommandTimeout = 30;


                    SqlParameter _paramName = _sqlCommand.CreateParameter();
                    _paramName.DbType = DbType.String;
                    _paramName.ParameterName = "@ParamName";
                    _paramName.Value = g.Name;
                    _sqlCommand.Parameters.Add(_paramName);


                    SqlParameter _paramDescription = _sqlCommand.CreateParameter();
                    _paramDescription.DbType = DbType.String;
                    _paramDescription.ParameterName = "@ParamDescription";
                    _paramDescription.Value = g.Description;
                    _sqlCommand.Parameters.Add(_paramDescription);


                    SqlParameter _paramIsFiction = _sqlCommand.CreateParameter();
                    _paramIsFiction.DbType = DbType.Boolean;
                    _paramIsFiction.ParameterName = "@ParamIsFiction";
                    _paramIsFiction.Value = g.IsFiction;
                    _sqlCommand.Parameters.Add(_paramIsFiction);


                    con.Open();
                    _sqlCommand.ExecuteNonQuery();   // calls the 
                    //var result = _paramAuthorIDReturn.Value;
                    con.Close();
                    //return (int)result;
                }
            }
        }

        public void UpdateGenre(Genre g)
        {
            using (SqlConnection con = new SqlConnection(_conn))
            {
                using (SqlCommand _sqlCommand = new SqlCommand("spUpdateGenre", con))
                {
                    _sqlCommand.CommandType = CommandType.StoredProcedure;
                    _sqlCommand.CommandTimeout = 30;


                    SqlParameter _paramGenreID = _sqlCommand.CreateParameter();
                    _paramGenreID.DbType = DbType.Int32;
                    _paramGenreID.ParameterName = "@ParamGenreID";
                    _paramGenreID.Value = g.GenreID;
                    _sqlCommand.Parameters.Add(_paramGenreID);


                    SqlParameter _paramGenreName = _sqlCommand.CreateParameter();
                    _paramGenreName.DbType = DbType.String;
                    _paramGenreName.ParameterName = "@ParamName";
                    _paramGenreName.Value = g.Name;
                    _sqlCommand.Parameters.Add(_paramGenreName);


                    SqlParameter _paramGenreIsFiction = _sqlCommand.CreateParameter();
                    _paramGenreIsFiction.DbType = DbType.Boolean;
                    _paramGenreIsFiction.ParameterName = "@ParamIsFiction";
                    _paramGenreIsFiction.Value = g.IsFiction;
                    _sqlCommand.Parameters.Add(_paramGenreIsFiction);


                    SqlParameter _paramGenreDescription = _sqlCommand.CreateParameter();
                    _paramGenreDescription.DbType = DbType.String;
                    _paramGenreDescription.ParameterName = "@ParamDescription";
                    _paramGenreDescription.Value = g.Description;
                    _sqlCommand.Parameters.Add(_paramGenreDescription);


                    con.Open();
                    _sqlCommand.ExecuteNonQuery();   // calls the sp                                                      
                    con.Close();


                }
            }
        }


        public void DeleteGenre(Genre g)
        {
            using (SqlConnection con = new SqlConnection(_conn))
            {
                using (SqlCommand _sqlCommand = new SqlCommand("spDeleteGenre", con))
                {
                    _sqlCommand.CommandType = CommandType.StoredProcedure;
                    _sqlCommand.CommandTimeout = 30;


                    SqlParameter _parameter = _sqlCommand.CreateParameter();
                    _parameter.DbType = DbType.Int32;
                    _parameter.ParameterName = "@ParamGenreID";
                    _parameter.Value = g.GenreID;
                    _sqlCommand.Parameters.Add(_parameter);


                    con.Open();
                    _sqlCommand.ExecuteNonQuery();   // calls the sp                 
                    con.Close();
                }
            }
        }
    }
}
    