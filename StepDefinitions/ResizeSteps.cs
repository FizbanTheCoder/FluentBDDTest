using Atata;
using FluentAssertions;
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
        private int[] orgMesures;
        private int[] newMesures;
        private const int resizeA = 40;
        private const int resizeB = 50;

        [When(@"User makes a box bigger by dragging handle")]
        public void WhenUserMakesBoxBiggerByDraggingHandle()
        {
            var page = Go.To<ResizePage>();
            orgMesures = page.GetElementSize(page.CommentBox);
            page.ResizeHandle.DragAndDropToOffset(resizeA, resizeB);
        }

        [Then(@"the box has bigger size")]
        public void ThenTheBoxHasBiggerSize()
        {
            var page = On<ResizePage>();
            newMesures = page.GetElementSize(page.CommentBox);
            newMesures[0].Equals(orgMesures[0] + resizeA).Should().BeTrue();
            newMesures[1].Equals(orgMesures[1] + resizeB).Should().BeTrue();
        }
    }
}
