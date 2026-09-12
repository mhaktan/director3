using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using director3.Analytics.Dto;
using director3.Suppliers.Dto;

namespace director3.Suppliers
{
    public interface ISupplierAppService : IAsyncCrudAppService<
        SupplierDto,
        long,
        PagedSupplierResultRequestDto,
        CreateSupplierDto,
        SupplierDto>
    {
        Task<SupplierReportDto> GetReportData(long id);
    }
}
