using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TGCLoyaltyApp.Core.Services;
using TGCLoyaltyApp.Core.ViewModels;

namespace TGCLoyaltyApp.Web.Controllers
{
    [Route("api/[controller]/[action]")]
    public class BackOfficeController : Controller
    {
        private readonly ILogger<BackOfficeController> logger;
        private readonly IBackOfficeService backOfficeService;
        public BackOfficeController(IBackOfficeService backOfficeService, ILogger<BackOfficeController> logger)
        {
            this.backOfficeService = backOfficeService;
            this.logger = logger;

        }
        [HttpPost]
        public async Task<StudentValidationResponse> ValidateStudentEnrollment([FromBody] StudentEnrollmentExcelRequest request)
        {

            try
            {
                return await this.backOfficeService.ValidateStudentEnrollment(request);

            }
            catch (Exception ex)
            {
                logger.LogError(ex, "error");
                StudentValidationResponse response = new();
                response.Code = 500;
                string[] errors = new string[2];
                errors[0] = "Unknown Error";
                errors[1] = ex.ToString();
                response.Messages.Add("Error", errors);
                return response;
            }
        }
        [HttpPost]
        public async Task<StudentRewardsExcelResponse> UploadStudentRewards([FromBody] StudentRewardsExcelRequest request)
        {

            try
            {
                return await this.backOfficeService.UploadStudentRewards(request);

            }
            catch (Exception ex)
            {
                logger.LogError(ex, "error");
                StudentRewardsExcelResponse response = new();
                response.Code = 500;
                string[] errors = new string[2];
                errors[0] = "Unknown Error";
                errors[1] = ex.ToString();
                response.Messages.Add("Error", errors);
                return response;
            }
        }
        [HttpPost]
        public async Task<UpdateStoreOrderResponse> UpdateStatusRewards([FromBody]UpdateStoreOrderRequest request)
        {

            try
            {
                return await this.backOfficeService.UpdateStatusRewards(request);

            }
            catch (Exception ex)
            {
                logger.LogError(ex, "error");
                UpdateStoreOrderResponse response = new();
                response.Code = 500;
                string[] errors = new string[2];
                errors[0] = "Unknown Error";
                errors[1] = ex.ToString();
                response.Messages.Add("Error", errors);
                return response;
            }
        }
        [HttpPost]
        public async Task<MusicFeeRewardsResponse> MusicFeeRedeem([FromBody] CreateMusicFeeRewards request)
        {
            try
            {
                return await this.backOfficeService.MusicFeeRedeem(request);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "error");
                MusicFeeRewardsResponse response = new();
                response.Code = 500;
                string[] errors = new string[2];
                errors[0] = "Unknown Error";
                errors[1] = ex.ToString();
                response.Messages.Add("Error", errors);
                return response;

            }
        }
        [HttpPost]
        public async Task<GiftRewardsResponse> GiftRewards([FromBody] GiftRewardsRequest request)
        {
            try
            {
                return await this.backOfficeService.GiftRewards(request);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "error");
                GiftRewardsResponse response = new();
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
