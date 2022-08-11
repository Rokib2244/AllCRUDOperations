using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Assignment2
{
   public class DatabaseHelper
    {
        private readonly string _connectionString;

        public DatabaseHelper(string connectionString)
        {
            _connectionString = connectionString;
        }
        
        public int Execute(string sql)
        {
            using var connection = new SqlConnection(_connectionString);
            connection.Open();
            using var command = new SqlCommand(sql, connection);
            int rowaffected = command.ExecuteNonQuery();
            return rowaffected;
        }
    }
}
