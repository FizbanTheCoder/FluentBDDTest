using System.Threading.Tasks;
using Flurl.Http;
using IFlow.Testing.Utils.DataFactory;

namespace IFlow.Testing.Utils.Api.Accounts
{
    public static class Accounts
    {
        public static async Task AccountsCreateAccount(string userName, string firstName
            , string lastName, string email, string password, string country, string phoneNumber) {
          await ApiAddresses.AccountsRegistrationApiUrl
                .PostJsonAsync(new
                {
                    UserName = userName, 
                    FirstName = firstName, 
                    LastName = lastName,
                    Email = email,
                    Password = password,
                    Country =  country,
                    PhoneNumber = phoneNumber
                });
        }


    }
}
