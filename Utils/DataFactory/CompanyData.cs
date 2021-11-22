using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Bogus;
using Microsoft.AspNetCore.Razor.Language.CodeGeneration;

namespace IFlow.Testing.Utils.DataFactory
{
    //TODO: Delete

    public static class CompanyData
    {
        public static string Name => new Bogus.Faker().Company.CompanyName();
        public static string Email => new Bogus.Faker().Internet.ExampleEmail();
        public static string PhoneNumber => new Faker().Phone.PhoneNumber("#########");
        public static string Country => new Bogus.Faker().Address.Country();
        public static string City => new Bogus.Faker().Address.City();
        public static string PostalCode => new Bogus.Faker().Address.ZipCode("##-###");
        public static string Province => new Bogus.Faker().Address.State();
        public static string Street => new Bogus.Faker().Address.StreetName();
    }

}
