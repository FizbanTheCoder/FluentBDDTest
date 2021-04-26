using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using Bogus;
using Bogus.DataSets;

namespace IFlow.Testing.Utils.DataFactory
{
    public static class UserData
    {
        public static string RegistrationUserName => new Bogus.Person().UserName;
        public static string FirsName => new Bogus.Person().FirstName;
        public static string LastName => new Bogus.Person().LastName;
        public static string Email => new Bogus.Faker().Internet.ExampleEmail();
        public static string Country => new Bogus.Faker().Address.Country();
        public static string PhoneNumber => new Faker().Phone.PhoneNumber("#########");


        public static string Password(this Internet internet, int minLength, int maxLength)
        {
            var r = internet.Random;

            var lowercase = r.Char('a', 'z').ToString();
            var uppercase = r.Char('A', 'Z').ToString();
            var number = r.Char('0', '9').ToString();
            var symbol = r.Char('!', '/').ToString();
            var padding = r.String2(minLength - 4);
            var padding2 = r.String2(r.Number(0, maxLength - minLength));  // random extra padding between min and max

            var chars = (lowercase + uppercase + number + symbol + padding + padding2).ToArray();
            var shuffledChars = r.Shuffle(chars).ToArray();

            return new string(shuffledChars);
        }

        //TODO https://github.com/bchavez/Bogus/issues/219
    }
}
