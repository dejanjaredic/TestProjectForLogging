using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace MyTestingProject.Controllers
{
    public abstract class MyTestingProjectControllerBase: AbpController
    {
        protected MyTestingProjectControllerBase()
        {
            LocalizationSourceName = MyTestingProjectConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
