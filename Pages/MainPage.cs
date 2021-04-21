using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using Atata;
using static Atata.TriggerEvents;
namespace IFlow.WebTests.Pages
{
    using _ = MainPage;
    [Url("http://app-iflow-dev-001.azurewebsites.net/")]
    [VerifyTitle("React app")]
    [Screenshot(AfterAnyAction)]
    public class MainPage : BasePage<_>
    {
        [FindByXPath("//span[contains(text(),'Login to system')]")]
        public Clickable<LoginPage,_> LoginToSystemClickable { get; set; }


    }
}
