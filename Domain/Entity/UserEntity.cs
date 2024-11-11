using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class UserEntity : BaseEntity
    {
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public int? Phone { get; set; }
        public string? Email { get; set; }
        [ForeignKey("Role")]
        public int RoleId {  get; set; }
        public RoleEntity? RoleEntity { get; set; }
    }
}
