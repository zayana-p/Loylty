using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TGCLoyaltyApp.Entities
{
    [Table("users", Schema = "loyalty")]
    public class User : EntityBase
    {
        public User()
        {
        }
        [MaxLength(100)]
        public string FirstName { get; set; }
        [MaxLength(100)]
        public string LastName { get; set; }
        [MaxLength(30)]
        public string UserName { get; set; }
        [MaxLength(300)]
        public string Password { get; set; }
        [MaxLength(15)]
        public string Mobile { get; set; }
        [MaxLength(300)]
        public string Email { get; set; }
        public int RoleId { get; set; }
        public int? StoreId { get; set; }

        [ForeignKey("RoleId")]
        public virtual UserRole Role { get; set; }
        [ForeignKey("StoreId")]
        public virtual Store? Store { get; set; }
        public virtual ICollection<ServiceAccess> ServiceAccesses { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }  



    }
}

