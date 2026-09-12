using AutoMapper;
using director3.Entities;
using director3.ExpenseCategorys.Dto;

namespace director3.ExpenseCategorys
{
    public class ExpenseCategoryMapProfile : Profile
    {
        public ExpenseCategoryMapProfile()
        {
            CreateMap<ExpenseCategory, ExpenseCategoryDto>();
            CreateMap<CreateExpenseCategoryDto, ExpenseCategory>();
            CreateMap<ExpenseCategoryDto, ExpenseCategory>();
        }
    }
}
