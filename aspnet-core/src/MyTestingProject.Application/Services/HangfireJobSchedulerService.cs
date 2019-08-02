using System;
using System.Collections.Generic;
using System.Text;
using Hangfire;

namespace MyTestingProject.Services
{
    public class HangfireJobSchedulerService : MyTestingProjectAppServiceBase
    {
        private readonly MyJobService myJobService;

        public HangfireJobSchedulerService(MyJobService myJobService)
        {
            this.myJobService = myJobService;
        }
        
        public void ScheduleRecurringJobs()
        {
            RecurringJob.RemoveIfExists("myjob");
            RecurringJob.AddOrUpdate("myjob", () => myJobService.RunAtTimeOut(DateTime.Now), Cron.MinuteInterval(2));

        }
    }
}
