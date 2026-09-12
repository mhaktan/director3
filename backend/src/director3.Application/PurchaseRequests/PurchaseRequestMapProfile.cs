using AutoMapper;
using director3.Entities;
using director3.PurchaseRequests.Dto;

namespace director3.PurchaseRequests
{
    public class PurchaseRequestMapProfile : Profile
    {
        public PurchaseRequestMapProfile()
        {
            CreateMap<PurchaseRequest, PurchaseRequestDto>()
                .ForMember(d => d.StatusName, o => o.MapFrom(s => s.Status.ToString()));
            CreateMap<CreatePurchaseRequestDto, PurchaseRequest>();
            CreateMap<PurchaseRequestDto, PurchaseRequest>();
        }
    }
}
