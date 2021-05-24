using System;
using System.Collections.Generic;
using System.Text;
using Bogus;
using Bogus.DataSets;

namespace IFlow.Testing.Utils.DataFactory
{
    public class UserDataFactory
    {
        public static UserDataModel User()
        {
            var userData = new Faker<UserDataModel>()
                .CustomInstantiator(f => new UserDataModel())
                .RuleFor(o => o.UserLogin, f => f.Internet.UserName())
                .RuleFor(o => o.UserName, f => f.Name.FirstName())
                .RuleFor(o => o.UserSurname, f => f.Name.LastName())
                .RuleFor(o => o.UserEmail, f => f.Internet.Email())
                .RuleFor(o => o.UserPassword, new Internet().Password(12, 20))
                .RuleFor(o => o.UserPhoneNumber, f => f.Phone.PhoneNumber("#########"))
                .RuleFor(o => o.UserCountry, f => f.Address.City())
                .Generate();
            return userData;
        }


    }
}
