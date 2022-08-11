using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Reflection;
using System.Text;
using System.Threading.Channels;

namespace Assignment2
{
   public class DataOperation<T>where T:class, new()
   {
        static string connectionString = "Server=DESKTOP-JGAKJQB\\SQLEXPRESS;Database=AspnetCoreB4;Integrated Security=True";
        DatabaseHelper databaseHelper = new DatabaseHelper(connectionString);
        static Type type = typeof(T);
        public void Insert(T itemName)
        {
            StringBuilder query = new StringBuilder("INSERT INTO ").Append(type.Name);
            //PropertyInfo[] properties = type.GetProperties(
            //    System.Reflection.BindingFlags.Instance |
            //    System.Reflection.BindingFlags.DeclaredOnly);
            

            PropertyInfo[] arrayPropertyInfos = type.GetProperties();
            query.Append(" VALUES (");

            foreach (PropertyInfo property in arrayPropertyInfos)
            {
                query.Append("'");
                query.Append(property.GetValue(itemName).ToString()).Append("'").Append(",");
                
            }

            query.Remove(query.Length-1,1);
            query.Append(");");

            //Console.WriteLine(query);
            int rowAffected= databaseHelper.Execute(query.ToString());
            if (rowAffected>0)
            {
                Console.WriteLine("INSERTED INFORMATION SUCCESSFULLY");
            }
            else
            {
                Console.WriteLine("Sorry ..There is Some problem");
            }
            Console.ReadKey();
            //string msg = "";
            //return msg;
        }

        public void Delete(T itemName)
        {
            StringBuilder query = new StringBuilder("DELETE FROM ").Append(type.Name).Append(" WHERE ");
            PropertyInfo[] arrayPropertyInfos = type.GetProperties();
            
            for (var i = 0; i < arrayPropertyInfos.Length; i++)
            {
                var property = arrayPropertyInfos[0];
                query.Append(property.Name).Append(" = ");
                break;

            }
            foreach (PropertyInfo property in arrayPropertyInfos)
            {
                query.Append("'");
                query.Append(property.GetValue(itemName).ToString()).Append("'");
                break;

            }

            query.Append(";");
            int rowAffected = databaseHelper.Execute(query.ToString());
            if (rowAffected > 0)
            {
                Console.WriteLine("INFORMATION DELETED SUCCESSFULLY");
            }
            else
            {
                Console.WriteLine("Sorry ..Here Some Errror happened");
            }
            //Console.WriteLine(query);
            Console.ReadKey();
        }

        public void Update(T itemName)
        {
            StringBuilder query = new StringBuilder("UPDATE ").Append(type.Name).Append(" SET ");
            //var entry = new T();
            //var cols = entry.GetType().GetProperties();
            var cols = type.GetProperties();
            for (int i = 1; i < cols.Length; i++)
            {
                var property = cols[i];
                query.Append(property.Name).Append(" = '").Append(property.GetValue(itemName).ToString()).Append("'");
                //Console.WriteLine(property.Name+" = "+ "'"+property.GetValue(itemName).ToString()+"'");

            }

            query.Append(" WHERE ");
            for (int i = 0; i < cols.Length; i++)
            {
                var property = cols[i];
                query.Append(property.Name).Append(" = '").Append(property.GetValue(itemName).ToString()).Append("'");
                //Console.WriteLine(property.Name+" = "+ "'"+property.GetValue(itemName).ToString()+"'");
                break;

            }

            query.Append(";");
            int rowAffected = databaseHelper.Execute(query.ToString());
            if (rowAffected > 0)
            {
                Console.WriteLine("INFORMATION Updated SUCCESSFULLY");
            }
            else
            {
                Console.WriteLine("Sorry ..Here Some Errror happened");
            }
            
            Console.WriteLine(query);
            Console.ReadKey();
        }

        public List<T> GetAll()
        {
            //Type type = typeof(T);
            
            //PropertyInfo[] arrayPropertyInfos = type.GetProperties();

            //var query = new StringBuilder("SELECT * FROM ").Append(type.Name).Append(";");
            //using var connection = new SqlConnection(connectionString);
            //connection.Open();
            //using var command = new SqlCommand(query.ToString(), connection);

            //using var reader = command.ExecuteReader();

            List<T> listOfT = new List<T>();
            //var entry = new T();
            //var cols = entry.GetType().GetProperties();
            //Console.WriteLine(cols.Length);
            //foreach (var col in cols)
            //{
            //    Console.WriteLine(col.Name);
            //}
           
            //while (reader.Read())
            //{
            //    listOfT.Add(new T
            //    {
            //        for (var i = 0; i < cols.Length; i++)
            //    {
            //        var col = cols[i];
            //        Type t = col.GetType();
            //        //col = ConvertFromCSharpToSqlType(t);
            //        col = (int)reader["@col"];
            //    }

            //cols[0] = (PropertyInfo) reader["Id"]
            //cols[01] = (PropertyInfo) reader["Name"],
            //    Email = (string)reader["Email"]
            //});
            //return students;
            //Console.WriteLine(query);
            //for (int i = 0; i < cols.Length; i++)
            //{
            //    var col = cols[i];
            //    col = 2;
            //}
            //Console.ReadKey();
            return listOfT;
        }
        


    }
}
