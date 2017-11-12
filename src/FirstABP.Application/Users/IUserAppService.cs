using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using FirstABP.Roles.Dto;
using FirstABP.Users.Dto;

namespace FirstABP.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UpdateUserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();
    }
}