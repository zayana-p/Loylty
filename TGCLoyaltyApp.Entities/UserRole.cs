using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace TGCLoyaltyApp.Entities
{
	[Table("userroles", Schema = "loyalty")]
	public class UserRole : EntityBase
	{
		public UserRole()
		{
		}
		public string Name { get; set; }
		public string Code { get; set; }
		public virtual ICollection<User> Users { get; set; }
	}
}

