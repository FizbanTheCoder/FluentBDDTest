using System;
using System.Collections.Generic;
using System.Text;

namespace IFlow.Testing.Utils.DataFactory
{
    public static class ProjectData
    {
        public static string ProjectName => new Bogus.Faker().Company.Random.Words(1);
        public static string ProjectDescription => new Bogus.Faker().Company.Random.Words(1);
        public static string ProjectStreet => new Bogus.Faker().Address.StreetName();
        public static string ProjectCountry => new Bogus.Faker().Address.County();
        public static string ProjectCity => new Bogus.Faker().Address.City();
        public static string ProjectPostalCode => new Bogus.Faker().Address.ZipCode("##-###");
        public static string ProjectProvince => new Bogus.Faker().Address.County();
        public static int ProjectValue => new Bogus.Faker().Random.Int(1, 10000);
        public static string ProjectCurrency => new Bogus.Faker().Finance.Currency().Code;
        public static string ProjectType => new Bogus.Faker().Company.Random.Word();
        public static string ProjectConstructionType => new Bogus.Faker().Company.Random.Word();
        public static string ProjectNumber => new Bogus.Faker().Company.Random.Word();
        public static string ProjectTimeZone => new Bogus.Faker().Company.Random.Word();
        public static string ProjectLanguage => new Bogus.Faker().Company.Random.Word();
        public static string ProjectLanguageCode => new Bogus.Faker().Address.CountryCode();
        public static string ProjectCountryCode => new Bogus.Faker().Address.CountryCode();

        public static string ProjectStartDate()
        {
            var date = DateTime.UtcNow.ToUniversalTime();
            var dateTimeUtc = date.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fff'Z'");
            return dateTimeUtc;
        }

        public static string ProjectEndDate()
        {
            var date = DateTime.UtcNow.ToUniversalTime();
            var newDate = date.AddYears(1);
            var dateTimeUtc = newDate.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fff'Z'");
            return dateTimeUtc;
        }
    }
}
