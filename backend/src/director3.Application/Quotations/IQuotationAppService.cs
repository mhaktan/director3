using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using director3.Analytics.Dto;
using director3.Quotations.Dto;

namespace director3.Quotations
{
    public interface IQuotationAppService : IAsyncCrudAppService<
        QuotationDto,
        long,
        PagedQuotationResultRequestDto,
        CreateQuotationDto,
        QuotationDto>
    {
        List<GroupCountDto> GetGroupedCount(QuotationGroupedCountInput input);
        decimal? GetStats(QuotationStatsInput input);
    }
}
