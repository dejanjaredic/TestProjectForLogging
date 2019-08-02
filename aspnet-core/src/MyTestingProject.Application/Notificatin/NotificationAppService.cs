using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Abp.AutoMapper;
using Abp.Domain.Repositories;
using Abp.Net.Mail;
using Hangfire.Logging;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using MyTestingProject.Authorization.Users;
using MyTestingProject.Models;
using MyTestingProject.Notificatin.Dto;

namespace MyTestingProject.Notificatin
{
    public class NotificationAppService : INotificationAppService
    {
        private readonly IRepository<Notification> notificationRepository;
        private readonly IEmailSender emailSender;
        public readonly ILog _log = LogProvider.GetLogger("MyJobService");
        public ILogger Logger { get; set; }
        public NotificationAppService(IRepository<Notification> notificationRepository, IEmailSender emailSender)
        {
            this.notificationRepository = notificationRepository;
            this.emailSender = emailSender;
            Logger = NullLogger.Instance;
        }
        public void CreateNotification(NotificationDto input)
        {
            var notification = new NotificationDto
            {
                AgentEmail = input.AgentEmail,
                AgentId = input.AgentId,
                ExecuteDateTime = input.ExecuteDateTime,
                NotificationStatus = 0,
                Text = input.Text
            };

            var addNotification = notification.MapTo<Notification>();
            this.notificationRepository.Insert(addNotification);
        }


        public void TestingLoger()
        {
            _log.Info("testiranje logera pocinje " + DateTime.Now);
        }

        public void TestAssembly()
        {
            User user = new User();

            Type t = user.GetType();
            PropertyInfo[] props = t.GetProperties();

            foreach (var property in props)
            {
                Console.WriteLine("Ptoperty Name - " + property.Name);
            }

        }
    }
}
