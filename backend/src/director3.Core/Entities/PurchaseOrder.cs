using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;

namespace director3.Entities
{
    // State Machine: status — Draft → Sent → PartiallyDelivered → Delivered → Cancelled
    // Initial: Draft | Transitions: Draft→Sent[Send], Sent→PartiallyDelivered[MarkPartialDelivery], Sent→Delivered[MarkDelivered], PartiallyDelivered→Delivered[MarkDelivered], *→Cancelled[Cancel]
    [Table("PurchaseOrders")]
    public class PurchaseOrder : FullAuditedEntity<long>
    {
        [Required]
        [MaxLength(50)]
        public string OrderNumber { get; set; }

        public DateTime OrderDate { get; set; }

        public DateTime? ExpectedDeliveryDate { get; set; }

        public DateTime? DeliveryDate { get; set; }

        public decimal OrderAmount { get; set; }

        [MaxLength(500)]
        public string Notes { get; set; }

        public PurchaseOrderStatus Status { get; set; }

        public long PurchaseRequestId { get; set; }

        [ForeignKey(nameof(PurchaseRequestId))]
        public virtual PurchaseRequest PurchaseRequest { get; set; }

        public long SupplierId { get; set; }

        [ForeignKey(nameof(SupplierId))]
        public virtual Supplier Supplier { get; set; }

    }
}