using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TGCLoyaltyApp.Core.Services;
using TGCLoyaltyApp.Core.ViewModels;

namespace TGCLoyaltyApp.Web.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PaymentTypeController : Controller
    {
        private readonly ILogger<PaymentTypeController> logger;
        private readonly IPaymentTypeService paymentTypeService;
        public PaymentTypeController(IPaymentTypeService paymentTypeService, ILogger<PaymentTypeController> logger)
        {
            this.paymentTypeService = paymentTypeService;
            this.logger = logger;

        }
        [HttpGet]
        public async Task<ListPaymentTypeResponse> GetPaymentTypes()
        {
            try
            {
                return await this.paymentTypeService.GetPaymentTypes();
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "error");
                ListPaymentTypeResponse response = new();
                response.Code = 500;
                string[] errors = new string[2];
                errors[0] = "Unknown Error";
                errors[1] = ex.ToString();
                response.Messages.Add("Error", errors);
                return response;

            }
        }
        [HttpGet]
        public async Task<PaymentType> GetPaymentType(int paymentid)
        {
            try
            {
                return await this.paymentTypeService.GetPaymentType(paymentid);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "error");
                PaymentType response = new();
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
