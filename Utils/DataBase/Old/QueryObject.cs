using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using Dapper;
using IFlow.WebTests.Utils.ObjectUtils;
using IFlow.WebTests.Utils.Reports;
using Newtonsoft.Json;


namespace IFlow.WebTests.Utils.DataBase
{

   public abstract class QueryObject
    {
        private readonly string connectionString;
        private readonly DbProviderFactory dbProviderFactory;

        protected QueryObject(string providerName, string connectionString)
        {
            dbProviderFactory = DbProviderFactories.GetFactory(providerName);
            this.connectionString = connectionString;
        }

        protected QueryObject(ConnectionStringSettings connectionSettings)
        {
            dbProviderFactory = DbProviderFactories.GetFactory(connectionSettings.ProviderName);
            connectionString = connectionSettings.ConnectionString;
        }

        protected IEnumerable<dynamic> ExecuteQueryFromFileWithParameters(string sqlFileName, object parameters)
        {
            return ExecuteQueryFromFileWithParameters<dynamic>(sqlFileName, parameters);
        }

        protected IEnumerable<TResult> ExecuteQueryFromFileWithParameters<TResult>(string sqlFileName, object parameters)
        {
            var queryString = GetQueryString(sqlFileName);
            return ExecuteQueryWithParameters<TResult>(queryString, parameters);
        }

        private string GetQueryString(string fileName)
        {
            var type = GetType();
            return EmbeddedResourceUtility.GetFileContentsFromNamespace(type.Assembly, type.Namespace, fileName);
        }

        protected IEnumerable<dynamic> ExecuteQueryWithParameters(string sqlQuery, object parameters)
        {
            return ExecuteQueryWithParameters<dynamic>(sqlQuery, parameters);
        }

        private IEnumerable<TResult> ExecuteQueryWithParameters<TResult>(string sqlQuery, object parameters)
        {
            using (var connection = CreateConnection(connectionString))
            {
                connection.Open();
                Logger.Instance.Info(
                    $"Executing SQL:\n {sqlQuery} \n with parameters: \n{JsonConvert.SerializeObject(parameters, Formatting.Indented)}");
                var result = connection.Query<TResult>(sqlQuery, parameters);
                Logger.Instance.Info($"Response:\r\n{JsonConvert.SerializeObject(result, Formatting.Indented)}");
                return result;
            }
        }

        private IDbConnection CreateConnection(string databaseConnectionString)
        {
            var connection = dbProviderFactory.CreateConnection();
            if (connection != null)
            {
                connection.ConnectionString = databaseConnectionString;
            }
            return connection;
        }
    }
}
