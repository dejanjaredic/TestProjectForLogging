using System;
using Abp.AspNetCore.Mvc.Controllers;
using Castle.Core.Logging;
using Hangfire;
using Microsoft.AspNetCore.Mvc;
using MyTestingProject.Notificatin;
using MyTestingProject.Services;

namespace MyTestingProject.Web.Host.Controllers
{
    [Route("/api/HangFire")]
    public class HangFireController : AbpController
    {
        private readonly IMyJobService myJobService;
        private readonly EmailAppService _emailAppService;
        private readonly ILoggerFactory _loggerFactory;
        private readonly ILogger _logger;

        public HangFireController(IMyJobService myJobService, EmailAppService emailAppService, ILoggerFactory loggerFactory, ILogger logger)
        {
            this.myJobService = myJobService;
            _emailAppService = emailAppService;
            _loggerFactory = loggerFactory;
            _logger = logger;
        }

        [HttpGet]
        [Obsolete]
        public IActionResult Index()
        {
            RecurringJob.RemoveIfExists("job-teast");
            RecurringJob.AddOrUpdate("job-teast", () => this._emailAppService.SendEmail(), Cron.MinuteInterval(2));
            _loggerFactory.Create("Logger2.txt");

            return Ok();
        }
    }
}