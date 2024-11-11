using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class CategoryProductEntity : BaseEntity
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public ICollection<ProductEntity>? Products { get; set; }
    }
}
