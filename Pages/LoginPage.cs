using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using Atata;
using RazorEngine.Compilation.ImpromptuInterface;

namespace IFlow.Testing.Pages
{
    using _=LoginPage;
    public class LoginPage : BasePage<_>
    {
        [FindById("Email")] 
        public TextInput<_> LoginInput { get; set; }

        [FindById("Password")] 
        public TextInput<_> PasswordInput { get; set; }

        [FindByXPath("//a[contains(text(),'Register as a new user?')]")]
        public Link<RegisterPage,_> RagisterLink { get; set; }
    }
}
