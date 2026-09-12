using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using director3.Analytics.Dto;
using director3.ExpenseCategorys.Dto;

namespace director3.ExpenseCategorys
{
    public interface IExpenseCategoryAppService : IAsyncCrudAppService<
        ExpenseCategoryDto,
        long,
        PagedExpenseCategoryResultRequestDto,
        CreateExpenseCategoryDto,
        ExpenseCategoryDto>
    {
        Task<ExpenseCategoryReportDto> GetReportData(long id);
    }
}
