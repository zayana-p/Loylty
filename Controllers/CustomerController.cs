using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TGCLoyaltyApp.Core.Components;
using TGCLoyaltyApp.Core.Helpers;
using TGCLoyaltyApp.Core.Services;
using TGCLoyaltyApp.Core.ViewModels;
using TGCLoyaltyApp.Core.ViewModels.Customers;
using static TGCLoyaltyApp.Core.Components.BlobStorageComponent;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TGCLoyaltyApp.Web.Controllers
{
    [Route("api/[controller]/[action]")]
    public class CustomerController : Controller
    {
        private readonly ILogger<CustomerController> logger;
        private readonly ICustomerService customerService;
        public CustomerController(ICustomerService customerService, ILogger<CustomerController> logger)
        {
            this.customerService = customerService;
            this.logger = logger;

        }
        [HttpPost]
        public async Task<ActionResult<RegisterCustomerResponse>> Register([FromBody] RegisterCustomerRequest request)
        {
            try
            {
                return await this.customerService.Register(request);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "error");
                RegisterCustomerResponse response = new();
                response.Code = 500;
                string[] errors = new string[2];
                errors[0] = "Unknown Error";
                errors[1] = ex.ToString();
                response.Messages.Add("Error", errors);
                return response;

            }
        }
        [HttpPost]
        public async Task<ActionResult<CustomerLoginResponse>> Login([FromBody] CustomerLoginRequest request)
        {
            try
            {
                return await this.customerService.Login(request);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "error");
                CustomerLoginResponse response = new();
                response.Code = 500;
                string[] errors = new string[2];
                errors[0] = "Unknown Error";
                errors[1] = ex.ToString();
                response.Messages.Add("Error", errors);
                return response;

            }
        }
        [HttpPost]
        public async Task<GenerateCustomerOTPResponse> GenerateOtp([FromBody] GenerateCustomerOTPRequest request)
        {

            try
            {
               
                return await this.customerService.GenerateOTP(request);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "error");
                GenerateCustomerOTPResponse response = new();
                response.Code = 500;
                string[] errors = new string[2];
                errors[0] = "Unknown Error";
                errors[1] = ex.ToString();
                response.Messages.Add("Error", errors);
                return response;
            }
        }
        [HttpPost]
        public async Task<ValidateCustomerOTPResponse> ValidateOTP([FromBody] ValidateCustomerOTPRequest request)
        {
            try
            {
               
                return await this.customerService.ValidateOTP(request);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "error");
                ValidateCustomerOTPResponse response = new();
                response.Code = 500;
                string[] errors = new string[2];
                errors[0] = "Unknown Error";
                errors[1] = ex.ToString();
                response.Messages.Add("Error", errors);
                return response;
            }
        }
        [HttpPost]
        public async Task<ResetPasswordResponse> GenerateResetPasswordOTP([FromBody] ResetPasswordRequest request)
        {
            try
            {
              
                return await this.customerService.GenerateResetPasswordOTP(request);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "error");
                ResetPasswordResponse response = new();
                response.Code = 500;
                string[] errors = new string[2];
                errors[0] = "Unknown Error";
                errors[1] = ex.ToString();
                response.Messages.Add("Error", errors);
                return response;
            }
        }
        [HttpPost]
        public async Task<ActionResult<ValidateResetPasswordOtpResponse>> ValidateResetPasswordOtp([FromBody] ResetPasswordOtpRequest request)
        {
            try
            {
                
                return await this.customerService.ValidateResetPasswordOtp(request);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "error");
                ValidateResetPasswordOtpResponse response = new();
                response.Code = 500;
                string[] errors = new string[2];
                errors[0] = "Unknown Error";
                errors[1] = ex.ToString();
                response.Messages.Add("Error", errors);
                return response;

            }
        }
        [HttpPost]
        public async Task<ValidateResetPasswordOtpResponse> ResetPassword([FromBody] ValidateResetPasswordOtpRequest request)
        {
            try
            {
                return await this.customerService.ResetPassword(request);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "error");
                ValidateResetPasswordOtpResponse response = new();
                response.Code = 500;
                string[] errors = new string[2];
                errors[0] = "Unknown Error";
                errors[1] = ex.ToString();
                response.Messages.Add("Error", errors);
                return response;

            }
        }
        [HttpGet]
        public async Task<GetCustomerResponse> GetCustomerDetails(GetCustomerRequest request)
        {
            try
            {
                return await this.customerService.GetCustomerDetails(request);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "error");
                GetCustomerResponse response = new();
                response.Code = 500;
                string[] errors = new string[2];
                errors[0] = "Unknown Error";
                errors[1] = ex.ToString();
                response.Messages.Add("Error", errors);
                return response;
            }
        }
        [HttpGet]
        public async Task<GetStudentResponse> GetStudentDetails(string enrollmentNumber)
        {
            try
            {
                return await this.customerService.GetStudentDetails(enrollmentNumber);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "error");
                GetStudentResponse response = new();
                response.Code = 500;
                string[] errors = new string[2];
                errors[0] = "Unknown Error";
                errors[1] = ex.ToString();
                response.Messages.Add("Error", errors);
                return response;
            }
        }
        [HttpPost]
        //[Authorize]
        public async Task<UpdateCustomerResponse> UpdateCustomerDetails([FromBody] UpdateCustomerRequest request)
        {
            try
            {
                int id;
                if (int.TryParse(this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value, out id))
                {
                    request.CustomerId = id;
                }
                return await this.customerService.UpdateCustomerDetails(request);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "error");
                UpdateCustomerResponse response = new();
                response.Code = 500;
                string[] errors = new string[2];
                errors[0] = "Unknown Error";
                errors[1] = ex.ToString();
                response.Messages.Add("Error", errors);
                return response;

            }
        }
        [HttpPost]
        public async Task<ListCustomerResponse> GetAllCustomers([FromBody]ListCustomerRequest request)
        {
            try
            {
                return await this.customerService.GetAllCustomers(request);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "error");
                ListCustomerResponse response = new();
                response.Code = 500;
                string[] errors = new string[2];
                errors[0] = "Unknown Error";
                errors[1] = ex.ToString();
                response.Messages.Add("Error", errors);
                return response;

            }
        }
        [HttpPost]
        public async Task<DeleteCustomerResponse> DeleteCustomer([FromBody]DeleteCustomerRequest request)
        {
            try
            {
                return await this.customerService.DeleteCustomer(request);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "error");
                DeleteCustomerResponse response = new();
                response.Code = 500;
                string[] errors = new string[2];
                errors[0] = "Unknown Error";
                errors[1] = ex.ToString();
                response.Messages.Add("Error", errors);
                return response;

            }
        }
        [HttpPost]
        public async Task<EmailOtpResponse> ValidateEmailPasswordOtp([FromBody]EmailOtpRequest request)
        {
            try
            {

                return await this.customerService.ValidateEmailPasswordOtp(request);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "error");
                EmailOtpResponse response = new();
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
        public async Task<GenerateEmailOTPResponse> GenerateEmailOTP()
        {

            try
            {
                int id;
                if (int.TryParse(this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value, out id))
                {

                    return await this.customerService.GenerateEmailOTP(id);
                }
                else
                {
                    GenerateEmailOTPResponse response = new();
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
                GenerateEmailOTPResponse response = new();
                response.Code = 500;
                string[] errors = new string[2];
                errors[0] = "Unknown Error";
                errors[1] = ex.ToString();
                response.Messages.Add("Error", errors);
                return response;
            }
        }
        [HttpPost]
        [Authorize]
        public async Task<UpdateMobileNoResponse> UpdateMobileNo([FromBody] UpdateMobileNoRequest request)
        {
            try
            {
                int id;
                if (int.TryParse(this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value, out id))
                {
                    request.CustomerId = id;
                }
                return await this.customerService.UpdateMobileNo(request);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "error");
                UpdateMobileNoResponse response = new();
                response.Code = 500;
                string[] errors = new string[2];
                errors[0] = "Unknown Error";
                errors[1] = ex.ToString();
                response.Messages.Add("Error", errors);
                return response;

            }
        }
        [HttpPost]
        [Authorize]
        public async Task<ChangePasswordCustomerResponse> ChangePassword([FromBody] ChangePasswordCustomerRequest request)
        {
            try
            {
                int id;
                if (int.TryParse(this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value, out id))
                {
                    request.CustomerId = id;
                }
                return await this.customerService.ChangePassword(request);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "error");
                ChangePasswordCustomerResponse response = new();
                response.Code = 500;
                string[] errors = new string[2];
                errors[0] = "Unknown Error";
                errors[1] = ex.ToString();
                response.Messages.Add("Error", errors);
                return response;

            }
        }
        [HttpPost]
        [Authorize]
        public async Task<BlobResponseDto> UploadProfilePic(IFormFile data)
        {

            try
            {
                int id;
                if (int.TryParse(this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value, out id))
                {
                    return await this.customerService.UploadProfilePic(data, id);
                }
                return new BlobResponseDto() { Code = 401 };
                
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "error");
                BlobResponseDto response = new();
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
        public async Task<ProfilePicResponse> GetProfilePic(int customerId)
        {

            try
            {
                int id;
                if (int.TryParse(this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value, out id))
                {

                    return await this.customerService.GetProfilePic(customerId);
                }
                else
                {
                    ProfilePicResponse response = new();
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
                ProfilePicResponse response = new();
                response.Code = 500;
                string[] errors = new string[2];
                errors[0] = "Unknown Error";
                errors[1] = ex.ToString();
                response.Messages.Add("Error", errors);
                return response;
            }
        }
        //[HttpPost]
        //public async Task<StudentValidationResponse> ValidateStudentEnrollment([FromBody]StudentEnrollmentExcelRequest request)
        //{

        //    try
        //    {
        //        return await this.customerService.ValidateStudentEnrollment(request);

        //    }
        //    catch (Exception ex)
        //    {
        //        logger.LogError(ex, "error");
        //        StudentValidationResponse response = new();
        //        response.Code = 500;
        //        string[] errors = new string[2];
        //        errors[0] = "Unknown Error";
        //        errors[1] = ex.ToString();
        //        response.Messages.Add("Error", errors);
        //        return response;
        //    }
        //}
        //[HttpPost]
        //public async Task<StudentRewardsExcelResponse> AddStudentRewards([FromBody]StudentRewardsExcelRequest request)
        //{

        //    try
        //    {
        //        return await this.customerService.AddStudentRewards(request);

        //    }
        //    catch (Exception ex)
        //    {
        //        logger.LogError(ex, "error");
        //        StudentRewardsExcelResponse response = new();
        //        response.Code = 500;
        //        string[] errors = new string[2];
        //        errors[0] = "Unknown Error";
        //        errors[1] = ex.ToString();
        //        response.Messages.Add("Error", errors);
        //        return response;
            //}
        ///}
    }
}

