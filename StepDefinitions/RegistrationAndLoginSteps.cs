using System.Threading.Tasks;
using Atata;
using Bogus.DataSets;
using IFlow.Testing.Pages;
using IFlow.Testing.Utils.Api.Accounts;
using IFlow.Testing.Utils.DataBase;
using IFlow.Testing.Utils.DataFactory;
using NUnit.Framework;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist.ValueRetrievers;
using FluentAssertions;

namespace IFlow.Testing.StepDefinitions
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



        [Given(@"User put complete data but don't mark checkboxes on registration")]
        public void GivenUserPutCompleteDataButDonTMarkCheckboxesOnRegistration()
        {
            var password = SetRandomUserPassword();
            Go.To<MainPage>()
                .LoginToSystemClickable.ClickAndGo()
                .CreateAccountButton.ClickAndGo().LoginTextInput.Set(SetRandomUserLogin())
                .NameTextInput.Set(SetRandomUserFirstName())
                .EMailAddressTextInput.Set(SetRandomUserEmail())
                .SurnameTextInput.Set(SetRandomUserLastName())
                .PasswordTextInput.Set(password)
                .PhoneNumberTextInput.Set(SetRandomUserPhoneNumber())
                .RepeatPasswordTextInput.Set(password)
                .CountrySelect.Set(SetRandomUserCountry());

        }




        [Given(@"User have active account and is on login screen")]
        public void GivenUserHaveActiveAccountAndIsOnLoginScreen()
        {
            Go.To<MainPage>().Report.Screenshot().LoginToSystemClickable.ClickAndGo()
                .LoginButton.IsVisible.Should.BeTrue();
        }

        [When(@"User input credentials on login page")]
        public void WhenUserInputCredentialsOnLoginPage()
        {
            Go.To<LoginPage>().LoginTextInput.Set(GetRandomUserLogin())
                .PassTextInput.Set(GetRandomUserPassword())
                .LoginButton.ClickAndGo();
        }

        [Then(@"User is logged to account")]
        public void ThenUserIsLoggedToAccount()
        {
            On<HomePage>().HomePageText.IsVisible.Should.BeTrue();
        }

        [When(@"User input all data on registration page")]
        public void WhenUserInputAllDataOnRegistrationPage()
        {
            var password = SetRandomUserPassword();
            Go.To<MainPage>()
                .LoginToSystemClickable.ClickAndGo()
                .CreateAccountButton.ClickAndGo().LoginTextInput.Set(SetRandomUserLogin())
                .NameTextInput.Set(SetRandomUserFirstName())
                .EMailAddressTextInput.Set(SetRandomUserEmail())
                .SurnameTextInput.Set(SetRandomUserLastName())
                .PasswordTextInput.Set(password)
                .PhoneNumberTextInput.Set(SetRandomUserPhoneNumber())
                .RepeatPasswordTextInput.Set(password)
                .CountrySelect.Set(SetRandomUserCountry())
                .FirstCheckBox.Click()
                .SecondCheckBox.Click();
        }

        [When(@"Confirm by click")]
        public void WhenConfirmByClick()
        {
            On<RegisterPage>().RegisterButton
                .Click();
        }

        [Then(@"User see confirmation message")]
        public void ThenUserSeeConfirmationMessage()
        {
            On<RegisterPage>().ConfirmationMessage.Should.BeVisible();
            User.UpdateEmailConformationForAccepted(GetRandomUserLogin());
        }

        [Then(@"After confirmation email message user can log in")]
        public void ThenAfterConfirmationEmailMessageUserCanLogIn()
        {
            Go.To<LoginPage>().LoginTextInput.Set(GetRandomUserLogin())
                .PassTextInput.Set(GetRandomUserPassword())
                .LoginButton.ClickAndGo().HomePageText.IsVisible.Should.BeTrue();
        }

        [When(@"user input incorrect data on login page")]
        public void WhenUserInputIncorrectDataOnLoginPage()
        {
            Go.To<LoginPage>().LoginTextInput.SetRandom()
                .PassTextInput.SetRandom()
                .LoginButton.Click();
        }

        [Then(@"user is not logged")]
        public void ThenUserIsNotLogged()
        {
            On<LoginPage>().LoginButton.Should.BeVisible();
        }

        [Then(@"error messages are displayed")]
        public void ThenErrorMessagesAreDisplayed()
        {
            On<LoginPage>().LoginInputLabel.Attributes["color"].Should.Equal("error")
            .PasswordInputLabel.Attributes["color"].Should.Equal("error");
        }

        [When(@"User don't input all data on registration page and confirm")]
        public void WhenUserDontInputAllDataOnRegistrationPageAndConfirm()
        {
            var password = SetRandomUserPassword();
            Go.To<MainPage>()
                .LoginToSystemClickable.ClickAndGo()
                .CreateAccountButton.ClickAndGo().LoginTextInput.Set(SetRandomUserLogin())
                .NameTextInput.Set(SetRandomUserFirstName())
                .EMailAddressTextInput.Set(SetRandomUserEmail())
                .SurnameTextInput.Set(SetRandomUserLastName())
                .PasswordTextInput.Set(password)
                .RepeatPasswordTextInput.Set(password)
                .CountrySelect.Set(SetRandomUserCountry())
                .FirstCheckBox.Click()
                .SecondCheckBox.Click()
                .RegisterButton.Click();
        }

        [Then(@"account is not created in database")]
        public void ThenAccountIsNotCreatedInDatabase()
        {
            User.UserIsExisting(GetRandomUserLogin()).Should().BeNull();
        }

    }
}
