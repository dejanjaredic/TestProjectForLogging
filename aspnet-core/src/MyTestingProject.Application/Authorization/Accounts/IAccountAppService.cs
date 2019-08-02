using System.Threading.Tasks;
using Abp.Application.Services;
using MyTestingProject.Authorization.Accounts.Dto;

namespace MyTestingProject.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
