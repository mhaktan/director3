using AutoMapper;
using director3.Entities;
using director3.Employees.Dto;

namespace director3.Employees
{
    public class EmployeeMapProfile : Profile
    {
        public EmployeeMapProfile()
        {
            CreateMap<Employee, EmployeeDto>();
            CreateMap<CreateEmployeeDto, Employee>();
            CreateMap<EmployeeDto, Employee>();
        }
    }
}
