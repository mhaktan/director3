using System;
using System.Collections.Generic;
using director3.PurchaseRequestItems.Dto;
using director3.Quotations.Dto;
using director3.PurchaseOrders.Dto;
using director3.Approvals.Dto;

namespace director3.PurchaseRequests.Dto
{
    /// <summary>
    /// Rapor verisi — kok kayit ve alt koleksiyonlar tek yanitta.
    /// PDF sablonu tek apiBinding kullandigi icin nested donuyoruz.
    /// </summary>
    public class PurchaseRequestReportDto
    {
        public PurchaseRequestDto Data { get; set; }
        public List<PurchaseRequestItemDto> PurchaseRequestItems { get; set; }
        public List<QuotationDto> Quotations { get; set; }
        public List<PurchaseOrderDto> PurchaseOrders { get; set; }
        public List<ApprovalRecordDto> ApprovalHistory { get; set; }
    }
}
