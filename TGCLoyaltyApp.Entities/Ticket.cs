using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TGCLoyaltyApp.Entities
{
    [Table("tickets", Schema = "loyalty")]
    public class Ticket : EntityBase
    {
        public Ticket() { }
        public string TicketNo { get; set; }
        public int CustomerId { get; set; }
        public int? PaymentTypeId { get; set; }
        public string? BookingName { get; set; }
        public string? BookingMobile { get; set; }
        public string ServiceType { get; set; }
        public string? InvoiceNo { get; set; }
        public string? EquipmentType { get; set; }
        public string? EquipmentModel { get; set; }
        public string? ShiftFrom { get; set; }
        public string? ShiftTo { get; set; }
        public string? MyLocation { get; set; }
        public string? Description { get; set; }
        public string? Status { get; set; }
        public string? RejectionNote { get; set; }
        public DateTime? PreferedDateTime { get; set; }
        public DateTime? ClosingDate { get; set; }
        public DateTime? ServiceDate { get; set; }
        public string? ServiceTime { get; set; }
        public string? PreferedTime { get; set; }
        public int? AssignedToId { get; set; }
        public decimal? RedeemedPoints { get; set; }
        public decimal? NetAmount { get; set; }
        public decimal? TotalAmount { get; set; }
        public int? OrderId { get; set; }
        [ForeignKey("OrderId")]
        public virtual Order? Order { get; set; }
        [ForeignKey("CustomerId")]
        public virtual Customer Customer { get; set; }
        [ForeignKey("PaymentTypeId")]
        public virtual PaymentType? PaymentType { get; set; }
        [ForeignKey("AssignedToId")]
        public virtual User? User { get; set; }
    }
}
