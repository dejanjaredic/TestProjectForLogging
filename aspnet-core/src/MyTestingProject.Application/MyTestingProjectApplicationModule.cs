using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MyTestingProject.Authorization;

namespace MyTestingProject
{
    [DependsOn(
        typeof(MyTestingProjectCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class MyTestingProjectApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<MyTestingProjectAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(MyTestingProjectApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
