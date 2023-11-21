using System;
namespace TGCLoyaltyApp.Core.ViewModels
{
	public class RegisterCustomerResponse : ResponseBase
	{
		public RegisterCustomerResponse(): base()
		{
		}
		public Customer? Customer { get; set; }
		public string? Token { get; set; }
	}
}

