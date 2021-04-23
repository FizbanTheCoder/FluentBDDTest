using System.Threading.Tasks;
using Flurl.Http;

namespace IFlow.Testing.Utils.Api.Auth
{
    public class AuthRequests
    {
        public static async Task<string> AuthLoginGetToken()
        {
            return (await "https://app-iflow-api-dev-001.azurewebsites.net/api/Auth"
                .PostJsonAsync(new {UsernameOrEmail = "lezi_ext", Password = "R**^^445577t"})
                .ReceiveJson()).accessToken.token;
            
        }
    }
}
