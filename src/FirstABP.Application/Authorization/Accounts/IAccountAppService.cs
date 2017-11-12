using System.Threading.Tasks;
using Abp.Application.Services;
using FirstABP.Authorization.Accounts.Dto;

namespace FirstABP.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
