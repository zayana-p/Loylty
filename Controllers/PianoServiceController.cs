using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TGCLoyaltyApp.Core.Services;
using TGCLoyaltyApp.Core.ViewModels;
using TGCLoyaltyApp.Core.ViewModels;

namespace TGCLoyaltyApp.Web.Controllers
{
    [Route("api/[controller]/[action]")]
    public class PianoServiceController : Controller
    {
        private readonly ILogger<PianoServiceController> logger;
        private readonly IPianoMasterService pianoService;

        public PianoServiceController(IPianoMasterService pianoService, ILogger<PianoServiceController> logger)
        {
            this.pianoService = pianoService;
            this.logger = logger;
        }
        [HttpPost]
        public async Task<PianoServiceTypeResponse> AddPiano([FromBody]PianoServiceTypeRequest request)
        {
            try
            {
                return await this.pianoService.AddPiano(request);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "error");
                PianoServiceTypeResponse response = new();
                response.Code = 500;
                string[] errors = new string[2];
                errors[0] = "Unknown Error";
                errors[1] = ex.ToString();
                response.Messages.Add("Error", errors);
                return response;

            }
        }
        [HttpGet]
        public async Task<GetPianoServiceTypes> GetPianoTypes()
        {
            try
            {
                return await this.pianoService.GetPianoTypes();
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "error");
                GetPianoServiceTypes response = new();
                response.Code = 500;
                string[] errors = new string[2];
                errors[0] = "Unknown Error";
                errors[1] = ex.ToString();
                response.Messages.Add("Error", errors);
                return response;

            }
        }
        [HttpPost]
        public async Task<PianoServiceTypeResponse> UpdatePianoMaster([FromBody] UpdatePianoServiceRequest request)
        {
            {
                try
                {
                    return await this.pianoService.UpdatePianoMaster(request);
                }
                catch (Exception ex)
                {
                    logger.LogError(ex, "error");
                    PianoServiceTypeResponse response = new();
                    response.Code = 500;
                    string[] errors = new string[2];
                    errors[0] = "Unknown Error";
                    errors[1] = ex.ToString();
                    response.Messages.Add("Error", errors);
                    return response;

                }
            }
        }
        [HttpGet]
        public async Task<PianoServiceTypeResponse> GetPianoByModel(string model)
        {
            try
            {
                return await this.pianoService.GetPianoByModel(model);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "error");
                PianoServiceTypeResponse response = new();
                response.Code = 500;
                string[] errors = new string[2];
                errors[0] = "Unknown Error";
                errors[1] = ex.ToString();
                response.Messages.Add("Error", errors);
                return response;

            }
        }
        [HttpPost]
        public async Task<PianoServiceTypeResponse> DeletePiano(int pianoId)
        {
            try
            {
                return await this.pianoService.DeletePiano(pianoId);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "error");
                PianoServiceTypeResponse response = new();
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
