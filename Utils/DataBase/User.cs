using System;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using static IFlow.Testing.Utils.DataFactory.DataBase;

namespace IFlow.Testing.Utils.DataBase
{
    public class User
    {
        public static string GetUserNameForId(string userId)
        {
            var sql = FindUserNameForId(userId);
            using var connection = new SqlConnection(DataBaseConnectionString);
            connection.Open();
            return connection.Query<string>(sql).FirstOrDefault();
        }

        public static void UpdateEmailConformationForAccepted(string userId)
        {

            var sql = $"UPDATE [dbo].[Accounts] SET [EmailConfirmed] = 1 WHERE [UserName] = '{userId}'";
            using var connection = new SqlConnection(DataBaseConnectionString);
            connection.Open();
            var firstOrDefault = connection.Query<string>(sql).FirstOrDefault();
        }
    }
}
