using System.Threading.Tasks;
using Abp.Application.Services;
using FirstABP.Configuration.Dto;

namespace FirstABP.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}