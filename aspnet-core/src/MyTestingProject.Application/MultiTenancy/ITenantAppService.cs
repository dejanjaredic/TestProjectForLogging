using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MyTestingProject.MultiTenancy.Dto;

namespace MyTestingProject.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

