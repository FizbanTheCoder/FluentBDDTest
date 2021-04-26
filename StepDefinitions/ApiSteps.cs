using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Atata;
using Bogus.DataSets;
using IFlow.Testing.Utils.Api.Accounts;
using IFlow.Testing.Utils.Api.Auth;
using IFlow.Testing.Utils.Api.Organizations;
using IFlow.Testing.Utils.DataFactory;
using TechTalk.SpecFlow;

namespace IFlow.Testing.StepDefinitions
{
    [Binding]
    class ApiSteps : BaseSteps
    {
        [When(@"User send correct data to log in")]
        public async Task WhenUserSendCorrectDataToLogIn()
        {
            var userName = ScenarioContext.Get<string>(ScenarioContextDataKeys.UserName);
            var password = ScenarioContext.Get<string>(ScenarioContextDataKeys.Password);
            
            var token = await AuthRequests.AuthLoginGetToken(userName, password);


            var handler = new JwtSecurityTokenHandler();
            var encodedJwtToken = handler.ReadJwtToken(token);
            var sud = encodedJwtToken.Claims.First(claim => claim.Type == "sub").Value;


            ScenarioContext.Add(ScenarioContextDataKeys.UserToken, token);
        }

        [When(@"Registration by api")]
        public async Task WhenRegistrationByApi()
        {
            var userName = UserData.RegistrationUserName;
            var firstName = UserData.FirsName;
            var lastName = UserData.LastName;
            var email = UserData.Email;
            var password = new Internet().Password(8, 20);
            var country = UserData.Country;
            var phoneNumber = UserData.PhoneNumber;

            await Accounts.AccountsCreateAccount(userName, firstName, lastName, email, password, country, phoneNumber);

            ScenarioContext.Add(ScenarioContextDataKeys.UserName, userName);
            ScenarioContext.Add(ScenarioContextDataKeys.FirstName, firstName);
            ScenarioContext.Add(ScenarioContextDataKeys.LastName, lastName);
            ScenarioContext.Add(ScenarioContextDataKeys.Email, email);
            ScenarioContext.Add(ScenarioContextDataKeys.Password, password);
            ScenarioContext.Add(ScenarioContextDataKeys.Country, country);
            ScenarioContext.Add(ScenarioContextDataKeys.PhoneNumber, phoneNumber);
        }

        [When(@"I create organization for my user")]
        public async Task WhenICreateOrganizationForMyUser()
        {
            var userToken = ScenarioContext.Get<string>(ScenarioContextDataKeys.UserToken);
            await Organizations.CreateOrganizationForUser(userToken);
        }



    }
}
