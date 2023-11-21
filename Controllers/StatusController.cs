using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TGCLoyaltyApp.Core.Services;
using TGCLoyaltyApp.Core.ViewModels;

namespace TGCLoyaltyApp.Web.Controllers
{
    [Route("api/[controller]/[action]")]
    public class StatusController : Controller
    {
        private readonly ILogger<StatusController> logger;
        private readonly IStatusService statusService;
        public StatusController(IStatusService statusService, ILogger<StatusController> logger)
        {
            this.statusService = statusService;
            this.logger = logger;
        }
        [HttpGet]
        public async Task<GetServiceStatus> GetStatuses(int serviceTypeId)
        {
            try
            {
                return await this.statusService.GetStatuses(serviceTypeId);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "error");
                GetServiceStatus response = new();
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
