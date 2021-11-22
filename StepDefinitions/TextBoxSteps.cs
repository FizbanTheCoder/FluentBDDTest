using Atata;
using IFlow.Testing.Pages;
using System;
using TechTalk.SpecFlow;

namespace IFlow.Testing.StepDefinitions
{
    [Binding]
    public sealed class TextBoxSteps : BaseSteps
    {
        private readonly ScenarioContext _scenarioContext;

        [Obsolete("Visual Studio IntelliSense Work Around", true)]
        public TextBoxSteps(ScenarioContext scenarioContext)
        {
           _scenarioContext = scenarioContext;
           SetRandomUser(_scenarioContext);
        }

        [When(@"User input all personal data on address form page")]
        public void WhenUserInputAllPersonalDataOnAddressFormPage()
        {
            Go.To<TextBoxPage>()
                .UserNameTextBoxInput.Set(User.FirstName + " " + User.LastName)
                .UserEmailTextBoxInput.Set(User.Email)
                .CurrentAddressTextBoxTextArea.Click()
                .CurrentAddressTextBoxTextArea.Set(User.Country)
                .PermanentAddressTextBoxTextArea.Set(User.Country);
        }

        [When(@"confirm the data by clicking button")]
        public void WhenConfirmTheDataByClickingButton()
        {
            On<TextBoxPage>()
                .SubmitTextBoxButton.Click();
        }

        [Then(@"user should see provided data below")]
        public void ThenUserShouldSeeProvidedDataBelow()
        {
            On<TextBoxPage>()
                .TextBoxOutputBox.Should.BeVisible()
                .TextBoxOutputName.Content.Should.Contain($"Name:{User.FirstName} {User.LastName}")
                .TextBoxOutputEmail.Content.Should.Contain($"Email:{User.Email}")
                .TextBoxOutputCurrentAddress.IsVisible.Should.BeTrue()
                .TextBoxOutputCurrentAddress.GetContent(ContentSource.Value).Should.Contain(User.Country)
                .TextBoxOutputPermanentAddress.GetContent(ContentSource.Value).Should.Contain(User.Country);
        }
    }
}
