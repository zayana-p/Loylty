using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TGCLoyaltyApp.Core.Services;
using TGCLoyaltyApp.Core.ViewModels;

namespace TGCLoyaltyApp.Web.Controllers
{
    [Route("api/[controller]/[action]")]

    public class StoreLocationController : Controller
    {
        private readonly ILogger<StoreLocationController> logger;
        private readonly IStoreLocationService storeLocationService;
        public StoreLocationController(IStoreLocationService storeLocationService, ILogger<StoreLocationController> logger)
        {
            this.storeLocationService = storeLocationService;
            this.logger = logger;

        }
        [HttpGet]
        public async Task<GetStoreDetailsResponse> GetStoreDetail(GetStoreDetailsRequest request)
        {
            try
            {
                return await this.storeLocationService.GetStoreDetail(request);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "error");
                GetStoreDetailsResponse response = new();
                response.Code = 500;
                string[] errors = new string[2];
                errors[0] = "Unknown Error";
                errors[1] = ex.ToString();
                response.Messages.Add("Error", errors);
                return response;

            }
        }
        [HttpPost]
        public async Task<CreateStoreLocationResponse> Create([FromBody] CreateStoreLocationRequest request)
        {
            try
            {
                return await this.storeLocationService.Create(request);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "error");
                CreateStoreLocationResponse response = new();
                response.Code = 500;
                string[] errors = new string[2];
                errors[0] = "Unknown Error";
                errors[1] = ex.ToString();
                response.Messages.Add("Error", errors);
                return response;

            }
        }
        [HttpGet]
        public async Task<GetStoreLocationResponse> GetStoreLocation(GetStoreLocationRequest request)
        {
            try
            {
                return await this.storeLocationService.GetStoreLocation(request);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "error");
                GetStoreLocationResponse response = new();
                response.Code = 500;
                string[] errors = new string[2];
                errors[0] = "Unknown Error";
                errors[1] = ex.ToString();
                response.Messages.Add("Error", errors);
                return response;

            }
        }
        [HttpGet]
        public async Task<GetAllStoreLocations> GetStoreLocations(ListStoreLocationRequest request)
        {
            try
            {
                return await this.storeLocationService.GetAllStoreLocation(request);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "error");
                GetAllStoreLocations response = new();
                response.Code = 500;
                string[] errors = new string[2];
                errors[0] = "Unknown Error";
                errors[1] = ex.ToString();
                response.Messages.Add("Error", errors);
                return response;

            }
        }
        [HttpPost]
        public async Task<UpdateStoreLocationResponse> UpdateLocation([FromBody] UpdateStoreLocationRequest request)
        {
            try
            {
                return await this.storeLocationService.UpdateLocationDetails(request);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "error");
                UpdateStoreLocationResponse response = new();
                response.Code = 500;
                string[] errors = new string[2];
                errors[0] = "Unknown Error";
                errors[1] = ex.ToString();
                response.Messages.Add("Error", errors);
                return response;

            }
        }
        [HttpPost]
        public async Task<GetStoreLocationResponse> DeleteLocation([FromBody] GetStoreLocationRequest request)
        {
            try
            {
                return await this.storeLocationService.DeleteLocation(request);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "error");
                GetStoreLocationResponse response = new();
                response.Code = 500;
                string[] errors = new string[2];
                errors[0] = "Unknown Error";
                errors[1] = ex.ToString();
                response.Messages.Add("Error", errors);
                return response;

            }
        }
        [HttpGet]
        public async Task<GetStoreLocationDetails> GetStoreLocationDetails()
        {
            try
            {
                return await this.storeLocationService.GetStoreLocationDetails();
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "error");
                GetStoreLocationDetails response = new();
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
