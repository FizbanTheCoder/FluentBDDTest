using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Bogus.DataSets;
using Flurl.Http;
using IFlow.Testing.Utils.DataFactory;

namespace IFlow.Testing.Utils.Api.Investments
{
    public static class Investments
    {
        public static async Task<string> CreateInvestment(string userToken, string investmentName ,string organizationId)
        {
            return (await ApiAddresses.InvestmentsApiUrl
                .WithOAuthBearerToken(userToken)
                .PostJsonAsync(new
                    {
                        Name = "",
                        OrganitionId = organizationId
                    }
                ).ReceiveJson()).id;
        }
    }
}
