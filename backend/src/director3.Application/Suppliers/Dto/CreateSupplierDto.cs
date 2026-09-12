using System;
using System.ComponentModel.DataAnnotations;
using Abp.AutoMapper;

namespace director3.Suppliers.Dto
{
    [AutoMapTo(typeof(Entities.Supplier))]
    public class CreateSupplierDto
    {
        [Required]
        [MaxLength(20)]
        public string Code { get; set; }

        [Required]
        [MaxLength(200)]
        public string Name { get; set; }

        [MaxLength(50)]
        public string TaxNumber { get; set; }

        [MaxLength(200)]
        public string ContactPerson { get; set; }

        [MaxLength(256)]
        public string Email { get; set; }

        public bool IsActive { get; set; }

    }
}