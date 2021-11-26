﻿using Atata;
using FluentAssertions;
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
        private AlertPage alertPage;

        [When(@"User click submit button and alert appears")]
        public void UserClickSubmitButtonAndAlertAppears()
        {
            alertPage = Go.To<AlertPage>()
                .AlertButton.Click();
        }

        [Then(@"Alert message is displayed")]
        public void AlertMessageIsDisplayed()
        {
            alertPage.GetAlertMessage().Equals("You clicked a button").Should().BeTrue();
        }

        [Then(@"user confirms it with button")]
        public void UserConfirmsItWithButton()
        {
            alertPage.AcceptAlert();
        }

        [When(@"User click submit button and confirms alert that appears")]
        public void UserClickSubmitButtonAndConfirmsAlertThatAppears()
        {
            alertPage = Go.To<AlertPage>()
                .Cancel.Click();
            alertPage.AcceptAlert();
        }

        [Then(@"Correct message appears on page")]
        public void CorrectMessageAppearsOnPage()
        {
            alertPage.ResultText.Value.Equals("You selected Ok").Should().BeTrue();
        }
    }
}