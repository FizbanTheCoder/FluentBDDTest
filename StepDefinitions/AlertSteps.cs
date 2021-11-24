using Atata;
using IFlow.Testing.Pages;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using static IFlow.Testing.Pages.AlertPage;

namespace IFlow.Testing.StepDefinitions
{
    [Binding]
    public sealed class AlertSteps : BaseSteps
    {
        [When(@"User click submit button alert appears")]
        public void DeleteUsingJSConfirm()
        {
            Go.To<AlertPage>()
                .AlertButton.Click();
        }

        [When(@"User click submit button and confirms alert that appears")]
        public void ConfirmUsingJSConfirm()
        {
            Go.To<AlertPage>()
                .Cancel.Click();
        }
    }
}
