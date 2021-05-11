using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Bogus.DataSets;
using Flurl.Http;
using IFlow.Testing.Utils.DataFactory;

namespace IFlow.Testing.Utils.Api.BusinessUnit
{
    public static class BusinessUnit
    {
        public static async Task<string> CreateBusinessUnit(string userToken, string businessUnitName, string organizationId)
        {
            return (await ApiAddresses.BusinessUnitApiUrl
                .WithOAuthBearerToken(userToken)
                .PostJsonAsync(new
                {
                    Name = businessUnitName,
                    OrganizationId = organizationId
                }
                ).ReceiveJson()).id;
        }
    }
}
