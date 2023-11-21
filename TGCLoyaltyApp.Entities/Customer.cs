using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TGCLoyaltyApp.Entities
{
	[Table("customers", Schema = "loyalty")]
	public class Customer : EntityBase
	{
		public Customer() : base()
		{
		}
		[MaxLength(100)]
		public string FirstName { get; set; }
		[MaxLength(100)]
		public string LastName { get; set; }
		[MaxLength(10)]
		public string CardNo { get; set; }
        [MaxLength(10)]
        public string ReferalNo { get; set; }
		public int ReferedBy { get; set; }
        [MaxLength(300)]
		public string Password { get; set; }
		[MaxLength(15)]
		public string Mobile { get; set; }
		[MaxLength(300)]
		public string? Email { get; set; }
		[MaxLength(1)]
		public	char CustomerType { get; set; }
		public DateTime DateOfBirth { get; set; }
		public int OTP { get; set; }
        public int PasswordOTP { get; set; }
        public int EmailOTP { get; set; }
		public string CardType { get; set; }
		public string? FileUrl { get; set; }
        public bool IsValidated { get; set; } = false;
        public virtual ICollection<Reward> Rewards { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }
        public virtual ICollection<Address> Address { get; set; }
        public virtual ICollection<PushNotification> PushNotification { get; set; }
        public virtual ICollection<FamilyMember> FamilyMember { get; set; }
        public virtual ICollection<SilverReward> SilverRewards { get; set; }
        public virtual ICollection<StoreOrder> StoreOrders { get; set; }



    }
}

