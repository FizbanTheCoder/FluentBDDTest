using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Bogus.DataSets;
using Flurl.Http;
using IFlow.Testing.Utils.DataFactory;

namespace IFlow.Testing.Utils.Api.ProjectStage
{
    public static class ProjectStage
    {
        public static async Task<string> GetProjectStageId(string userToken, string organizationId)
        {
            return (await ApiAddresses.GetProjectStagesApiUrl(organizationId)
                .WithOAuthBearerToken(userToken)
                .GetJsonAsync()).items[0].id;
        }
    }
}
