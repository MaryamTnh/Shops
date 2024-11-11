using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interface
{
    public interface IRoleService
    {
        Task<RoleEntity> GetbyId();
        Task<IEnumerable<RoleEntity>> GetAll();
        Task <IEnumerable<UserEntity>> GetUsersIdByRole();
        Task Add(RoleEntity role);
        Task Update(RoleEntity role);
        Task Delete(RoleEntity role);
    }
}
