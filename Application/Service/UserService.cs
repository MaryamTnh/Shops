using Domain.Entity;
using Domain.Interface;

namespace Shop.Controllers.Service
{
    public class UserService : IUserService
    {
        private readonly IUserService _userService;
        public UserService(IUserService userService)
        {
            _userService = userService;
        }
        public async Task Add(UserEntity user)
        {
            await _userService.Add(user);
        }

        public async Task Delete(RoleEntity role)
        {
            await _userService.Delete(role);
        }

        public async Task<IEnumerable<UserEntity>> GetAll()
        {
            return await _userService.GetAll();
        }

        public async Task<UserEntity> GetById()
        {
            return await _userService.GetById();
        }

        public async Task<RoleEntity> GetRoleId()
        {
            return await _userService.GetRoleId();
        }

        public async Task Update(RoleEntity role)
        {
            await _userService.Update(role);
        }
    }
}
