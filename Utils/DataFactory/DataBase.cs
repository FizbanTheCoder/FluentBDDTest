using System;
using System.Collections.Generic;
using System.Text;

namespace IFlow.Testing.Utils.DataFactory
{
    public static class DataBase
    {
        public static string DataBaseConnectionString => "Server=tcp:sql-iflow-dev.database.windows.net,1433;Initial Catalog=sqldb-iflow-dev;Persist Security Info=False;User ID=iFlow;Password=Passw0rd!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        public static string FindUserNameForId(string userId) => $"SELECT UserName FROM dbo.Accounts WHERE Id = '{userId}';";
    }
}
