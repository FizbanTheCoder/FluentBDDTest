using Atata;
using System;
using System.Collections.Generic;
using System.Text;

namespace IFlow.Testing.Pages
{
    using _ = ResizePage;
    [Url("https://demoqa.com/resizable")]
    [VerifyTitle("ToolsQA")]
    public class ResizePage : BasePage<_>
    {
        [FindByXPath("//*[@id='resizableBoxWithRestriction']/span")]
        public <_> ResizeButton { get; set; }

        [FindById("resizableBoxWithRestriction")]
        public Button<_> ResizableBox { get; set; }


    }
}
