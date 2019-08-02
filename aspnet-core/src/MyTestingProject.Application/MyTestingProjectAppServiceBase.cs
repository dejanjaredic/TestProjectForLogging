using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Abp.Application.Services;
using Abp.IdentityFramework;
using Abp.Runtime.Session;
using MyTestingProject.Authorization.Users;
using MyTestingProject.MultiTenancy;
namespace MyTestingProject
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class MyTestingProjectAppServiceBase : ApplicationService
    {
        public TenantManager TenantManager { get; set; }

        public UserManager UserManager { get; set; }

        protected MyTestingProjectAppServiceBase()
        {
            LocalizationSourceName = MyTestingProjectConsts.LocalizationSourceName;
        }

        protected virtual Task<User> GetCurrentUserAsync()
        {
            var user = UserManager.FindByIdAsync(AbpSession.GetUserId().ToString());
            if (user == null)
            {
                throw new Exception("There is no current user!");
            }

            return user;
        }

        protected virtual Task<Tenant> GetCurrentTenantAsync()
        {
            return TenantManager.GetByIdAsync(AbpSession.GetTenantId());
        }

        protected virtual void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }

        public void Testing()
        {
            Logger.Info("Na sve se loguje " + DateTime.Now);
        }
    }
}
