using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TGCLoyaltyApp.Core.Services;
using TGCLoyaltyApp.Core.ViewModels;

namespace TGCLoyaltyApp.Web.Controllers
{
    [Route("api/[controller]/[action]")]
    public class NotificationController : Controller
    {
        private readonly ILogger<NotificationController> logger;
        private readonly INotificationService notificationService;
        public NotificationController(INotificationService notificationService, ILogger<NotificationController> logger)
        {
            this.notificationService = notificationService;
            this.logger = logger;

        }
        [HttpPost]
        public async Task<PushNotificationResponse> Create([FromBody]PushNotificationRequest request)
        {
            try
            {
                return await this.notificationService.Create(request);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "error");
                PushNotificationResponse response = new();
                response.Code = 500;
                string[] errors = new string[2];
                errors[0] = "Unknown Error";
                errors[1] = ex.ToString();
                response.Messages.Add("Error", errors);
                return response;

            }
        }
        [HttpPost]
        public async Task<PushNotificationResponse> SendPushNotification(string title, string content, string deviceType, string path = "")
        {
            try
            {
                return await this.notificationService.SendPushNotification(title, content, deviceType, path);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "error");
                PushNotificationResponse response = new();
                response.Code = 500;
                string[] errors = new string[2];
                errors[0] = "Unknown Error";
                errors[1] = ex.ToString();
                response.Messages.Add("Error", errors);
                return response;

            }
        }
        [HttpPost]
        public async Task<PushNotificationResponse> SendNotificationToCustomer(string title, string content, int customerId, string path = "")
        {
            try
            {
                return await this.notificationService.SendNotificationToCustomer(title, content, customerId, path);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "error");
                PushNotificationResponse response = new();
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
