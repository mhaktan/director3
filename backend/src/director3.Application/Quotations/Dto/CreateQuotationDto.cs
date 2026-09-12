using System;
using System.ComponentModel.DataAnnotations;
using Abp.AutoMapper;

namespace director3.Quotations.Dto
{
    [AutoMapTo(typeof(Entities.Quotation))]
    public class CreateQuotationDto
    {
        public DateTime QuotationDate { get; set; }

        public decimal Amount { get; set; }

        public bool IsSelected { get; set; }

        [MaxLength(500)]
        public string Notes { get; set; }

        public long PurchaseRequestId { get; set; }

        public long SupplierId { get; set; }

    }
}