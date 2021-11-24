using Atata;
using System;
using System.Collections.Generic;
using System.Text;

namespace IFlow.Testing.Pages
{
    using _ = AlertPage;
    [Url("https://demoqa.com/alerts")]
    [VerifyTitle("ToolsQA")]
    public class AlertPage : BasePage<_>
    {
        [FindById("alertButton")]
        [CloseAlertBox]
        public Button<_> AlertButton { get; set; }

        [FindById("confirmButton")]
        [CloseConfirmBox]
        public Button<_> ConfirmButton { get; set; }

        [FindById("confirmButton")]
        [CloseConfirmBox]
        public Button<_> Cancel { get; set; }

    }
}
