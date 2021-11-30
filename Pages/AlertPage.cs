using Atata;

namespace IFlow.Testing.Pages
{
    using _ = AlertPage;
    [Url("/alerts")]
    [VerifyTitle("ToolsQA")]
    public class AlertPage : BasePage<_>
    {
        [FindById("alertButton")]
        public Button<_> AlertButton { get; set; }

        [FindById("confirmResult")]
        public Text<_> ResultText { get; set; }

        [FindById("confirmButton")]
        public Button<_> Cancel { get; set; }
    }
}
