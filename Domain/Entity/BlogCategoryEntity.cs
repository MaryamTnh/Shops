using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class BlogCategoryEntity : BaseEntity
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Image { get; set; }
        [ForeignKey("Blog")]
        public int BlogId { get; set; }
        public BlogEntity? BlogEntity { get; set; }
    }
}
