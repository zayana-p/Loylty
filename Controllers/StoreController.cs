using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TGCLoyaltyApp.Core.Services;
using TGCLoyaltyApp.Core.ViewModels;

namespace TGCLoyaltyApp.Web.Controllers
{
    [Route("api/[controller]/[action]")]

    public class StoreController : Controller
    {
        private readonly ILogger<StoreController> logger;
        private readonly IStoreService storeService;
        public StoreController(IStoreService storeService, ILogger<StoreController> logger)
        {
            this.storeService = storeService;
            this.logger = logger;

        }
        [HttpPost]
        public async Task<CreateStoreResponse> Create([FromBody] CreateStoreRequest request)
        {
            try
            {
                return await this.storeService.Create(request);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "error");
                CreateStoreResponse response = new();
                response.Code = 500;
                string[] errors = new string[2];
                errors[0] = "Unknown Error";
                errors[1] = ex.ToString();
                response.Messages.Add("Error", errors);
                return response;

            }
        }
        [HttpGet]
        public async Task<GetStoreResponse> GetStore(int storeId)
        {
            try
            {
                return await this.storeService.GetStore(storeId);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "error");
                GetStoreResponse response = new();
                response.Code = 500;
                string[] errors = new string[2];
                errors[0] = "Unknown Error";
                errors[1] = ex.ToString();
                response.Messages.Add("Error", errors);
                return response;

            }
        }
        [HttpPost]
        public async Task<GetAllStoreResponse> GetStores([FromBody]ListStoreRequest request)
        {
            try
            {
                return await this.storeService.GetStores(request);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "error");
                GetAllStoreResponse response = new();
                response.Code = 500;
                string[] errors = new string[2];
                errors[0] = "Unknown Error";
                errors[1] = ex.ToString();
                response.Messages.Add("Error", errors);
                return response;

            }
        }
        [HttpPost]
        public async Task<UpdateStoreResponse> UpdateStore([FromBody] UpdateStoreRequest request)
        {
            try
            {
                return await this.storeService.UpdateStore(request);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "error");
                UpdateStoreResponse response = new();
                response.Code = 500;
                string[] errors = new string[2];
                errors[0] = "Unknown Error";
                errors[1] = ex.ToString();
                response.Messages.Add("Error", errors);
                return response;

            }
        }
        [HttpPost]
        public async Task<GetStoreResponse> DeleteStore([FromBody] int storeId)
        {
            try
            {
                return await this.storeService.DeleteStore(storeId);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "error");
                GetStoreResponse response = new();
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
