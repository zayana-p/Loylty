using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TGCLoyaltyApp.Core.Services;
using TGCLoyaltyApp.Core.ViewModels;

namespace TGCLoyaltyApp.Web.Controllers
{
    [Route("api/[controller]/[action]")]
    public class TicketController : Controller
    {
        private readonly ILogger<TicketController> logger;
        private readonly ITicketService ticketService;
        public TicketController(ITicketService ticketService, ILogger<TicketController> logger)
        {
            this.ticketService = ticketService;
            this.logger = logger;
        }
        [HttpPost]
        public async Task<CreateTicketResponse> Create([FromBody]CreateTicketRequest request)
        {
            try
            {
                return await this.ticketService.Create(request);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "error");
                CreateTicketResponse response = new();
                response.Code = 500;
                string[] errors = new string[2];
                errors[0] = "Unknown Error";
                errors[1] = ex.ToString();
                response.Messages.Add("Error", errors);
                return response;

            }
        }
        [HttpPost]
        public async Task<UpdateTicketStatusResponse> UpdateTicketStatus([FromBody]UpdateTicketStatusRequest request)
        {
            try
            {
                return await this.ticketService.UpdateTicketStatus(request);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "error");
                UpdateTicketStatusResponse response = new();
                response.Code = 500;
                string[] errors = new string[2];
                errors[0] = "Unknown Error";
                errors[1] = ex.ToString();
                response.Messages.Add("Error", errors);
                return response;

            }
        }
        [HttpPost]
        public async Task<GetTicketsResponse> FilterTickets([FromBody]FilterTicketRequest request)
        {
            try
            {
                return await this.ticketService.GetTickets(request);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "error");
                GetTicketsResponse response = new();
                response.Code = 500;
                string[] errors = new string[2];
                errors[0] = "Unknown Error";
                errors[1] = ex.ToString();
                response.Messages.Add("Error", errors);
                return response;

            }
        }
        //[HttpGet]
        //public async Task<GetTicketsResponse> GetTicketsByCustomerType(GetCustomerTicketRequest request)
        //{
        //    try
        //    {
        //        return await this.ticketService.GetTickets(request);
        //    }
        //    catch (Exception ex)
        //    {
        //        logger.LogError(ex, "error");
        //        GetTicketsResponse response = new();
        //        response.Code = 500;
        //        string[] errors = new string[2];
        //        errors[0] = "Unknown Error";
        //        errors[1] = ex.ToString();
        //        response.Messages.Add("Error", errors);
        //        return response;

        //    }
        //}
        [HttpPost]
        public async Task<GetTicketsResponse> GetTickets([FromBody]GetCustomerTicketRequest request)
        {
            try
            {
                return await this.ticketService.GetTickets(request);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "error");
                GetTicketsResponse response = new();
                response.Code = 500;
                string[] errors = new string[2];
                errors[0] = "Unknown Error";
                errors[1] = ex.ToString();
                response.Messages.Add("Error", errors);
                return response;

            }
        }
        [HttpPost]
        public async Task<UpdateTicketStatusResponse> CancelTicket([FromBody]int ticketId)
        {
            try
            {
                return await this.ticketService.CancelTicket(ticketId);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "error");
                UpdateTicketStatusResponse response = new();
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
