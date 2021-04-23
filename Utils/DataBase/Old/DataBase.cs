using System.Configuration;
using System.Linq;

namespace IFlow.WebTests.Utils.DataBase
{
    public class DataBase : QueryObject
    {
        public DataBase() : base("sqlserver", "Server=tcp:sql-iflow-dev.database.windows.net,1433;Initial Catalog =sqldb-iflow-dev; Persist Security Info=False;User ID = iFlow; Password=Passw0rd!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout = 30;")
        {
        }

        public void UserActivationByDataBase(string userName)
        {
            ExecuteQueryFromFileWithParameters<string>("UserActivation.sql", new
            {
                userName = userName,
            }).SingleOrDefault();
        }
    }
}
