using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interface
{
    public interface IUserService
    {
        Task<UserEntity> GetById();
        Task<IEnumerable<UserEntity>> GetAll();
        Task<RoleEntity> GetRoleId();
        Task Add(UserEntity user);
        Task Update(RoleEntity role);
        Task Delete(RoleEntity role);
    }
}
