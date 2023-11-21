using System;
namespace TGCLoyaltyApp.Core.ViewModels
{
	public abstract class ResponseBase
	{
		public ResponseBase()
		{
			this.Messages = new Dictionary<string,string[]>();
		}
		public int Code { get; set; }
		public IDictionary<string, string[]> Messages { get; set; }
	}
}

