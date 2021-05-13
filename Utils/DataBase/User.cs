using System.Data.SqlClient;
using System.Linq;
using Dapper;
using FluentAssertions;
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

        public static string UserIsExisting(string userName)
        {
            var sql = $"SELECT [UserName] FROM [dbo].[Accounts] WHERE [UserName] = '{userName}'";
            using var connection = new SqlConnection(DataBaseConnectionString);
            connection.Open();
            return connection.Query<string>(sql).FirstOrDefault();
        }

        public static string ProjectIsExisting(string projectId)
        {
            var sql = $"SELECT [Name] FROM [dbo].[Projects] WHERE [Id] = '{projectId}'";
            using var connection = new SqlConnection(DataBaseConnectionString);
            connection.Open();
            var message = connection.Query<string>(sql).FirstOrDefault();
            return message;
        }

        public static string OrganizationIsExisting(string organizationId)
        {
            var sql = $"SELECT [Name] FROM [dbo].[Organizations] WHERE [Id] = '{organizationId}'";
            using var connection = new SqlConnection(DataBaseConnectionString);
            connection.Open();
            var message = connection.Query<string>(sql).FirstOrDefault();
            return message;
        }
    }
}
