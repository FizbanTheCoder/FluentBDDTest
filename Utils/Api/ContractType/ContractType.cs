using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Bogus.DataSets;
using Flurl.Http;
using IFlow.Testing.Utils.DataFactory;

namespace IFlow.Testing.Utils.Api.ContractType
{
    public static class ContractType
    {
        public static async Task<string> GetContractTypeId(string userToken, string organizationId)
        {
            return (await ApiAddresses.GetContractTypesApiUrl(organizationId)
                .WithOAuthBearerToken(userToken)
                .GetJsonAsync()).items[0].id;           
        }
    }
}
