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
using IFlow.Testing.Utils.DataBase;
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

            var token = await AuthRequests.AuthLoginGetToken(GetRandomUserLogin(), GetRandomUserPassword());
                        var handler = new JwtSecurityTokenHandler();
            var encodedJwtToken = handler.ReadJwtToken(token);
            var sud = encodedJwtToken.Claims.First(claim => claim.Type == "sub").Value;

            ScenarioContext.Add(ScenarioContextDataKeys.UserToken, token);
        }

        [When(@"Registration by api"),
        Given(@"Registration by api")]
        public async Task WhenRegistrationByApi()
        {

            await Accounts.AccountsCreateAccount(SetRandomUserLogin(), SetRandomUserFirstName(), SetRandomUserLastName(), SetRandomUserEmail(), SetRandomUserPassword(), SetRandomUserCountry(), SetRandomUserPhoneNumber());
        }

        [When(@"I create organization for my user")]
        public async Task WhenICreateOrganizationForMyUser()
        {
            var userToken = ScenarioContext.Get<string>(ScenarioContextDataKeys.UserToken);
            await Organizations.CreateOrganizationForUser(userToken);
        }



        [When(@"Accept registration by emain")]
        public void WhenAcceptRegistrationByEmain()
        {
            User.UpdateEmailConformationForAccepted(GetRandomUserLogin());
        }
    }
}
