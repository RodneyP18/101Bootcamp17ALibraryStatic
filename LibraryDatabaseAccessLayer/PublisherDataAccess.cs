﻿using LibraryCommon;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDatabaseAccessLayer
{
    public class PublisherDataAccess
    {
        private string _conn = "";

        public PublisherDataAccess()
        {

        }
        public PublisherDataAccess(string conn)
        {
            _conn = conn;
        }

        public List<Publisher> GetPublishers()
        {
            List<Publisher> _list = new List<Publisher>();
            using (SqlConnection con = new SqlConnection(_conn))
            {
                using (SqlCommand _sqlCommand = new SqlCommand("spGetPublisher", con))
                {
                    _sqlCommand.CommandType = CommandType.StoredProcedure;
                    _sqlCommand.CommandTimeout = 30;


                    con.Open();
                    Publisher _pub;
                    using (SqlDataReader reader = _sqlCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            _pub = new Publisher
                            {
                                PublisherID = reader.GetInt32(reader.GetOrdinal("PublisherID")),
                                Name = (string)reader["Name"],
                                Address = (string)reader["Address"],
                                City = (string)reader["City"],
                                State = (string)reader["State"],
                                Zip = reader.GetInt32(reader.GetOrdinal("Zip")),

                            };
                            _list.Add(_pub);
                        }
                    }
                    con.Close();
                }
            }
            return _list;
        }


        public void CreatePublisher(Publisher p)
        {
            using (SqlConnection con = new SqlConnection(_conn))
            {
                using (SqlCommand _sqlCommand = new SqlCommand("spCreatePublisher", con))
                {
                    _sqlCommand.CommandType = CommandType.StoredProcedure;
                    _sqlCommand.CommandTimeout = 30;


                    SqlParameter _paramPublisherName = _sqlCommand.CreateParameter();
                    _paramPublisherName.DbType = DbType.String;
                    _paramPublisherName.ParameterName = "@ParamPublisherName";
                    _paramPublisherName.Value = p.Name;
                    _sqlCommand.Parameters.Add(_paramPublisherName);


                    SqlParameter _paramPublisherAddress = _sqlCommand.CreateParameter();
                    _paramPublisherAddress.DbType = DbType.String;
                    _paramPublisherAddress.ParameterName = "@ParamPublisherAddress";
                    _paramPublisherAddress.Value = p.Address;
                    _sqlCommand.Parameters.Add(_paramPublisherAddress);


                    SqlParameter _paramPublisherCity = _sqlCommand.CreateParameter();
                    _paramPublisherCity.DbType = DbType.String;
                    _paramPublisherCity.ParameterName = "@ParamPublisherCity";
                    _paramPublisherCity.Value = p.City;
                    _sqlCommand.Parameters.Add(_paramPublisherCity);


                    SqlParameter _paramPublisherState = _sqlCommand.CreateParameter();
                    _paramPublisherState.DbType = DbType.String;
                    _paramPublisherState.ParameterName = "@ParamPublisherState";
                    _paramPublisherState.Value = p.State;
                    _sqlCommand.Parameters.Add(_paramPublisherState);


                    SqlParameter _paramPublisherZip = _sqlCommand.CreateParameter();
                    _paramPublisherZip.DbType = DbType.Int32;
                    _paramPublisherZip.ParameterName = "@ParamPublisherZip";
                    _paramPublisherZip.Value = p.Zip;
                    _sqlCommand.Parameters.Add(_paramPublisherZip);


                    con.Open();
                    _sqlCommand.ExecuteNonQuery();   // calls the sp                                                      
                    //var result = _paramPublisherIDReturn.Value;
                    con.Close();
                    //return (int)result;
                }


            }
        }


        public void UpdatePublisher(Publisher p)
        {
            using (SqlConnection con = new SqlConnection(_conn))
            {
                using (SqlCommand _sqlCommand = new SqlCommand("spUpdatePublisher", con))
                {
                    _sqlCommand.CommandType = CommandType.StoredProcedure;
                    _sqlCommand.CommandTimeout = 30;


                    SqlParameter _paramPublisherName = _sqlCommand.CreateParameter();
                    _paramPublisherName.DbType = DbType.String;
                    _paramPublisherName.ParameterName = "@ParamPublisherName";
                    _paramPublisherName.Value = p.Name;
                    _sqlCommand.Parameters.Add(_paramPublisherName);


                    SqlParameter _paramPublisherAddress = _sqlCommand.CreateParameter();
                    _paramPublisherAddress.DbType = DbType.String;
                    _paramPublisherAddress.ParameterName = "@ParamPublisherAddress";
                    _paramPublisherAddress.Value = p.Address;
                    _sqlCommand.Parameters.Add(_paramPublisherAddress);


                    SqlParameter _paramPublisherCity = _sqlCommand.CreateParameter();
                    _paramPublisherCity.DbType = DbType.String;
                    _paramPublisherCity.ParameterName = "@ParamPublisherCity";
                    _paramPublisherCity.Value = p.City;
                    _sqlCommand.Parameters.Add(_paramPublisherCity);


                    SqlParameter _paramPublisherState = _sqlCommand.CreateParameter();
                    _paramPublisherState.DbType = DbType.String;
                    _paramPublisherState.ParameterName = "@ParamPublisherState";
                    _paramPublisherState.Value = p.State;
                    _sqlCommand.Parameters.Add(_paramPublisherState);


                    SqlParameter _paramPublisherZip = _sqlCommand.CreateParameter();
                    _paramPublisherZip.DbType = DbType.Int32;
                    _paramPublisherZip.ParameterName = "@ParamPublisherZip";
                    _paramPublisherZip.Value = p.Zip;
                    _sqlCommand.Parameters.Add(_paramPublisherZip);


                    con.Open();
                    _sqlCommand.ExecuteNonQuery();   // calls the sp                                                      
                    con.Close();


                }
            }
        }

        public void DeletePublisher(Publisher p)
        {
            using (SqlConnection con = new SqlConnection(_conn))
            {
                using (SqlCommand _sqlCommand = new SqlCommand("spDeletePublisher", con))
                {
                    _sqlCommand.CommandType = CommandType.StoredProcedure;
                    _sqlCommand.CommandTimeout = 30;


                    SqlParameter _parameter = _sqlCommand.CreateParameter();
                    _parameter.DbType = DbType.Int32;
                    _parameter.ParameterName = "@ParamPublisherID";
                    _parameter.Value = p.PublisherID;
                    _sqlCommand.Parameters.Add(_parameter);


                    con.Open();
                    _sqlCommand.ExecuteNonQuery();   // calls the sp                 
                    con.Close();
                }
            }
        }
    }
}
