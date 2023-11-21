using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TGCLoyaltyApp.Core.Services;
using TGCLoyaltyApp.Core.ViewModels;

namespace TGCLoyaltyApp.Web.Controllers
{
    [Route("api/[controller]/[action]")]
    public class DashboardController : Controller
    {
        private readonly ILogger<DashboardController> logger;
        private readonly IDashboardService dashboardService;
        public DashboardController(IDashboardService dashboardService, ILogger<DashboardController> logger)
        {
            this.dashboardService = dashboardService;
            this.logger = logger;

        }
        [HttpPost]
        public async Task<DashboardResponse> GetDashboardDetails(int roleId, int? userId = null)
        {
            try
            {
                return await this.dashboardService.GetDashboardDetails(roleId, userId);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "error");
                DashboardResponse response = new();
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
