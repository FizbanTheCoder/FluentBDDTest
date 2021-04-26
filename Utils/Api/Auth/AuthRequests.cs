using System.Threading.Tasks;
using Flurl.Http;
using IFlow.Testing.Utils.DataFactory;

namespace IFlow.Testing.Utils.Api.Auth
{
    public class AuthRequests
    {
        public static async Task<string> AuthLoginGetToken(string userNameOrEmail, string password)
        {
            return (await ApiAddresses.AuthLoginToAccount
                .PostJsonAsync(new {UsernameOrEmail = userNameOrEmail, Password = password })
                .ReceiveJson()).accessToken.token;
        }
    }
}
