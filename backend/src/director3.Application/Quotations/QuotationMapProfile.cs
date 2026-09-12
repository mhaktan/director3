using AutoMapper;
using director3.Entities;
using director3.Quotations.Dto;

namespace director3.Quotations
{
    public class QuotationMapProfile : Profile
    {
        public QuotationMapProfile()
        {
            CreateMap<Quotation, QuotationDto>();
            CreateMap<CreateQuotationDto, Quotation>();
            CreateMap<QuotationDto, Quotation>();
        }
    }
}
