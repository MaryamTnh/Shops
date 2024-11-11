using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class ProductEntity : BaseEntity
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int Price { get; set; }
        [ForeignKey("CategoryProduct")]
        public int CategoryProductEntityId {  get; set; }
        public CategoryProductEntity? CategoryProduct { get; set; }
    }
}
