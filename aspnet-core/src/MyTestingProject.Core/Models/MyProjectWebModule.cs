using System;
using System.Collections.Generic;
using System.Text;
using Abp.Hangfire;
using Abp.Hangfire.Configuration;
using Abp.Modules;

namespace MyTestingProject.Models
{
    [DependsOn(typeof(AbpHangfireAspNetCoreModule))]
    public class MyProjectWebModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.BackgroundJobs.UseHangfire();
        }
    }
}
