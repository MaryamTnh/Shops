using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class RoleEntity : BaseEntity
    {
        [Required(ErrorMessage ="نام را وارد کنید")]
        public string? Name { get; set; }
        public string? Description { get; set; }
        public ICollection<UserEntity>? Users { get; set; }
    }
}
