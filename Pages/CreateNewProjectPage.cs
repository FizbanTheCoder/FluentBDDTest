using Atata;

namespace IFlow.Testing.Pages
{
    using _ = CreateNewProjectPage;
    [Url("http://app-iflow-dev-001.azurewebsites.net/project/add")]
    [VerifyTitle("IFLOW")]
    public class CreateNewProjectPage : BasePage<_>
    {
        [FindByAttribute("data-test-id", "add-new-project-button")]
        public Button<_> CreateProjectButton { get; set; }

        [FindByXPath("//span[text()='Your project has been added successfully.']")]
        public Text<_> SuccessfullMessage { get; set; }
        
        [FindByAttribute("data-test-id", "investmentId-selector")]
        [SelectByValue]
        public Select<_> SelectInvestment { get; set; }

        [FindByAttribute("data-test-id", "name-input")]
        public TextInput<_> NameInput { get; set; }

        [FindByAttribute("data-test-id", "country-selector")]
        [SelectByValue]
        public Select<_> CountrySelect { get; set; }

        [FindByAttribute("data-test-id", "description-input")]
        public TextInput<_> DescriptionInput { get; set; }

        [FindByAttribute("data-test-id", "address-input")]
        public TextInput<_> ProjectAddressInput { get; set; }

        [FindByAttribute("data-test-id", "projectType-selector")]
        [SelectByValue]
        public Select<_> ProjectTypeSelect { get; set; }

        [FindByAttribute("data-test-id", "address2-input")]
        public TextInput<_> ProjectAddress2Input { get; set; }

        [FindByAttribute("data-test-id", "constructionType-selector")]
        [SelectByValue]
        public Select<_> ConstructionTypeSelect { get; set; }

        [FindByAttribute("data-test-id", "city-input")]
        public TextInput<_> CityInput { get; set; }

        [FindByAttribute("data-test-id", "postalCode-input")]
        public TextInput<_> PostCodeInput { get; set; }

        [FindByAttribute("data-test-id", "projectValue-input")]
        public TextInput<_> ProjectValueInput { get; set; }

        [FindByAttribute("data-test-id", "currency-selector")]
        public Select<_> CurrencySelect { get; set; }

        [FindByAttribute("data-test-id", "state-input")]
        public TextInput<_> StateInput { get; set; }

        [FindByAttribute("data-test-id", "contractType-selector")]
        [SelectByValue]
        public Select<_> ContractTypeSelect { get; set; }

        [FindByAttribute("data-test-id", "timezone-selector")]
        [SelectByValue]
        public Select<_> TimeZoneSelect { get; set; }

        [FindByAttribute("data-testid", "startDate-input")]
        public TextInput<_> StartDateInput { get; set; }

        [FindByXPath("//input[@data-testid='startDate-input']/../div/div/div/div[contains(concat(' ',normalize-space(@class),' '),'qs-num')][1]")]
        public Text<_> StartDateDatePicker { get; set; }

        [FindByAttribute("data-testid", "endDate-input")]
        public TextInput<_> EndDateInput { get; set; }

        [FindByXPath("//input[@data-testid='endDate-input']/../div/div/div/div[contains(concat(' ',normalize-space(@class),' '),'qs-num')][last()]")]
        public Text<_> EndDateDatePicker { get; set; }

        [FindByAttribute("data-test-id", "language-selector")]
        [SelectByValue(TermCase.Lower)]
        public Select<_> LanguageSelect { get; set; }

        [FindByAttribute("data-test-id", "projectNumber-input")]
        public TextInput<_> ProjectNumberInput { get; set; }

        [FindByAttribute("data-test-id", "businessUnit-selector")]
        [SelectByValue]
        public Select<_> BusinessUnitSelect { get; set; }
    }
}
