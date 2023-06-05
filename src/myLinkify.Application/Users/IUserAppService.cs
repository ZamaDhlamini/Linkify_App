using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using myLinkify.Roles.Dto;
using myLinkify.Users.Dto;

namespace myLinkify.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task DeActivate(EntityDto<long> user);
        Task Activate(EntityDto<long> user);
        Task<ListResultDto<RoleDto>> GetRoles();
        Task ChangeLanguage(ChangeUserLanguageDto input);

        Task<bool> ChangePassword(ChangePasswordDto input);
    }
}
