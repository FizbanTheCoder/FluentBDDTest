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
        private UIComponentSizeProvider<_> sth;

        [When(@"User makes a box bigger by dragging handle")]
        public void WhenUserMakesBoxBiggerByDraggingHandle()
        {
            var size = Go.To<ResizePage>();
            var sth = size.GetBoxSize();
            size.ResizeHandle.DragAndDropToOffset(20, 20);
        }

        [Then(@"the box has bigger size")]
        public void ThenTheBoxHasBiggerSize()
        {
            On<ResizePage>()
                .GetBoxSize();
        }
    }
}
