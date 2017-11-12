using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using FirstABP.Configuration.Dto;

namespace FirstABP.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : FirstABPAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
