using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using Atata;
using RazorEngine.Compilation.ImpromptuInterface;

namespace IFlow.Testing.Pages
{
    using _= RegisterPage;
    public class RegisterPage : BasePage<_>
    {
        [FindById("User_Name")] public TextInput<_> UserNameInput { get; set; }

        [FindById("User_LastName")] public TextInput<_> UserLastNameInput { get; set; }

        [FindById("User_Street")] public TextInput<_> UserStreetInput { get; set; }

        [FindById("User_City")] public TextInput<_> UserCityInput { get; set; }

        [FindById("User_State")] public TextInput<_> UserStateInput { get; set; }

        [FindById("User_Country")] public TextInput<_> UserCountryInput { get; set; }

        [FindById("User_ZipCode")] public TextInput<_> UserZipCodeInput { get; set; }

        [FindById("User_PhoneNumber")] public TextInput<_> UserPhoneNumberInput { get; set; }

        [FindById("User_CardNumber")] public TextInput<_> UserCardNumberInput { get; set; }

        [FindById("User_CardHolderName")] public TextInput<_> UserCardHolderNameInput { get; set; }

        [FindById("User_Expiration")] public TextInput<_> UserExpirationInput { get; set; }

        [FindById("User_SecurityNumber")] public TextInput<_> UserSecurityNumberInput { get; set; }

        [FindById("Email")] public TextInput<_> EmailInput { get; set; }

        [FindById("Password")] public TextInput<_> PasswordInput { get; set; }

        [FindById("ConfirmPassword")] public TextInput<_> ConfirmPasswordInput { get; set; }

        [FindByXPath("//button[contains(text(),'Register')]")]
        public Button<LoginPage, _> RegisterButton { get; set; }




    }
}
