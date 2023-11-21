using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using TGCLoyaltyApp.Core.Services;
using TGCLoyaltyApp.Core.ViewModels;

namespace TGCLoyaltyApp.Web.Controllers
{
    [Route("api/[controller]/[action]")]
    public class AddressController : Controller
    {
        private readonly ILogger<AddressController> logger;
        private readonly IAddressService addressService;

        public AddressController(IAddressService addressService, ILogger<AddressController> logger) 
        {
            this.addressService = addressService;
            this.logger = logger;
        }
        [HttpPost]
        public async Task<CreateAddressResponse> Create([FromBody]CreateAddressRequest request)
        {
            try
            {
                return await this.addressService.Create(request);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "error");
                CreateAddressResponse response = new();
                response.Code = 500;
                string[] errors = new string[2];
                errors[0] = "Unknown Error";
                errors[1] = ex.ToString();
                response.Messages.Add("Error", errors);
                return response;

            }
        }
        [HttpGet]
        public async Task<CreateAddressResponse> GetAddress(int customerId)
        {
            try
            {
                return await this.addressService.GetAddress(customerId);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "error");
                CreateAddressResponse response = new();
                response.Code = 500;
                string[] errors = new string[2];
                errors[0] = "Unknown Error";
                errors[1] = ex.ToString();
                response.Messages.Add("Error", errors);
                return response;

            }
        }
        [HttpPost]
        public async Task<CreateAddressResponse> DeleteAddress(int addressId)
        {
            try
            {
                return await this.addressService.DeleteAddress(addressId);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "error");
                CreateAddressResponse response = new();
                response.Code = 500;
                string[] errors = new string[2];
                errors[0] = "Unknown Error";
                errors[1] = ex.ToString();
                response.Messages.Add("Error", errors);
                return response;

            }
        }
        [HttpPost]
        public async Task<UpdateAddressResponse> UpdateAddress([FromBody]UpdateAddressRequest request)
        {
            try
            {
                return await this.addressService.UpdateAddress(request);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "error");
                UpdateAddressResponse response = new();
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
