using Microsoft.AspNetCore.Mvc;
using TGCLoyaltyApp.Core.Services;
using TGCLoyaltyApp.Core.ViewModels;
using TGCLoyaltyApp.Core.ViewModels.OutletStores;

namespace TGCLoyaltyApp.Web.Controllers
{
    [Route("api/[controller]/[action]")]
    public class ProductTypeController : Controller
    {
        private readonly ILogger<ProductTypeController> logger;
        private readonly IProductTypeService productTypeService;
        public ProductTypeController(IProductTypeService productTypeService, ILogger<ProductTypeController> logger)
        {
            this.productTypeService = productTypeService;
            this.logger = logger;
        }
        [HttpPost]
        public async Task<ProductTypeResponse> AddProductType([FromBody] ProductTypeRequest request)
        {
            try
            {
                return await this.productTypeService.AddProductType(request);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "error");
                ProductTypeResponse response = new();
                response.Code = 500;
                string[] errors = new string[2];
                errors[0] = "Unknown Error";
                errors[1] = ex.ToString();
                response.Messages.Add("Error", errors);
                return response;

            }
        }

        [HttpGet]
        public async Task<GetProductTypes> GetProductTypes()
        {
            try
            {
                return await this.productTypeService.GetProductTypes();
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "error");
                GetProductTypes response = new();
                response.Code = 500;
                string[] errors = new string[2];
                errors[0] = "Unknown Error";
                errors[1] = ex.ToString();
                response.Messages.Add("Error", errors);
                return response;

            }
        }
        [HttpPost]
        public async Task<ProductTypeResponse> DeleteProductType(int productTypeId)
        {
            try
            {
                return await this.productTypeService.DeleteProductType(productTypeId);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "error");
                ProductTypeResponse response = new();
                response.Code = 500;
                string[] errors = new string[2];
                errors[0] = "Unknown Error";
                errors[1] = ex.ToString();
                response.Messages.Add("Error", errors);
                return response;

            }
        }
        [HttpPost]
        public async Task<ProductTypeResponse> UpdateProductType([FromBody] UpdateProductTypeRequest request)
        {
            {
                try
                {
                    return await this.productTypeService.UpdateProductType(request);
                }
                catch (Exception ex)
                {
                    logger.LogError(ex, "error");
                    ProductTypeResponse response = new();
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
}
