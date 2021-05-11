using Atata;

namespace IFlow.Testing.Pages
{
    using _ = AddProjectPage;
    [Url("http://app-iflow-dev-001.azurewebsites.net/project/add")]
    [VerifyTitle("React app")]
    public class AddProjectPage : BasePage<_>
    {
        [FindByXPath("//form/div/div[2]/div/select")]
        public Select<_> SelectContryList { get; set; }

        [FindByXPath("//form/div/div[1]/div")]
        public TextInput<_> ProjectNameField { get; set; }
    }
}