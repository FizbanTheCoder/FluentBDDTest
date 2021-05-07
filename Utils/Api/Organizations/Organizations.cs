using Flurl.Http;
using System.Threading.Tasks;
using IFlow.Testing.Utils.DataFactory;


namespace IFlow.Testing.Utils.Api.Organizations
{
    public static class Organizations
    {
        public static async Task<string> CreateOrganizationForUser(string userToken, string companyName, string companyEmail
        , string companyPhone, string companyOwner, string companyStreet, string companyCountry, string companyCity,
        string postalCode, string countryProvince)
        {
            return (await ApiAddresses.OrganizationsApiUrl
                .WithOAuthBearerToken(userToken)
                .PostJsonAsync(new
                {
                    Name = companyName,
                    Email = companyEmail,
                    Phone = companyPhone,
                    Owner = companyOwner,
                    Street = companyStreet,
                    Country = companyCountry,
                    City = companyCity,
                    PostalCode = postalCode,
                    Province = countryProvince

                }).ReceiveJson()).id;
        }
    }
}
