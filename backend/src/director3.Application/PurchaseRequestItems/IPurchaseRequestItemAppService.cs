using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using director3.Analytics.Dto;
using director3.PurchaseRequestItems.Dto;

namespace director3.PurchaseRequestItems
{
    public interface IPurchaseRequestItemAppService : IAsyncCrudAppService<
        PurchaseRequestItemDto,
        long,
        PagedPurchaseRequestItemResultRequestDto,
        CreatePurchaseRequestItemDto,
        PurchaseRequestItemDto>
    {
        List<GroupCountDto> GetGroupedCount(PurchaseRequestItemGroupedCountInput input);
        decimal? GetStats(PurchaseRequestItemStatsInput input);
    }
}
