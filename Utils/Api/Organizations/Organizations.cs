using Flurl.Http;
using System.Threading.Tasks;


namespace IFlow.Testing.Utils.Api.Organizations
{
    public static class Organizations
    {
        public static async Task<string> CreateOrganizationForUser(string userToken)
        {
            return (await "https://app-iflow-api-dev-001.azurewebsites.net/api/Organizations"
                .WithOAuthBearerToken(userToken)
                .PostJsonAsync(new
                {
                    Name = "RandomCompanyName",
                    Email = "RandomCompanyEmail",
                    Phone = "randomPdh",
                    Owner = "dwrew",
                    Street = "dweaw",
                    Country = "dwada",
                    City = "dawwa",
                    PostalCode = "dwada",
                    province = "dadawdad"

                }).ReceiveJson()).id;
        }
    }
}
