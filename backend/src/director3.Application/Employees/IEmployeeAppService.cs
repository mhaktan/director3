using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using director3.Analytics.Dto;
using director3.Employees.Dto;

namespace director3.Employees
{
    public interface IEmployeeAppService : IAsyncCrudAppService<
        EmployeeDto,
        long,
        PagedEmployeeResultRequestDto,
        CreateEmployeeDto,
        EmployeeDto>
    {
        List<GroupCountDto> GetGroupedCount(EmployeeGroupedCountInput input);
        Task<EmployeeReportDto> GetReportData(long id);
    }
}
