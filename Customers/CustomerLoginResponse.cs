using System;
namespace TGCLoyaltyApp.Core.ViewModels
{
	public class CustomerLoginResponse : ResponseBase
	{
		public CustomerLoginResponse()
		{
		}
		public Customer Customer { get; set; }
		public string Token { get; set; }
		public string LoginToken { get; set; }
	}
}

