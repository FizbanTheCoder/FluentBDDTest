using Atata;

namespace IFlow.Testing.Pages
{    
    //TODO: Delete

    using _ = MainPage;
    [Url("http://app-iflow-dev-001.azurewebsites.net/")]
    [VerifyTitle("IFLOW")]
    public class MainPage : BasePage<_>
    {
        [FindByXPath("//span[contains(text(),'Login to system')]")]
        public Clickable<LoginPage,_> LoginToSystemClickable { get; set; }


    }
}
