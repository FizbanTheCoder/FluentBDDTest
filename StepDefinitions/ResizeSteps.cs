using Atata;
using IFlow.Testing.Pages;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace IFlow.Testing.StepDefinitions
{
    [Binding]
    public sealed class ResizeSteps : BaseSteps
    {
        [When(@"User resizes a window")]
        public void DeleteUsingJSConfirm()
        {

            Go.To<ResizePage>()
                .ResizeButton.DragAndDropToOffset(20,30);


        }

    }
}
