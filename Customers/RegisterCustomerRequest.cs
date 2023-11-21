using System;
namespace TGCLoyaltyApp.Core.ViewModels
{
	public class RegisterCustomerRequest :  RequestBase
	{
		public RegisterCustomerRequest(): base()
		{
		}
		public Customer Customer { get; set; }
        public string? ReferalCode { get; set; }
    }
}

