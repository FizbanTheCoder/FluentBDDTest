using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Atata;
using IFlow.Testing.Utils.Api.Accounts;
using IFlow.WebTests.Pages;
using IFlow.WebTests.Utils;
using TechTalk.SpecFlow;

namespace IFlow.WebTests.StepDefinitions
{
    [Binding]
    public sealed class RegistrationAndLoginSteps : BaseSteps
    {

        [Given(@"User without account want create new on registration page")]
        public void GivenUserWithoutAccountWantCreateNewOnRegistrationPage()
        {
            Go.To<MainPage>()
                .LoginToSystemClickable.ClickAndGo()
                .CreateAccountButton.ClickAndGo();
        }

        [When(@"Input all correct data and confirm")]
        public void WhenInputAllCorrectDataAndConfirm()
        {
            On<RegisterPage>().LoginTextInput.Set("UserLogin")
                .Report.Screenshot()
                .NameTextInput.Set("UserName")
                .EMailAddressTextInput.Set("leszek.zielinski@jcommerce.pl")
                .SurnameTextInput.Set("UserSurname")
                .PasswordTextInput.Set("SomeRandomPassword")
                .PhoneNumberTextInput.Set("501081616")
                .RepeatPasswordTextInput.Set("SomeRandomPassword")
                .CountrySelect.Set("Poland");
        }

        [Then(@"User se succed message and get conrfirmation email")]
        public void ThenUserSeSuccedMessageAndGetConrfirmationEmail()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"After corfimation user can log in")]
        public void ThenAfterCorfimationUserCanLogIn()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"User without accont want create newon registration page")]
        public void GivenUserWithoutAccontWantCreateNewonRegistrationPage()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"User put data in wrong format on registration page")]
        public void GivenUserPutDataInWrongFormatOnRegistrationPage()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"User cannot create new accout")]
        public void ThenUserCannotCreateNewAccout()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"User put incomplete data  on registration page")]
        public void GivenUserPutIncompleteDataOnRegistrationPage()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"User put complete data but don't mark checkboxes on registration")]
        public void GivenUserPutCompleteDataButDontMarkCheckboxesOnRegistration()
        {
            ScenarioContext.Current.Pending();
        }


        [Given(@"User have active account and is on login screen")]
        public void GivenUserHaveActiveAccountAndIsOnLoginScreen()
        {
            //Create accont by api
            Go.To<MainPage>().Report.Screenshot().LoginToSystemClickable.ClickAndGo()
                .LoginButton.IsVisible.Should.BeTrue();
        }

        [When(@"User input credentials on login page")]
        public void WhenUserInputCredentialsOnLoginPage()
        {
            On<LoginPage>().LoginTextInput.Set("lezi_test")
                .PassTextInput.Set("RR**^^$$5577tt")
                .LoginButton.ClickAndGo();
        }

        [Then(@"User is logged to account")]
        public void ThenUserIsLoggedToAccount()
        {
            On<HomePage>().HomePageText.IsVisible.Should.BeTrue();
        }



        [When(@"Registration by api")]
        public async Task WhenRegistrationByApi()
        {
            await Accounts.AccountsCreateAccount();
        }

    }
}
