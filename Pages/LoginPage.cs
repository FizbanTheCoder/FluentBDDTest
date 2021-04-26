using Atata;

namespace IFlow.Testing.Pages
{
    using _=LoginPage;
    [Url("http://app-iflow-dev-001.azurewebsites.net/login")]
    [VerifyTitle("React app")]
    public class LoginPage : BasePage<_>
    {
        [FindByXPath("//a[@href='/register']/button[@type='submit']")]
        public Button<RegisterPage, _> CreateAccountButton { get; set; }

        [FindByXPath("//span[text()='Login *']/..//../..//input[@type='text']")]
        public TextInput<_> LoginTextInput { get; set; }

        [FindByXPath("//input[@type='password']")]
        public PasswordInput<_> PassTextInput { get; set; }

       [FindByXPath("//button[@type='submit']")]
       public Button<HomePage,_> LoginButton { get; set; }



    }
}
