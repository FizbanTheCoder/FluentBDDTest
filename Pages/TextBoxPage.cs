﻿using Atata;
using System;
using System.Collections.Generic;
using System.Text;

namespace IFlow.Testing.Pages
{
    using _ = TextBoxPage;
    [Url("https://demoqa.com/text-box")]
    [VerifyTitle("ToolsQA")]
    public class TextBoxPage : BasePage<_>
    {
        [FindById("userName")]
        public TextInput<_> UserNameTextBoxInput { get; set; }

        [FindById("userEmail")]
        public EmailInput<_> UserEmailTextBoxInput { get; set; }



        [FindById("currentAddress")]
        public TextArea<_> CurrentAddressTextBoxTextArea { get; set; }

        [FindById("permanentAddress")]
        public TextArea<_> PermanentAddressTextBoxTextArea { get; set; }

        [FindById("submit")]
        public Button<_> SubmitTextBoxButton { get; set; }
       
        [FindById("output")]
        public Text<_> TextBoxOutputBox { get; set; }

        [FindById("name")]
        public Text<_> TextBoxOutputName { get; set; }

        [FindById("email")]
        public Text<_> TextBoxOutputEmail { get; set; }

        [FindById("currentAddress")]
       // [ValueGetFromValue]
        public Text<_> TextBoxOutputCurrentAddress { get; set; }


        [FindByXPath("output")]
        public Text<_> OutputBox { get; set; }

        [FindById("permanentAddress")]
        public Text<_> TextBoxOutputPermanentAddress { get; set; }
    }
}