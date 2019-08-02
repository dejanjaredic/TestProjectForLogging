using System;
using System.Threading.Tasks;
using Abp.Domain.Repositories;
using Abp.Domain.Uow;
using Castle.Core.Logging;
using Hangfire;
using Hangfire.Logging;
using MyTestingProject.Models;

namespace MyTestingProject.Services
{
    public class MyJobService : MyTestingProjectAppServiceBase, IMyJobService
    {
        private readonly IRepository<Notification> _notificationRepository;
        private readonly IRepository<TimeModel> _timeRepository;
        public readonly ILog _log = LogProvider.GetLogger("MyJobService");
        ///private readonly ILog _log = LogProvider.GetLogger("MyJobService");
        public MyJobService(IRepository<Notification> notificationRepository, IRepository<TimeModel> timeRepository)
        {
            _notificationRepository = notificationRepository;
            _timeRepository = timeRepository;
            //_log = log;
        }

        public async Task Run(IJobCancellationToken token)
        {
            token.ThrowIfCancellationRequested();
            RunAtTimeOut(DateTime.Now);
        }
        
        public virtual void RunAtTimeOut(DateTime now)
        {
            var time = new TimeModel();
            time.DateTime = now;
            _timeRepository.Insert(time);
        }

        
    }
}
