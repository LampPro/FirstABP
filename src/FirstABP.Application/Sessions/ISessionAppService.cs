using System.Threading.Tasks;
using Abp.Application.Services;
using FirstABP.Sessions.Dto;

namespace FirstABP.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
