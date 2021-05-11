using Atata;
using Bogus.DataSets;
using IFlow.Testing.Utils.DataBase;
using IFlow.Testing.Utils.DataFactory;
using TechTalk.SpecFlow;

namespace IFlow.Testing.StepDefinitions
{
    [Binding]
    public abstract class BaseSteps : Steps
    {
        protected TPageObject On<TPageObject>()
            where TPageObject : PageObject<TPageObject>
        {
            return (AtataContext.Current.PageObject as TPageObject)
                   ?? Go.To<TPageObject>(navigate: false);
        }

        protected string SetRandomUserLogin()
        {
            var userLogin = UserData.RegistrationUserName;
            ScenarioContext.Add(ScenarioContextDataKeys.UserName, userLogin);
            return userLogin;
        }

        protected string GetRandomUserLogin()
        {
            return ScenarioContext.Get<string>(ScenarioContextDataKeys.UserName);
        }

        protected string SetRandomUserPassword()
        {
            var password = new Internet().Password(12, 20);
            ScenarioContext.Add(ScenarioContextDataKeys.Password, password);
            return password;
        }

        protected string GetRandomUserPassword()
        {
            return ScenarioContext.Get<string>(ScenarioContextDataKeys.Password);
        }

        protected string SetRandomUserFirstName()
        {
            var userFirstName = UserData.FirsName;
            ScenarioContext.Add(ScenarioContextDataKeys.FirstName, userFirstName);
            return userFirstName;
        }

        protected string GetRandomUserFirstName()
        {
            return ScenarioContext.Get<string>(ScenarioContextDataKeys.FirstName);
        }

        protected string SetRandomUserEmail()
        {
            var randomUserEmail = UserData.Email;
            ScenarioContext.Add(ScenarioContextDataKeys.Email, randomUserEmail);
            return randomUserEmail;
        }

        protected string GetRandomUserEmail()
        {
            return ScenarioContext.Get<string>(ScenarioContextDataKeys.Email);
        }

        protected string SetRandomUserLastName()
        {
            var userLastName = UserData.LastName;
            ScenarioContext.Add(ScenarioContextDataKeys.LastName, userLastName);
            return userLastName;
        }

        protected string GetRandomUserLastName()
        {
            return ScenarioContext.Get<string>(ScenarioContextDataKeys.LastName);
        }

        protected string SetRandomUserPhoneNumber()
        {
            var userPhoneNumber = UserData.PhoneNumber;
            ScenarioContext.Add(ScenarioContextDataKeys.PhoneNumber, userPhoneNumber);
            return userPhoneNumber;
        }

        protected string GetRandomUserPhoneNumber()
        {
            return ScenarioContext.Get<string>(ScenarioContextDataKeys.PhoneNumber);
        }

        protected string SetRandomUserCountry()
        {
            var userCountry = UserData.Country;
            ScenarioContext.Add(ScenarioContextDataKeys.Country, userCountry);
            return userCountry;
        }

        protected string GetRandomUserCountry()
        {
            return ScenarioContext.Get<string>(ScenarioContextDataKeys.PhoneNumber);
        }


        protected string SetRandomCompanyName()
        {
            var companyName = CompanyData.Name;
            ScenarioContext.Add(ScenarioContextDataKeys.CompanyName, companyName);
            return companyName;

        }

        protected string GetRandomCompanyName()
        {
            return ScenarioContext.Get<string>(ScenarioContextDataKeys.CompanyName);
        }

        protected string SetRandomCompanyEmail()
        {
            var companyEmail = CompanyData.Email;
            ScenarioContext.Add(ScenarioContextDataKeys.CompanyEmail, companyEmail);
            return companyEmail;
        }

        protected string GetCompanyEmail()
        {
            return ScenarioContext.Get<string>(ScenarioContextDataKeys.CompanyEmail);
        }

        protected string SetCompanyPhoneNumber()
        {
            var companyPhoneNumber = CompanyData.PhoneNumber;
            ScenarioContext.Add(ScenarioContextDataKeys.CompanyPhoneNumber, companyPhoneNumber);
            return companyPhoneNumber;
        }

        protected string GetCompanyPhoneNumber()
        {
            return ScenarioContext.Get<string>(ScenarioContextDataKeys.CompanyPhoneNumber);
        }

        protected string SetCompanyCountry()
        {
            var companyCountry = CompanyData.Country;
            ScenarioContext.Add(ScenarioContextDataKeys.CompanyCountry, companyCountry);
            return companyCountry;
        }

        protected string GetCompanyCountry()
        {
            return ScenarioContext.Get<string>(ScenarioContextDataKeys.CompanyCountry);
        }

        protected string SetCompanyCity()
        {
            var companyCity = CompanyData.City;
            ScenarioContext.Add(ScenarioContextDataKeys.CompanyCity, companyCity);
            return companyCity;
        }

        protected string GetCompanyCity()
        {
            return ScenarioContext.Get<string>(ScenarioContextDataKeys.CompanyCity);
        }

        protected string SetCompanyPostalCode()
        {
            var companyPostalCode = CompanyData.PostalCode;
            ScenarioContext.Add(ScenarioContextDataKeys.CompanyPostalCode, companyPostalCode);
            return companyPostalCode;
        }

        protected string GetCompanyPostalCode()
        {
            return ScenarioContext.Get<string>(ScenarioContextDataKeys.CompanyPostalCode);
        }

        protected string SetCompanyProvince()
        {
            var companyProvince = CompanyData.Province;
            ScenarioContext.Add(ScenarioContextDataKeys.CompanyProvince, companyProvince);
            return companyProvince;
        }

        protected string GetCompanyProvince()
        {
            return ScenarioContext.Get<string>(ScenarioContextDataKeys.CompanyProvince);
        }

        protected string SetCompanyStreet()
        {
            var companyStreet = CompanyData.Street;
            ScenarioContext.Add(ScenarioContextDataKeys.CompanyStreet, companyStreet);
            return companyStreet;
        }

        protected string GetCompanyStreet()
        {
            return ScenarioContext.Get<string>(ScenarioContextDataKeys.CompanyStreet);
        }

        protected string SetCompanyInvestment()
        {
            var companyInvestment = InvestmentData.Name;
            ScenarioContext.Add(ScenarioContextDataKeys.InvestmentName, companyInvestment);
            return companyInvestment;

        }
        protected string GetCompanyInvestment()
        {
            return ScenarioContext.Get<string>(ScenarioContextDataKeys.InvestmentName);
        }
    }
}
