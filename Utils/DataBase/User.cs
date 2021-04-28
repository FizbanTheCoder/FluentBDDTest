using System;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using static IFlow.Testing.Utils.DataFactory.DataBase;

namespace IFlow.Testing.Utils.DataBase
{
    public class User
    {
        public static string GetData(string userId)
        {
            var sql = FindUserNameForId(userId);
            using (var connection = new SqlConnection(DataBaseConnectionString))
            {
                connection.Open();
                return connection.Query<string>(sql).FirstOrDefault();
            }
        }
    }
}
