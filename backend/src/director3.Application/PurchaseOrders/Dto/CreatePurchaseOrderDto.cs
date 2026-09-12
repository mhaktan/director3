using System;
using System.ComponentModel.DataAnnotations;
using Abp.AutoMapper;

namespace director3.PurchaseOrders.Dto
{
    [AutoMapTo(typeof(Entities.PurchaseOrder))]
    public class CreatePurchaseOrderDto
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

        public int Status { get; set; }

        public long PurchaseRequestId { get; set; }

        public long SupplierId { get; set; }

    }
}