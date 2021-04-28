using System;
using System.Data.SqlClient;
using System.Linq;
using Dapper;

namespace IFlow.Testing.Utils.DataBase
{
    public class DapperExample
    {
        public static void GetData()
        {
            const string sql = "SELECT UserName FROM dbo.Accounts WHERE Id = '90068944-18C0-4A23-A0DF-BF1C747F162D';";
            using (var connection = new SqlConnection("Server=tcp:sql-iflow-dev.database.windows.net,1433;Initial Catalog=sqldb-iflow-dev;Persist Security Info=False;User ID=iFlow;Password=Passw0rd!;MultipleActiveResultSets=False; Encrypt=True; TrustServerCertificate=False;Connection Timeout=30;"))
            {
                connection.Open();
                var affectedRows = connection.Query<string>(sql).FirstOrDefault();
                
                Console.WriteLine(affectedRows);

            }
        }
    }
}
