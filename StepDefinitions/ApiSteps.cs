using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using IFlow.Testing.Api;
using IFlow.Testing.Utils.Api.Auth;
using IFlow.WebTests.StepDefinitions;
using TechTalk.SpecFlow;

namespace IFlow.Testing.StepDefinitions
{
    [Binding]
    class ApiSteps : BaseSteps
    {
        [When(@"User send correct data to log in")]
        public async Task WhenUserSendCorrectDataToLogIn()
        {
            var token = await AuthRequests.AuthLoginGetToken();
         
        }

  
    }
}
