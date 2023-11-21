using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Security.Claims;
using TGCLoyaltyApp.Core.Services;
using TGCLoyaltyApp.Core.ViewModels;

namespace TGCLoyaltyApp.Web.Controllers
{
    [Route("api/[controller]/[action]")]
    public class UserController : Controller
    {
        private readonly ILogger<UserController> logger;
        private readonly IUserService userService;
        public UserController(IUserService userService, ILogger<UserController> logger)
        {
            this.userService = userService;
            this.logger = logger;

        }
        [HttpPost]
        public async Task<CreateUserResponse> Create([FromBody] CreateUserRequest request)
        {
            try
            {
                return await this.userService.Create(request);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "error");
                CreateUserResponse response = new();
                response.Code = 500;
                string[] errors = new string[2];
                errors[0] = "Unknown Error";
                errors[1] = ex.ToString();
                response.Messages.Add("Error", errors);
                return response;

            }
        }
        [HttpPost]
        public async Task<ActionResult<UserLoginResponse>> Login([FromBody] UserLoginRequest request)
        {
            try
            {
                return await this.userService.Login(request);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "error");
                UserLoginResponse response = new();
                response.Code = 500;
                string[] errors = new string[2];
                errors[0] = "Unknown Error";
                errors[1] = ex.ToString();
                response.Messages.Add("Error", errors);
                return response;

            }
        }
        [HttpPost]
        public async Task<ListUsersResponse> GetUsers([FromBody] ListUsersRequest request)
        {
            try
            {
                return await this.userService.GetUsers(request);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "error");
                ListUsersResponse response = new();
                response.Code = 500;
                string[] errors = new string[2];
                errors[0] = "Unknown Error";
                errors[1] = ex.ToString();
                response.Messages.Add("Error", errors);
                return response;

            }
        }
        [HttpPost]
        public async Task<UpdateUserResponse> UpdateUserDetails([FromBody] UpdateUserRequest request)
        {
            try
            {
                return await this.userService.UpdateUserDetails(request);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "error");
                UpdateUserResponse response = new();
                response.Code = 500;
                string[] errors = new string[2];
                errors[0] = "Unknown Error";
                errors[1] = ex.ToString();
                response.Messages.Add("Error", errors);
                return response;

            }
        }
        [HttpPost]
        public async Task<ChangePasswordUserResponse> ChangePassword([FromBody] ChangePasswordUserRequest request)
        {
            try
            {
                return await this.userService.ChangePassword(request);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "error");
                ChangePasswordUserResponse response = new();
                response.Code = 500;
                string[] errors = new string[2];
                errors[0] = "Unknown Error";
                errors[1] = ex.ToString();
                response.Messages.Add("Error", errors);
                return response;

            }
        }
        [HttpGet]
        public async Task<GetUserRoleResponse> GetUserRoles()
        {
            try
            {
                return await this.userService.GetUserRoles();
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "error");
                GetUserRoleResponse response = new();
                response.Code = 500;
                string[] errors = new string[2];
                errors[0] = "Unknown Error";
                errors[1] = ex.ToString();
                response.Messages.Add("Error", errors);
                return response;

            }
        }
        [HttpPut]
        public async Task<DeleteUserResponse> DeleteUser([FromBody] DeleteUserRequest request)
        {
            try
            {
                return await this.userService.DeleteUser(request);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "error");
                DeleteUserResponse response = new();
                response.Code = 500;
                string[] errors = new string[2];
                errors[0] = "Unknown Error";
                errors[1] = ex.ToString();
                response.Messages.Add("Error", errors);
                return response;

            }
        }
        [HttpGet]
        public async Task<GetUserResponse> GetUserDetails(GetUserRequest request)
        {
            try
            {
                return await this.userService.GetUserDetails(request);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "error");
                GetUserResponse response = new();
                response.Code = 500;
                string[] errors = new string[2];
                errors[0] = "Unknown Error";
                errors[1] = ex.ToString();
                response.Messages.Add("Error", errors);
                return response;
            }
        }
        [HttpPost]
        public async Task<BlockUserResponse> CancelUser([FromBody]BlockUserRequest request)
        {
            try
            {
                return await this.userService.CancelUser(request);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "error");
                BlockUserResponse response = new();
                response.Code = 500;
                string[] errors = new string[2];
                errors[0] = "Unknown Error";
                errors[1] = ex.ToString();
                response.Messages.Add("Error", errors);
                return response;

            }
        }
        [HttpPost]
        public async Task<ValidateUserNameResponse> ValidateUserName(string userName)
        {
            try
            {
                return await this.userService.ValidateUserName(userName);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "error");
                ValidateUserNameResponse response = new();
                response.Code = 500;
                string[] errors = new string[2];
                errors[0] = "Unknown Error";
                errors[1] = ex.ToString();
                response.Messages.Add("Error", errors);
                return response;

            }
        }
        [HttpGet]
        public async Task<ListUsersResponse> GetServiceTech(string serviceTypeCode)
        {
            try
            {
                return await this.userService.GetServiceTech(serviceTypeCode);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "error");
                ListUsersResponse response = new();
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
