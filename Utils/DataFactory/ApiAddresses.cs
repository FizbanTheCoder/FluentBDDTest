using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace IFlow.Testing.Utils.DataFactory
{
    //TODO: Provide correct API data

    public static class ApiAddresses
    {
        private static string BaseApiUrl => "https://community-open-weather-map.p.rapidapi.com/";
        public static string CurrentWeatherDataApiUrl => BaseApiUrl + "weather";
        public static string MonthWeatherDataApiUrl => BaseApiUrl + "climate/month";


        public static string AccountsRegistrationApiUrl => BaseApiUrl + "Accounts";
        public static string AuthLoginToAccountApiUrl => BaseApiUrl + "Auth";
        public static string OrganizationsApiUrl => BaseApiUrl + "Organizations";
        public static string InvestmentsApiUrl => BaseApiUrl + "Investments";
        public static string BusinessUnitApiUrl => BaseApiUrl + "BusinessUnits";
        public static string GetContractTypesApiUrl(string organizationId) => BaseApiUrl + $"ContractTypes?organizationId={organizationId}&pageNumber=1&pageSize=10";
        public static string GetProjectStagesApiUrl(string organizationId) => BaseApiUrl + $"ProjectStages?organizationId={organizationId}&pageNumber=1&pageSize=10";
        public static string ProjectsApiUrl => BaseApiUrl + "Projects";
        private static string MailHogBaseUrl => "http://ci-mailhog-dev.westeurope.azurecontainer.io:8025/";
        public static string MailHogMessages => MailHogBaseUrl + "/api/v1/messages";
    }

}
