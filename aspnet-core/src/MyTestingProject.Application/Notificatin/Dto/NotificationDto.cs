using System;
using System.Collections.Generic;
using System.Text;
using Abp.AutoMapper;
using MyTestingProject.Models;

namespace MyTestingProject.Notificatin.Dto
{
    [AutoMap(typeof(Notification))]
    public class NotificationDto
    {
        public DateTime ExecuteDateTime { get; set; }

        public int AgentId { get; set; }

        public string AgentEmail { get; set; }

        public string Text { get; set; }

        public int NotificationStatus { get; set; }
    }
}
