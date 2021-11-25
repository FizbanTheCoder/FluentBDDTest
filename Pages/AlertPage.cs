using Atata;

namespace IFlow.Testing.Pages
{
    using _ = AlertPage;
    [Url("https://demoqa.com/alerts")]
    [VerifyTitle("ToolsQA")]
    public class AlertPage : BasePage<_>
    {
        [FindById("alertButton")]
        public Button<_> AlertButton { get; set; }

        [FindById("confirmResult")]
        public Text<_> ResultText { get; set; }

        [FindById("confirmButton")]
        public Button<_> Cancel { get; set; }

        public void DissmisAlert()
        {
            AtataContext.Current.Driver.SwitchTo().Alert().Dismiss();
        }

        public void AcceptAlert()
        {
            AtataContext.Current.Driver.SwitchTo().Alert().Accept();
        }
        public string GetAlertMessage()
        {
            return AtataContext.Current.Driver.SwitchTo().Alert().Text;
        }
    }
}
