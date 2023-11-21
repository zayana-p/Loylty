using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TGCLoyaltyApp.Core.Services;
using TGCLoyaltyApp.Core.ViewModels;

namespace TGCLoyaltyApp.Web.Controllers
{
    [Route("api/[controller]/[action]")]
    public class RewardsController : Controller
    {
        private readonly ILogger<RewardsController> logger;
        private readonly IRewardsService rewardService;
        public RewardsController(IRewardsService rewardService, ILogger<RewardsController> logger)
        {
            this.rewardService = rewardService;
            this.logger = logger;
        }
        [HttpPost]
        public async Task<GetRewardsResponse> GetRewards([FromBody]GetRewardsRequest request)
        {
            try
            {
                return await this.rewardService.GetRewards(request);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "error");
                GetRewardsResponse response = new();
                response.Code = 500;
                string[] errors = new string[2];
                errors[0] = "Unknown Error";
                errors[1] = ex.ToString();
                response.Messages.Add("Error", errors);
                return response;

            }
        }
        [HttpPost]
        public async Task<GetRewardTransactionResponse> GetRewardTransactions([FromBody]GetRewardsRequest request)
        {
            try
            {
                return await this.rewardService.GetRewardTransactions(request);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "error");
                GetRewardTransactionResponse response = new();
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
