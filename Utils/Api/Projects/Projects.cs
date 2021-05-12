using System.Threading.Tasks;
using Flurl.Http;
using IFlow.Testing.Utils.DataFactory;

namespace IFlow.Testing.Utils.Api.Projects
{
    public static class Projects
    {
        public static async Task<string>PostCreateNewProject(string userToken,string name, string description,
            string investmentId,
            string projectType, string constructionType, int projectValue, string currency, string startDate,
            string endDate, string projectNumber, string timeZone, string language, string businessUnitId,
            string contractTypeId, string street, string country, string city, string postalCode,
            string province, string organizationId, string projectStageId)
        {
            return (await ApiAddresses.ProjectsApiUrl
                    .WithOAuthBearerToken(userToken)
                  .PostJsonAsync(new
                  {
                      Name = name,
                      Description = description,
                      InvestmentId = investmentId,
                      ProjectType = projectType,
                      ConstructionType = constructionType,
                      ProjectValue = projectValue,
                      Currency = currency,
                      StartDate = startDate,
                      EndDate = endDate,
                      ProjectNumber = projectNumber,
                      TimeZone = timeZone,
                      Language = language,
                      BusinessUnitId = businessUnitId,
                      ContractTypeId = contractTypeId,
                      Street = street,
                      Country = country,
                      City = city,
                      PostalCode = postalCode,
                      Province = province,
                      OrganizationId = organizationId,
                      Stages = new dynamic[]
                      {
                           new
                        {
                            ProjectStageId= projectStageId,
                            StartDate="2021-04-21T10:59:14.963Z",
                            EndDate="2021-04-21T11:59:14.963Z"
                        }
                      }
                  }).ReceiveJson()).id;
        }
    }
}