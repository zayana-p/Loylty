using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TGCLoyaltyApp.Core.Services;
using TGCLoyaltyApp.Core.ViewModels;

namespace TGCLoyaltyApp.Web.Controllers
{
    [Route("api/[controller]/[action]")]
    public class EmiratesController : Controller
    {
        private readonly ILogger<EmiratesController> logger;
        private readonly IEmiratesService emiratesService;
        public EmiratesController(IEmiratesService emiratesService, ILogger<EmiratesController> logger)
        {
            this.emiratesService = emiratesService;
            this.logger = logger;

        }
        [HttpGet]
        public async Task<GetEmirates> GetEmirates()
        {
            try
            {
                return await this.emiratesService.GetEmirates();
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "error");
                GetEmirates response = new();
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
