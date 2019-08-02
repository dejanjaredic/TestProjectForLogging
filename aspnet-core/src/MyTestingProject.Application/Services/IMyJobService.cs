using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services;

namespace MyTestingProject.Services
{
    public interface IMyJobService : IApplicationService
    {
        void RunAtTimeOut(DateTime now);
       
    }
}
