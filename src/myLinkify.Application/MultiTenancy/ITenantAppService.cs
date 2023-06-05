using Abp.Application.Services;
using myLinkify.MultiTenancy.Dto;

namespace myLinkify.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

