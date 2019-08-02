using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services;

namespace MyTestingProject.Notificatin
{
    public interface IEmailAppService : IApplicationService
    {
        Task SendEmail();
    }
}
