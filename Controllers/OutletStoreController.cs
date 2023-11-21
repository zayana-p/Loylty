using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TGCLoyaltyApp.Core.Services;
using TGCLoyaltyApp.Core.ViewModels;
using TGCLoyaltyApp.Core.ViewModels.OutletStores;

namespace TGCLoyaltyApp.Web.Controllers
{
    [Route("api/[controller]/[action]")]
    public class OutletStoreController: Controller
    {
        private readonly ILogger<OutletStoreController> logger;
        private readonly IOutletStoreService outletStoreService;
        public OutletStoreController(IOutletStoreService outletStoreService, ILogger<OutletStoreController> logger)
        {
            this.outletStoreService = outletStoreService;
            this.logger = logger;
        }
        [HttpPost]
        public async Task<OutletStoreResponse> AddOutletStore([FromBody] OutletStoreRequest request)
        {
            try
            {
                return await this.outletStoreService.AddOutletStore(request);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "error");
                OutletStoreResponse response = new();
                response.Code = 500;
                string[] errors = new string[2];
                errors[0] = "Unknown Error";
                errors[1] = ex.ToString();
                response.Messages.Add("Error", errors);
                return response;

            }
        }
        [HttpGet]
        public async Task<GetOutletStores> GetOutletStores()
        {
            try
            {
                return await this.outletStoreService.GetOutletStores();
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "error");
                GetOutletStores response = new();
                response.Code = 500;
                string[] errors = new string[2];
                errors[0] = "Unknown Error";
                errors[1] = ex.ToString();
                response.Messages.Add("Error", errors);
                return response;

            }
        }
        [HttpPost]
        public async Task<OutletStoreResponse> UpdateOutletStore([FromBody] UpdateOutletStoreRequest request)
        {
            {
                try
                {
                    return await this.outletStoreService.UpdateOutletStore(request);
                }
                catch (Exception ex)
                {
                    logger.LogError(ex, "error");
                    OutletStoreResponse response = new();
                    response.Code = 500;
                    string[] errors = new string[2];
                    errors[0] = "Unknown Error";
                    errors[1] = ex.ToString();
                    response.Messages.Add("Error", errors);
                    return response;

                }
            }
        }
        [HttpPost]
        public async Task<OutletStoreResponse> DeleteOutletStore(int pianoId)
        {
            try
            {
                return await this.outletStoreService.DeleteOutletStore(pianoId);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "error");
                OutletStoreResponse response = new();
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


