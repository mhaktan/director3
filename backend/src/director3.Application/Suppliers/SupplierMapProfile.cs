using AutoMapper;
using director3.Entities;
using director3.Suppliers.Dto;

namespace director3.Suppliers
{
    public class SupplierMapProfile : Profile
    {
        public SupplierMapProfile()
        {
            CreateMap<Supplier, SupplierDto>();
            CreateMap<CreateSupplierDto, Supplier>();
            CreateMap<SupplierDto, Supplier>();
        }
    }
}
