using Atata;
using IFlow.Testing.Pages;
using IFlow.Testing.Utils.DataBase;
using IFlow.Testing.Utils.DataFactory;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace IFlow.Testing.StepDefinitions
{
    [Binding]
    public sealed class TextBoxSteps : BaseSteps
    {
        private string userName;
        private string userLastName;
        private string userEmail;
        private string userCountry;

        [Before]
        [Obsolete("Visual Studio IntelliSense Work Around", true)]
        public void GenerateUserData()
        {
            userName = SetRandomUserFirstName();
            userLastName = SetRandomUserLastName();
            userEmail = SetRandomUserEmail();
            userCountry = SetRandomUserCountry();
        }

        [When(@"User input all personal data on address form page")]
        public void WhenUserInputAllPersonalDataOnAddressFormPage()
        {
            Go.To<TextBoxPage>()
                .UserNameTextBoxInput.Set(userName + " " + userLastName)
                .UserEmailTextBoxInput.Set(userEmail)
                .CurrentAddressTextBoxTextArea.Click()
                .CurrentAddressTextBoxTextArea.Set(userCountry)
                .PermanentAddressTextBoxTextArea.Set(userCountry);
        }

        [When(@"confirm the data by clicking button")]
        public void WhenConfirmTheDataByClickingButton()
        {
            Go.To<TextBoxPage>()
                .SubmitTextBoxButton.Click();
        }


        [Then(@"user should see provided data below")]
        public void ThenUserShouldSeeProvidedDataBelow()
        {
            On<TextBoxPage>()
                .TextBoxOutputBox.Should.BeVisible()
                .TextBoxOutputName.Content.Should.Contain($"Name:{userName} {userLastName}")
                .TextBoxOutputEmail.Content.Should.Contain($"Email:{userEmail}")
                .TextBoxOutputCurrentAddress.IsVisible.Should.BeTrue()
                .TextBoxOutputCurrentAddress.GetContent(ContentSource.Value).Should.Contain(userCountry)
                .TextBoxOutputPermanentAddress.GetContent(ContentSource.Value).Should.Contain(userCountry);
        }
    }
}
