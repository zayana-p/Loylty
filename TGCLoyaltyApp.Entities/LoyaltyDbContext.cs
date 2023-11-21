using System;
using Microsoft.EntityFrameworkCore;

namespace TGCLoyaltyApp.Entities
{
	public class LoyaltyDbContext : DbContext
	{
        public LoyaltyDbContext()
        {

        }
        public LoyaltyDbContext(DbContextOptions<LoyaltyDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StoreLocation>().Property(x => x.Latitude).HasPrecision(18, 6);
            modelBuilder.Entity<StoreLocation>().Property(x => x.Longitude).HasPrecision(18, 6);
        }
         

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<UserRole> Roles { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Store> Stores { get; set; }
        public virtual DbSet<StoreLocation> StoreLocations { get; set; }
        public virtual DbSet<Reward> Rewards { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<StorePromotion> StorePromotions { get; set; }
        public virtual DbSet<Ticket> Tickets { get; set; }
        public virtual DbSet<ServiceType> ServiceTypes { get; set; }
        public virtual DbSet<ServiceAccess> ServiceAccess { get; set; }
        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<PushNotification> PushNotifications { get; set; }
        public virtual DbSet<FamilyMember> FamilyMembers { get; set; }
        public virtual DbSet<PaymentType> PaymentTypes { get; set; }
        public virtual DbSet<Notification> Notifications { get; set; }
        public virtual DbSet<Status> Statuses { get; set; }
        public virtual DbSet<StoreOrder> StoreOrders { get; set; }
        public virtual DbSet<SilverReward> SilverRewards { get; set; }
        public virtual DbSet<PianoModel> PianoModels { get; set; }
        public virtual DbSet<OutletStore> OutletStores { get; set; }
        public virtual DbSet<ProductType> ProductTypes { get; set; }
        public virtual DbSet<ProductTypeLocation> ProductTypeLocation { get; set; }
        public virtual DbSet<Emirates> Emirates { get; set; }
        public virtual DbSet<PianoServiceCost> PianoServiceCosts { get; set; }


    }
}

