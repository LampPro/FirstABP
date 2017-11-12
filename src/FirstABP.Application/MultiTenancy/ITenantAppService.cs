using Abp.Application.Services;
using Abp.Application.Services.Dto;
using FirstABP.MultiTenancy.Dto;

namespace FirstABP.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
