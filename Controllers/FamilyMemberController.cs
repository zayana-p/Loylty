using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TGCLoyaltyApp.Core.Services;
using TGCLoyaltyApp.Core.ViewModels;

namespace TGCLoyaltyApp.Web.Controllers
{
    [Route("api/[controller]/[action]")]
    public class FamilyMemberController : Controller
    {
        private readonly ILogger<FamilyMemberController> logger;
        private readonly IFamilyMemberService familyMemberService;
        public FamilyMemberController(IFamilyMemberService familyMemberService, ILogger<FamilyMemberController> logger)
        {
            this.familyMemberService = familyMemberService;
            this.logger = logger;

        }
        [HttpPost]
        public async Task<CreateFamilyMemberResponse> Create([FromBody]CreateFamilyMemberRequest request)
        {
            try
            {
                return await this.familyMemberService.Create(request);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "error");
                CreateFamilyMemberResponse response = new();
                response.Code = 500;
                string[] errors = new string[2];
                errors[0] = "Unknown Error";
                errors[1] = ex.ToString();
                response.Messages.Add("Error", errors);
                return response;

            }
        }
        [HttpPost]
        public async Task<UpdateMemberResponse> UpdateMember([FromBody]UpdateMemberRequest request)
        {
            try
            {
                return await this.familyMemberService.UpdateMember(request);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "error");
                UpdateMemberResponse response = new();
                response.Code = 500;
                string[] errors = new string[2];
                errors[0] = "Unknown Error";
                errors[1] = ex.ToString();
                response.Messages.Add("Error", errors);
                return response;

            }
        }
        [HttpGet]
        [Authorize]
        public async Task<GetMembersResponse> GetMembers()
        {
            try
            {
                int id;
                if (int.TryParse(this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value, out id))
                {
                    return await this.familyMemberService.GetMembers(id);
                }
                else
                {
                    GetMembersResponse response = new();
                    response.Code = 500;
                    string[] errors = new string[1];
                    errors[0] = "Not Authorized";
                    response.Messages.Add("Error", errors);
                    return response;
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "error");
                GetMembersResponse response = new();
                response.Code = 500;
                string[] errors = new string[2];
                errors[0] = "Unknown Error";
                errors[1] = ex.ToString();
                response.Messages.Add("Error", errors);
                return response;

            }
        }
        [HttpDelete()]
        [Route("{memberid}")]
        [Authorize]
        public async Task<GetMembersResponse> DeleteMember(int memberId)
        {
            try
            {
                return await this.familyMemberService.DeleteMember(memberId);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "error");
                GetMembersResponse response = new();
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
