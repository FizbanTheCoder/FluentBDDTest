using System.Threading.Tasks;
using Flurl.Http;

namespace IFlow.Testing.Utils.Api.Accounts
{
    public static class Accounts
    {
        public static async Task AccountsCreateAccount()
        {
             await "https://app-iflow-api-dev-001.azurewebsites.net/api/Accounts"
                .PostJsonAsync(new
                {
                    UserName = "lezid3d2", 
                    FirstName = "Leszek", 
                    LastName = "Zielinski",
                    Email = "xlselektor+32132fed@gmail.com",
                    Password = "RR**^^445577tt",
                    Country = "Poland",
                    PhoneNumber ="501081616"
                });
        }
    }
}
