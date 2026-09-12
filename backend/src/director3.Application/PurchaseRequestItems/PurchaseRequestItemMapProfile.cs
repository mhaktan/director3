using AutoMapper;
using director3.Entities;
using director3.PurchaseRequestItems.Dto;

namespace director3.PurchaseRequestItems
{
    public class PurchaseRequestItemMapProfile : Profile
    {
        public PurchaseRequestItemMapProfile()
        {
            CreateMap<PurchaseRequestItem, PurchaseRequestItemDto>();
            CreateMap<CreatePurchaseRequestItemDto, PurchaseRequestItem>();
            CreateMap<PurchaseRequestItemDto, PurchaseRequestItem>();
        }
    }
}
