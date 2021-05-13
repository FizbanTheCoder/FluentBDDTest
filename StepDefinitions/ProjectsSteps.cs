using Atata;
using IFlow.Testing.Pages;
using TechTalk.SpecFlow;
using IFlow.Testing.Utils.DataFactory;

namespace IFlow.Testing.StepDefinitions
{
    [Binding]
    public class ProjectsSteps : BaseSteps
    {
        [When(@"User submits form to create new project")]
        public void WhenUserSubmitsFormToCreateNewProject()
        {
            Go.To<CreateNewProjectPage>()
                //.SelectInvestment.Set(ScenarioContext.Get<string>(ScenarioContextDataKeys.InvestmentId))
                .SelectInvestment.Set("e5acda13-450b-4b92-8196-08d341a2031f")
                .NameInput.Set(SetProjectName())
                .CountrySelect.Set(SetProjectCountryCode())
                .DescriptionInput.Set(SetProjectDescription())
                .ProjectAddressInput.Set(SetProjectStreet())
                .ProjectTypeSelect.Set("residential")
                .ProjectAddress2Input.Set(GetProjectStreet())
                .ConstructionTypeSelect.Set("renovation")
                .CityInput.Set(SetProjectCity())
                .PostCodeInput.Set(SetProjectPostalCode())
                .ProjectValueInput.Set(SetProjectValue().ToString())
                .CurrencySelect.Set(SetProjectCurrency())
                .StateInput.Set(SetProjectProvince())
                //.ContractTypeSelect.Set(ScenarioContext.Get<string>(ScenarioContextDataKeys.ContractTypeId))
                .ContractTypeSelect.Set("d0c8ba58-44d0-40ff-b41a-60af7da6fb91")
                .TimeZoneSelect.Set("Europe/Warsaw")
                .StartDateInput.Click()
                .StartDateDatePicker.Click()
                .EndDateInput.Click()
                .EndDateDatePicker.Click()
                .LanguageSelect.Set(SetProjectLanguageCode())
                .ProjectNumberInput.Set(SetProjectNumber())
                //.BusinessUnitSelect.Set(ScenarioContext.Get<string>(ScenarioContextDataKeys.BusinessUnitId))
                .BusinessUnitSelect.Set("20430fb0-f682-4165-b88a-7231ff83d9eb")
                .CreateProjectButton.Click();
        }

        [Then(@"new project is created")]
        public void ThenNewProjectIsCreated()
        {
            On<CreateNewProjectPage>().SuccessfullMessage.Should.BeVisible();
        }
    }
}
