using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Threading.Tasks;
using Atata;
using Bogus.DataSets;
using FluentAssertions;
using HtmlAgilityPack;
using IFlow.Testing.Utils.Api.Accounts;
using IFlow.Testing.Utils.Api.Auth;
using IFlow.Testing.Utils.Api.MailHog;
using IFlow.Testing.Utils.Api.Organizations;
using IFlow.Testing.Utils.DataBase;
using IFlow.Testing.Utils.DataFactory;
using TechTalk.SpecFlow;
using IFlow.Testing.Utils.Api.BusinessUnit;
using IFlow.Testing.Utils.Api.ContractType;
using IFlow.Testing.Utils.Api.Investments;
using IFlow.Testing.Utils.Api.Projects;
using IFlow.Testing.Utils.Api.ProjectStage;
using FluentAssertions;


namespace IFlow.Testing.StepDefinitions
{
    [Binding]
    class ApiSteps : BaseSteps
    {
        [When(@"User send correct data to log in")]
        public async Task WhenUserSendCorrectDataToLogIn()
        {
            await Accounts.AccountsCreateAccount(SetRandomUserLogin(), SetRandomUserFirstName(), SetRandomUserLastName(), SetRandomUserEmail(), SetRandomUserPassword(), SetRandomUserCountry(), SetRandomUserPhoneNumber());
            User.UpdateEmailConformationForAccepted(GetRandomUserLogin());
            var token = await AuthRequests.AuthLoginGetToken(GetRandomUserLogin(), GetRandomUserPassword());
                        var handler = new JwtSecurityTokenHandler();
            var encodedJwtToken = handler.ReadJwtToken(token);
            var sud = encodedJwtToken.Claims.First(claim => claim.Type == "sub").Value;
            ScenarioContext.Add(ScenarioContextDataKeys.UserId, sud);
            ScenarioContext.Add(ScenarioContextDataKeys.UserToken, token);
        }

        [When(@"Registration by api"),
        Given(@"Registration by api")]
        public async Task WhenRegistrationByApi()
        {
            await Accounts.AccountsCreateAccount(SetRandomUserLogin(), SetRandomUserFirstName(), SetRandomUserLastName(), SetRandomUserEmail(), SetRandomUserPassword(), SetRandomUserCountry(), SetRandomUserPhoneNumber());
        }

        [When(@"I create organization for my user")]
        public async Task WhenICreateOrganizationForMyUser()
        {
            var userToken = ScenarioContext.Get<string>(ScenarioContextDataKeys.UserToken);
            var userId = ScenarioContext.Get<string>(ScenarioContextDataKeys.UserId);
            var organizationId = await Organizations.CreateOrganizationForUser(userToken, SetRandomCompanyName(), SetRandomCompanyEmail(), SetCompanyPhoneNumber(), userId,
                SetCompanyStreet(), SetCompanyCountry(), SetCompanyCity(), SetCompanyPostalCode(), SetCompanyProvince());
            ScenarioContext.Set(ScenarioContextDataKeys.OrganizationId, organizationId);
        }



        [When(@"Accept registration by email")]
        public void WhenAcceptRegistrationByEmail()
        {
            User.UpdateEmailConformationForAccepted(GetRandomUserLogin());
        }

        [When(@"User creates business unit")]
        public async Task WhenUserCreatesBusinessUnit()
        {
            var userToken = ScenarioContext.Get<string>(ScenarioContextDataKeys.UserToken);
            var organizationId = ScenarioContext.Get<string>(ScenarioContextDataKeys.OrganizationId);
            var businessUnitId = await BusinessUnit.CreateBusinessUnit(userToken, BusinessUnitData.Name, organizationId);
            ScenarioContext.Set(ScenarioContextDataKeys.BusinessUnitId, businessUnitId);

        }
        [When(@"I take Contract type for my user")]
        public async Task WhenITakeContractTypeForMyUser()
        {
            var userToken = ScenarioContext.Get<string>(ScenarioContextDataKeys.UserToken);
            var organizationId = ScenarioContext.Get<string>(ScenarioContextDataKeys.OrganizationId);
            var contractTypeId = await ContractType.GetContractTypeId(userToken, organizationId);
            ScenarioContext.Set(ScenarioContextDataKeys.ContractTypeId, contractTypeId);
        }

        [When(@"I take project stage for my user")]
        public async Task WhenITakeProjectStaggeForMyUser()
        {
            var userToken = ScenarioContext.Get<string>(ScenarioContextDataKeys.UserToken);
            var organizationId = ScenarioContext.Get<string>(ScenarioContextDataKeys.OrganizationId);
            var projectStageId = await ContractType.GetContractTypeId(userToken, organizationId);
            ScenarioContext.Set(ScenarioContextDataKeys.ProjectStageId, projectStageId);
        }
        [Given(@"Create and login user by Api")]
        public async Task GivenCreateAndLoginUserByApi()
        {
            await Accounts.AccountsCreateAccount(SetRandomUserLogin(), SetRandomUserFirstName(), SetRandomUserLastName(), SetRandomUserEmail(), SetRandomUserPassword(), SetRandomUserCountry(), SetRandomUserPhoneNumber());
            User.UpdateEmailConformationForAccepted(GetRandomUserLogin());
            var token = await AuthRequests.AuthLoginGetToken(GetRandomUserLogin(), GetRandomUserPassword());
            var handler = new JwtSecurityTokenHandler();
            var encodedJwtToken = handler.ReadJwtToken(token);
            var sud = encodedJwtToken.Claims.First(claim => claim.Type == "sub").Value;
            ScenarioContext.Add(ScenarioContextDataKeys.UserId, sud);
            ScenarioContext.Add(ScenarioContextDataKeys.UserToken, token);
        }

        [Given(@"user have contract type, project stage, organization, investment and business unit created")]
        public async Task GivenUserHaveContractTypeProjectStageOrganizationInvestmentAndBusinessUnitCreated()

        {
         
            var userToken = ScenarioContext.Get<string>(ScenarioContextDataKeys.UserToken);
            var userId = ScenarioContext.Get<string>(ScenarioContextDataKeys.UserId);
            var organizationId = await Organizations.CreateOrganizationForUser(userToken, SetRandomCompanyName(), SetRandomCompanyEmail(), SetCompanyPhoneNumber(), userId,
            SetCompanyStreet(), SetCompanyCountry(), SetCompanyCity(), SetCompanyPostalCode(), SetCompanyProvince());
            ScenarioContext.Add(ScenarioContextDataKeys.OrganizationId, organizationId);
            var investmentId = await Investments.PostCreateInvestment(userToken, InvestmentData.Name, organizationId);
            ScenarioContext.Add(ScenarioContextDataKeys.InvestmentId, investmentId);
            var businessUnitId = await BusinessUnit.CreateBusinessUnit(userToken, BusinessUnitData.Name, organizationId);
            ScenarioContext.Add(ScenarioContextDataKeys.BusinessUnitId, businessUnitId);
            var contractTypeId = await ContractType.GetContractTypeId(userToken, organizationId);
            ScenarioContext.Add(ScenarioContextDataKeys.ContractTypeId, contractTypeId);
            var projectStageId = await ProjectStage.GetProjectStageId(userToken, organizationId);
            ScenarioContext.Add(ScenarioContextDataKeys.ProjectStageId, projectStageId);

        }

        [When(@"User creates a new project")]
        public async Task WhenUserCreatesANewProject()
        {
            var userToken = ScenarioContext.Get<string>(ScenarioContextDataKeys.UserToken);
            var organizationId = ScenarioContext.Get<string>(ScenarioContextDataKeys.OrganizationId);
            var investmentId = ScenarioContext.Get<string>(ScenarioContextDataKeys.InvestmentId);
            var businessUnitId = ScenarioContext.Get<string>(ScenarioContextDataKeys.BusinessUnitId);
            var contractTypeId = ScenarioContext.Get<string>(ScenarioContextDataKeys.ContractTypeId);
            var projectStageId = ScenarioContext.Get<string>(ScenarioContextDataKeys.ProjectStageId);
            var projectId = await Projects.PostCreateNewProject(userToken,
                SetProjectName(),
                SetProjectDescription(),
                investmentId,
                SetProjectType(),
                SetProjectConstructionType(),
                SetProjectValue(),
                SetProjectCurrency(),
                ProjectData.ProjectStartDate(),
                ProjectData.ProjectEndDate(),
                SetProjectNumber(),
                SetProjectTimeZone(),
                SetProjectLanguage(),
                businessUnitId,
                contractTypeId,
                SetProjectStreet(),
                SetProjectCountry(),
                SetProjectCity(),
                SetProjectPostalCode(),
                SetProjectProvince(),
                organizationId, projectStageId);
            ScenarioContext.Add(ScenarioContextDataKeys.ProjectId, projectId);
        }

        [Then(@"new project is created in database")]
        public void ThenNewProjectIsCreatedInDatabase()
        {
            var projectId = ScenarioContext.Get<string>(ScenarioContextDataKeys.ProjectId);
            User.ProjectIsExisting(projectId).Should().NotBeNull();
        }


        [When(@"Get email")]
        public async Task WhenGetEmail()
        {
            var bodyValue = await GetEmails.GetBodyValueForCurrentEmail(GetRandomUserEmail());
            bodyValue.Should().ContainAll("To finish","please click","the below", "buton to verify","your account");
        }
    }
}
