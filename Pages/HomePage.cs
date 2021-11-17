using Atata;

namespace IFlow.Testing.Pages
{
    using _=HomePage;
    [Url("http://app-iflow-dev-001.azurewebsites.net/")]
    [VerifyTitle("IFLOW")]
    public class HomePage : BasePage<_>
    {
        [FindByXPath("//div[contains(text(),'Homepage')]")]
        public Text<_> HomePageText { get; set; }
    }
}
