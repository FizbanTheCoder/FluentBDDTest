using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using Atata;
using static Atata.TriggerEvents;

namespace IFlow.WebTests.Pages
{
    using _=HomePage;
    [Url("http://app-iflow-dev-001.azurewebsites.net/")]
    [VerifyTitle("React app")]
    public class HomePage : BasePage<_>
    {
        [FindByXPath("//div[contains(text(),'Homepage')]")]
        public Text<_> HomePageText { get; set; }
    }
}
