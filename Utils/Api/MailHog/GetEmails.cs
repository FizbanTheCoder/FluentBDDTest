using System.Linq;
using System.Threading.Tasks;
using Flurl.Http;
using IFlow.Testing.Utils.DataFactory;

namespace IFlow.Testing.Utils.Api.MailHog
{
    public static class GetEmails
    {
        public static async Task<string> GetBodyValueForCurrentEmail(string userEmail)
        {
            var jsonResponse = (await ApiAddresses.MailHogMessages
                    .WithBasicAuth(Credentials.MailHogLogin,Credentials.MailHogPassword)
                    .GetAsync()
                    .ReceiveJsonList());
            var message = jsonResponse.First(x => x.Content.Headers.To[0] == userEmail);
            string body = message.Content.Body.ToString();
            return body;
        }
    }
}
