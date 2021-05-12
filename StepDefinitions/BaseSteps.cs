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

        protected string SetProjectName()
        {
            var projectName = ProjectData.ProjectName;
            ScenarioContext.Add(ScenarioContextDataKeys.ProjectName, projectName);
            return projectName;
        }
        protected string GetProjectName()
        {
            return ScenarioContext.Get<string>(ScenarioContextDataKeys.ProjectName);
        }
        protected string SetProjectStreet()
        {
            var projectStreet = ProjectData.ProjectStreet;
            ScenarioContext.Add(ScenarioContextDataKeys.ProjectStreet, projectStreet);
            return projectStreet;
        }
        protected string GetProjectStreet()
        {
            return ScenarioContext.Get<string>(ScenarioContextDataKeys.ProjectStreet);
        }
        protected string SetProjectCountry()
        {
            var projectCountry = ProjectData.ProjectCountry;
            ScenarioContext.Add(ScenarioContextDataKeys.ProjectCountry, projectCountry);
            return projectCountry;
        }
        protected string GetProjectCountry()
        {
            return ScenarioContext.Get<string>(ScenarioContextDataKeys.ProjectCountry);
        }
        protected string SetProjectCity()
        {
            var projectCity = ProjectData.ProjectCity;
            ScenarioContext.Add(ScenarioContextDataKeys.ProjectCity, projectCity);
            return projectCity;
        }
        protected string GetProjectCity()
        {
            return ScenarioContext.Get<string>(ScenarioContextDataKeys.ProjectCity);
        }
        protected string SetProjectDescription()
        {
            var projectDescription = ProjectData.ProjectDescription;
            ScenarioContext.Add(ScenarioContextDataKeys.ProjectDescription, projectDescription);
            return projectDescription;
        }
        protected string GetProjectDescription()
        {
            return ScenarioContext.Get<string>(ScenarioContextDataKeys.ProjectDescription);
        }
        protected string SetProjectPostalCode()
        {
            var projectPostalCode = ProjectData.ProjectPostalCode;
            ScenarioContext.Add(ScenarioContextDataKeys.ProjectPostalCode, projectPostalCode);
            return projectPostalCode;
        }
        protected string GetProjectPostalCode()
        {
            return ScenarioContext.Get<string>(ScenarioContextDataKeys.ProjectPostalCode);
        }
        protected string SetProjectProvince()
        {
            var projectProvince = ProjectData.ProjectProvince;
            ScenarioContext.Add(ScenarioContextDataKeys.ProjectProvince, projectProvince);
            return projectProvince;
        }
        protected string GetProjectProvince()
        {
            return ScenarioContext.Get<string>(ScenarioContextDataKeys.ProjectDescription);
        }
        protected int SetProjectValue()
        {
            var projectValue = ProjectData.ProjectValue;
            ScenarioContext.Add(ScenarioContextDataKeys.ProjectValue, projectValue);
            return projectValue;
        }
        protected int GetProjectValue()
        {
            return ScenarioContext.Get<int>(ScenarioContextDataKeys.ProjectValue);
        }
        protected string SetProjectCurrency()
        {
            var projectCurrency = ProjectData.ProjectCurrency;
            ScenarioContext.Add(ScenarioContextDataKeys.ProjectCurrency, projectCurrency);
            return projectCurrency;
        }
        protected int GetProjectCurrency()
        {
            return ScenarioContext.Get<int>(ScenarioContextDataKeys.ProjectCurrency);
        }
        protected string SetProjectType()
        {
            var projectType = ProjectData.ProjectType;
            ScenarioContext.Add(ScenarioContextDataKeys.ProjectType, projectType);
            return projectType;
        }
        protected int GetProjectType()
        {
            return ScenarioContext.Get<int>(ScenarioContextDataKeys.ProjectType);
        }
        protected string SetProjectConstructionType()
        {
            var projectConstructionType = ProjectData.ProjectConstructionType;
            ScenarioContext.Add(ScenarioContextDataKeys.ProjectConstructionType, projectConstructionType);
            return projectConstructionType;
        }
        protected int GetProjectConstructionType()
        {
            return ScenarioContext.Get<int>(ScenarioContextDataKeys.ProjectConstructionType);
        }
        protected string SetProjectNumber()
        {
            var projectNumber = ProjectData.ProjectNumber;
            ScenarioContext.Add(ScenarioContextDataKeys.ProjectNumber, projectNumber);
            return projectNumber;
        }
        protected int GetProjectNumber()
        {
            return ScenarioContext.Get<int>(ScenarioContextDataKeys.ProjectNumber);
        }

        protected string SetProjectTimeZone()
        {
            var projectTimeZone = ProjectData.ProjectTimeZone;
            ScenarioContext.Add(ScenarioContextDataKeys.ProjectTimeZone, projectTimeZone);
            return projectTimeZone;
        }
        protected int GetProjectTimeZone()
        {
            return ScenarioContext.Get<int>(ScenarioContextDataKeys.ProjectTimeZone);
        }
        protected string SetProjectLanguage()
        {
            var projectLanguage = ProjectData.ProjectLanguage;
            ScenarioContext.Add(ScenarioContextDataKeys.ProjectLanguage, projectLanguage);
            return projectLanguage;
        }
        protected int GetProjectLanguage()
        {
            return ScenarioContext.Get<int>(ScenarioContextDataKeys.ProjectLanguage);
        }

    }
}
