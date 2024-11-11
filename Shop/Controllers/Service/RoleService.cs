using Domain.Entity;
using Domain.Interface;

namespace Shop.Controllers.Service
{
    public class RoleService : IRoleService
    {
        private readonly RoleService _roleService;
        public RoleService(RoleService roleService)
        {
            _roleService = roleService;
        }
        public async Task Add(RoleEntity role)
        {
            await _roleService.Add(role);
        }

        public async Task Delete(RoleEntity role)
        {
            await _roleService.Delete(role);
        }

        public async Task<IEnumerable<RoleEntity>> GetAll()
        {
            return await _roleService.GetAll(); 
        }

        public async Task<RoleEntity> GetbyId()
        {
            return await _roleService.GetbyId();
        }

        public async Task<IEnumerable<UserEntity>> GetUsersIdByRole()
        {
            return await _roleService.GetUsersIdByRole();
        }

        public async Task Update(RoleEntity role)
        {
            await _roleService.Update(role);
        }
    }
}
