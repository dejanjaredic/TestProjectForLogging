using System.Threading.Tasks;
using Abp.Application.Services;
using MyTestingProject.Sessions.Dto;

namespace MyTestingProject.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
