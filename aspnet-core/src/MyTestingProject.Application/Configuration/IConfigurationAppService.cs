using System.Threading.Tasks;
using MyTestingProject.Configuration.Dto;

namespace MyTestingProject.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
