using Atata;

namespace IFlow.Testing.Pages
{
    using _= RegisterPage;
    [Url("http://app-iflow-dev-001.azurewebsites.net/register")]
    [VerifyTitle("React app")]
    public class RegisterPage : BasePage<_>
    {
        [FindByXPath("//label/span[text()='Login *']//..//..//../input [@type='text']")]
        public TextInput<_> LoginTextInput{ get; set; }

        [FindByXPath("//label/span[text()='Name *']//..//..//../input [@type='text']")]
        public TextInput<_> NameTextInput { get; set; }

        [FindByXPath("//label/span[text()='E-mail address *']//..//..//../input [@type='text']")]
        public TextInput<_> EMailAddressTextInput { get; set; }

        [FindByXPath("//label/span[text()='Surname *']//..//..//../input [@type='text']")]
        public TextInput<_> SurnameTextInput { get; set; }

        [FindByXPath("//span[text()='Password *']//..//..//../input [@type='password']")]
        public PasswordInput<_> PasswordTextInput { get; set; }

        [FindByXPath("//label/span[text()='Phone number *']//..//..//../input [@type='text']")]
        public TextInput<_> PhoneNumberTextInput { get; set; }

        [FindByXPath("//span[text()='Repeat password *']//..//..//../input[@type='password']")]
        public PasswordInput<_> RepeatPasswordTextInput { get; set; }

        [FindByXPath("//label/span[text()='Country *']//..//..//../select")]
        public Select<_> CountrySelect { get; set; }

        [FindByXPath("//body/div[@id='root']/div[2]/div[1]/div[1]/div[2]/form[1]/div[6]/button[1]")]
        public Button<_> RegisterButton { get; set; }

        [FindByXPath(
            "//body/div[@id='root']/div[2]/div[1]/div[1]/div[2]/form[1]/div[5]/div[1]/div[1]/div[1]/div[1]/div[1]")]
        public Clickable<_> FirstCheckBox { get; set; }

        [FindByXPath(
            "//body/div[@id='root']/div[2]/div[1]/div[1]/div[2]/form[1]/div[5]/div[2]/div[1]/div[1]/div[1]/div[1]")]
        public Clickable<_> SecondCheckBox { get; set; }

        [FindByXPath("//span[contains(text(),'Your account has been registered successfully.')]")]
        public Text<_> ConfirmationMessage { get; set; }
    }

}
