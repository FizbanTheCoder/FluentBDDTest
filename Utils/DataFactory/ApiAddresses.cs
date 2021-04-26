using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace IFlow.Testing.Utils.DataFactory
{
    public static class ApiAddresses
    {
        private static string BaseApiUrl => "https://app-iflow-api-dev-001.azurewebsites.net/api/";
        public static string AccountsRegistrationApi => BaseApiUrl + "Accounts";
        public static string AuthLoginToAccount => BaseApiUrl + "Auth";

    }

}
