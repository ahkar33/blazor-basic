using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace BlazorApp20221221.DataAccess
{
    public class DapperService
    {
        //public static string _connectionString = "Data Source=.;Initial Catalog=TestDb;User ID=sa;Password=sa@123;";
        public static string _connectionString = "Data Source=DESKTOP-MHFBHGS\\SQLEXPRESS;Initial Catalog=TestDb;Integrated Security=SSPI;";

        public List<T> Get<T>(string query)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                var result = db.Query<T>(query).ToList();
                return result;
            }
        }

        public int Execute(string query)
        {
            using(IDbConnection db = new SqlConnection(_connectionString))
            {
                var result = db.Execute(query);
                return result;
            }
        }
    }
}
