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



    }
}
