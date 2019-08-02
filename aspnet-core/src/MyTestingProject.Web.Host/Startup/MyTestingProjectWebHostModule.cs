using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MyTestingProject.Configuration;

namespace MyTestingProject.Web.Host.Startup
{
    [DependsOn(
       typeof(MyTestingProjectWebCoreModule))]
    public class MyTestingProjectWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public MyTestingProjectWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MyTestingProjectWebHostModule).GetAssembly());
        }
    }
}
