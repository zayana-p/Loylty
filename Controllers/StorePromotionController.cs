using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using TGCLoyaltyApp.Core.Services;
using TGCLoyaltyApp.Core.ViewModels;

namespace TGCLoyaltyApp.Web.Controllers
{
    [Route("api/[controller]/[action]")]
    public class StorePromotionController : Controller
    {
        private readonly ILogger<StorePromotionController> logger;
        private readonly IStorePromotionService storePromotionService;
        public StorePromotionController(IStorePromotionService storePromotionService, ILogger<StorePromotionController> logger)
        {
            this.storePromotionService = storePromotionService;
            this.logger = logger;

        }
        [HttpPost]
        public async Task<CreateStorePromotionResponse> Create([FromBody]CreateStorePromotionRequest request)
        {
            try
            {
                return await this.storePromotionService.Create(request);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "error");
                CreateStorePromotionResponse response = new();
                response.Code = 500;
                string[] errors = new string[2];
                errors[0] = "Unknown Error";
                errors[1] = ex.ToString();
                response.Messages.Add("Error", errors);
                return response;

            }
        }
        [HttpGet]
        public async Task<GetStorePromotionResponse> GetStorePromotion(GetStorePromotionRequest request)
        {
            try
            {
                return await this.storePromotionService.GetStorePromotion(request);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "error");
                GetStorePromotionResponse response = new();
                response.Code = 500;
                string[] errors = new string[2];
                errors[0] = "Unknown Error";
                errors[1] = ex.ToString();
                response.Messages.Add("Error", errors);
                return response;

            }
        }
        [HttpPost]
        public async Task<GetStorePromotionResponse> GetStorePromotions( [FromBody]ListStorePromotionRequest request)
        {
            try
            {
                return await this.storePromotionService.GetStorePromotions(request);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "error");
                GetStorePromotionResponse response = new();
                response.Code = 500;
                string[] errors = new string[2];
                errors[0] = "Unknown Error";
                errors[1] = ex.ToString();
                response.Messages.Add("Error", errors);
                return response;

            }
        }
        [HttpGet]
        public async Task<GetAllStorePromotionResponse> GetStorePromotionById(int storePromotionId)
        {
            try
            {
                return await this.storePromotionService.GetStorePromotionById(storePromotionId);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "error");
                GetAllStorePromotionResponse response = new();
                response.Code = 500;
                string[] errors = new string[2];
                errors[0] = "Unknown Error";
                errors[1] = ex.ToString();
                response.Messages.Add("Error", errors);
                return response;

            }
        }
        [HttpDelete]
        public async Task<GetStorePromotionResponse> DeleteStorePromotion(int storePromotionId)
        {
            try
            {
                return await this.storePromotionService.DeleteStorePromotion(storePromotionId);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "error");
                GetStorePromotionResponse response = new();
                response.Code = 500;
                string[] errors = new string[2];
                errors[0] = "Unknown Error";
                errors[1] = ex.ToString();
                response.Messages.Add("Error", errors);
                return response;

            }
        }
        [HttpPost]
        public async Task<UpdateStorePromotionResponse> UpdateStorePromotion([FromBody]UpdateStorePromotionRequest request)
        {
            try
            {
                return await this.storePromotionService.UpdateStorePromotion(request);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "error");
                UpdateStorePromotionResponse response = new();
                response.Code = 500;
                string[] errors = new string[2];
                errors[0] = "Unknown Error";
                errors[1] = ex.ToString();
                response.Messages.Add("Error", errors);
                return response;

            }
        }
        [HttpPost]
        public async Task<GetStorePromotionResponse> GetAllStorePromotions([FromBody] ListStorePromotionRequest request)
        {
            try
            {
                return await this.storePromotionService.GetAllStorePromotions(request);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "error");
                GetStorePromotionResponse response = new();
                response.Code = 500;
                string[] errors = new string[2];
                errors[0] = "Unknown Error";
                errors[1] = ex.ToString();
                response.Messages.Add("Error", errors);
                return response;

            }
        }
        [HttpPost]
        public async Task<DeleteStorepromotionResponse> BlockStorePromotion([FromBody] DeleteStorepromotionRequest request)
        {
            try
            {
                return await this.storePromotionService.BlockStorePromotion(request);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "error");
                DeleteStorepromotionResponse response = new();
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
