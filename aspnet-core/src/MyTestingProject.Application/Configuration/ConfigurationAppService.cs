using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using MyTestingProject.Configuration.Dto;

namespace MyTestingProject.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : MyTestingProjectAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
