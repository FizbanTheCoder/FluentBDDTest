using Atata;

namespace IFlow.Testing.Pages
{
    using _ = MainPage;
    [Url("http://app-iflow-dev-001.azurewebsites.net/")]
    [VerifyTitle("React app")]
    public class MainPage : BasePage<_>
    {
        [FindByXPath("//span[contains(text(),'Login to system')]")]
        public Clickable<LoginPage,_> LoginToSystemClickable { get; set; }


    }
}
