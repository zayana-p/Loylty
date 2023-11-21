using System;
namespace TGCLoyaltyApp.Core.ViewModels
{
	public abstract class RequestBase
	{
		public RequestBase()
		{
		}
		public int? CustomerId { get; set; }

	}
}

