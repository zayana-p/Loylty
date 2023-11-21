using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TGCLoyaltyApp.Core.Services;
using TGCLoyaltyApp.Core.ViewModels;

namespace TGCLoyaltyApp.Web.Controllers
{
    [Route("api/[controller]/[action]")]
    public class OrderController : Controller
    {
        private readonly ILogger<StoreController> logger;
        private readonly IOrderService orderService;
        public OrderController(IOrderService orderService, ILogger<StoreController> logger) 
        {
            this.orderService = orderService;
            this.logger = logger;
        }
        [HttpPost]
        public CreateOrderResponse Create([FromBody] CreateOrderRequest request)
        {
            try
            {
                return this.orderService.Create(request);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "error");
                CreateOrderResponse response = new();
                response.Code = 500;
                string[] errors = new string[2];
                errors[0] = "Unknown Error";
                errors[1] = ex.ToString();
                response.Messages.Add("Error", errors);
                return response;

            }
        }
        [HttpGet]
        public async Task<GetOrderDetailsResponse> GetOrder(GetOrderDetailsRequest request)
        {
            try
            {
                return await this.orderService.GetOrderDetails(request);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "error");
                GetOrderDetailsResponse response = new();
                response.Code = 500;
                string[] errors = new string[2];
                errors[0] = "Unknown Error";
                errors[1] = ex.ToString();
                response.Messages.Add("Error", errors);
                return response;

            }
        }
        [HttpGet]
        public async Task<GetAllOrder> GetOrders()
        {
            try
            {
                return await this.orderService.GetAllOrders();
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "error");
                GetAllOrder response = new();
                response.Code = 500;
                string[] errors = new string[2];
                errors[0] = "Unknown Error";
                errors[1] = ex.ToString();
                response.Messages.Add("Error", errors);
                return response;

            }
        }

        [HttpGet]
        public async Task<GetAllOrder> GetAllOrdersByCustomer(int customerId)
        {
            try
            {
                return await this.orderService.GetAllOrdersByCustomer(customerId);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "error");
                GetAllOrder response = new();
                response.Code = 500;
                string[] errors = new string[2];
                errors[0] = "Unknown Error";
                errors[1] = ex.ToString();
                response.Messages.Add("Error", errors);
                return response;

            }
        }

        [HttpGet]
        public async Task<ListMyProductResponse> GetAllOrdersDetails(int customerId)
        {
            try
            {
                return await this.orderService.GetAllOrdersDetails(customerId);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "error");
                ListMyProductResponse response = new();
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
