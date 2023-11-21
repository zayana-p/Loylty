using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TGCLoyaltyApp.Core.Services;
using TGCLoyaltyApp.Core.ViewModels;

namespace TGCLoyaltyApp.Web.Controllers
{
    [Route("api/[controller]/[action]")]
    public class ServiceTypeController : Controller
    {
        private readonly ILogger<ServiceTypeController> logger;
        private readonly IServiceTypesService serviceTypeService;
        public ServiceTypeController(IServiceTypesService serviceTypeService, ILogger<ServiceTypeController> logger)
        {
            this.serviceTypeService = serviceTypeService;
            this.logger = logger;

        }

        [HttpGet]
        public async Task<ListServiceTypeResponse> GetServiceTypes()
        {
            try
            {
                return await this.serviceTypeService.GetServiceTypes();
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "error");
                ListServiceTypeResponse response = new();
                response.Code = 500;
                string[] errors = new string[2];
                errors[0] = "Unknown Error";
                errors[1] = ex.ToString();
                response.Messages.Add("Error", errors);
                return response;

            }
        }
        [HttpPost]
        public async Task<CreateServiceTypeResponse> Create([FromBody]CreateServiceType request)
        {
            try
            {
                return await this.serviceTypeService.Create(request);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "error");
                CreateServiceTypeResponse response = new();
                response.Code = 500;
                string[] errors = new string[2];
                errors[0] = "Unknown Error";
                errors[1] = ex.ToString();
                response.Messages.Add("Error", errors);
                return response;

            }
        }
    }
}
