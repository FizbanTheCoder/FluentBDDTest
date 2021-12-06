using Atata;
using FluentAssertions;
using IFlow.Testing.Pages;
using TechTalk.SpecFlow;

namespace IFlow.Testing.StepDefinitions
{
    [Binding]
    public sealed class ResizeSteps : BaseSteps
    {
        private int[] orgMesures;
        private int[] newMesures;
        private int sizeA;
        private int sizeB;

        [When(@"User increases the box by '(.*)' and '(.*)' pixels dragging handle")]
        public void WhenUserMakesBoxBiggerByDraggingHandle(int SizeA, int SizeB)
        {
            sizeA = SizeA;
            sizeB = SizeB;
            var page = Go.To<ResizePage>();
            orgMesures = page.GetElementSize(page.CommentBox);
            page.ResizeHandle.DragAndDropToOffset(sizeA, sizeB);
        }

        [Then(@"the box has bigger size")]
        public void ThenTheBoxHasBiggerSize()
        {
            var page = On<ResizePage>();
            newMesures = page.GetElementSize(page.CommentBox);
            newMesures[0].Equals(orgMesures[0] + sizeA).Should().BeTrue();
            newMesures[1].Equals(orgMesures[1] + sizeB).Should().BeTrue();
        }
    }
}
