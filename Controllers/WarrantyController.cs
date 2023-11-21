using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TGCLoyaltyApp.Core.Services;
using TGCLoyaltyApp.Core.ViewModels;

namespace TGCLoyaltyApp.Web.Controllers
{
    [Route("api/[controller]/[action]")]
    public class WarrantyController : Controller
    {
        private readonly ILogger<WarrantyController> logger;
        private readonly IWarrantyService warrantyService;
        public WarrantyController(IWarrantyService warrantyService, ILogger<WarrantyController> logger)
        {
            this.warrantyService = warrantyService;
            this.logger = logger; 

        }
        [HttpPost]
        public async Task<CreateStoreOrderResponse> Create([FromBody]CreateStoreOrder request)
        {
            try
            {
                return await this.warrantyService.Create(request);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "error");
                CreateStoreOrderResponse response = new();
                response.Code = 500;
                string[] errors = new string[2];
                errors[0] = "Unknown Error";
                errors[1] = ex.ToString();
                response.Messages.Add("Error", errors);
                return response;

            }
        }
        [HttpGet]
        public async Task<GetStoreOrderResponse> GetStoreOrdersByCustomer(int customerId)
        {
            try
            {
                return await this.warrantyService.GetStoreOrdersByCustomer(customerId);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "error");
                GetStoreOrderResponse response = new();
                response.Code = 500;
                string[] errors = new string[2];
                errors[0] = "Unknown Error";
                errors[1] = ex.ToString();
                response.Messages.Add("Error", errors);
                return response;

            }
        }
        [HttpPost]
        public async Task<GetStoreOrderResponse> GetAllStoreOrders([FromBody] FilterStoreOrderRequest request)
        {
            try
            {
                return await this.warrantyService.GetAllStoreOrders(request);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "error");
                GetStoreOrderResponse response = new();
                response.Code = 500;
                string[] errors = new string[2];
                errors[0] = "Unknown Error";
                errors[1] = ex.ToString();
                response.Messages.Add("Error", errors);
                return response;

            }
        }
        [HttpGet]
        public async Task<GetStoreOrders> GetStoreOrderById(int storeOrderId)
        {
            try
            {
                return await this.warrantyService.GetStoreOrderById(storeOrderId);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "error");
                GetStoreOrders response = new();
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
