using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using director3.Analytics.Dto;
using director3.StateMachine.Dto;
using director3.PurchaseOrders.Dto;

namespace director3.PurchaseOrders
{
    public interface IPurchaseOrderAppService : IAsyncCrudAppService<
        PurchaseOrderDto,
        long,
        PagedPurchaseOrderResultRequestDto,
        CreatePurchaseOrderDto,
        PurchaseOrderDto>
    {
        Task<PurchaseOrderDto> ChangeStatusAsync(long id, ChangeStatusInput input);
        List<GroupCountDto> GetGroupedCount(PurchaseOrderGroupedCountInput input);
        decimal? GetStats(PurchaseOrderStatsInput input);
    }
}
