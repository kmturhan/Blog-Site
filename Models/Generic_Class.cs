using Dapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Models
{
    public class Generic_Class
    {
        private static string connectionString = @"workstation id=BlogTestDB.mssql.somee.com;packet size=4096;user id=kmturhan_SQLLogin_1;pwd=gq18b1538w;data source=BlogTestDB.mssql.somee.com;persist security info=False;initial catalog=BlogTestDB";
        
        public static IEnumerable<T> GetAllData<T>(string storedProcedureName, DynamicParameters param = null)
        {
            using (SqlConnection dbConnection = new SqlConnection(connectionString))
            {
                dbConnection.Open();
                return dbConnection.Query<T>(storedProcedureName,param, commandType: CommandType.StoredProcedure).ToList<T>(); ;
            }
        }
        public static void ExecuteCommand (string storedProcedureName, DynamicParameters param = null)
        {
            using(SqlConnection dbConnection = new SqlConnection(connectionString))
            {
                dbConnection.Open();
                dbConnection.Execute(storedProcedureName, param, commandType: CommandType.StoredProcedure);
            }
        }

    }
}
