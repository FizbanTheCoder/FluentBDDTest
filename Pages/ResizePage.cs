using Atata;

namespace IFlow.Testing.Pages
{
    using _ = ResizePage;
    [Url("https://demoqa.com/resizable")]
    [VerifyTitle("ToolsQA")]
    public class ResizePage : BasePage<_>
    {
        [FindByXPath("//*[@id='resizableBoxWithRestriction']/span")]
        public Clickable<_> ResizeHandle { get; set; }

        [FindById("resizableBoxWithRestriction")]
        public Text<_> CommentBox { get; set; }

        public int GetBoxSize()
        {
            return CommentBox.ComponentSize.Width.Value;
        }
    }
}
