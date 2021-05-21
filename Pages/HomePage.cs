using Atata;

namespace IFlow.Testing.Pages
{
    using _=HomePage;
    [Url("http://host.docker.internal:5105/Account/Login")]
    [VerifyTitle("Catalog - Microsoft.eShopOnContainers.WebMVC")]
    public class HomePage : BasePage<_>
    {
        [FindByClass("esh-identity-name esh-identity-name--upper")]
        public Link<LoginPage, _> LoginLink { get; set; }
    }
}
