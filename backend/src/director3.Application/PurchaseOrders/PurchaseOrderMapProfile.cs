using AutoMapper;
using director3.Entities;
using director3.PurchaseOrders.Dto;

namespace director3.PurchaseOrders
{
    public class PurchaseOrderMapProfile : Profile
    {
        public PurchaseOrderMapProfile()
        {
            CreateMap<PurchaseOrder, PurchaseOrderDto>()
                .ForMember(d => d.StatusName, o => o.MapFrom(s => s.Status.ToString()));
            CreateMap<CreatePurchaseOrderDto, PurchaseOrder>();
            CreateMap<PurchaseOrderDto, PurchaseOrder>();
        }
    }
}
