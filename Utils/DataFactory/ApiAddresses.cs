using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace IFlow.Testing.Utils.DataFactory
{
    public static class ApiAddresses
    {
        private static string BaseApiUrl => "https://app-iflow-api-dev-001.azurewebsites.net/api/";
        public static string AccountsRegistrationApiUrl => BaseApiUrl + "Accounts";
        public static string AuthLoginToAccountApiUrl => BaseApiUrl + "Auth";
        public static string OrganizationsApiUrl => BaseApiUrl + "Organizations";

        public static string InvestmentsApiUrl => BaseApiUrl + "Investments";
    }

}
