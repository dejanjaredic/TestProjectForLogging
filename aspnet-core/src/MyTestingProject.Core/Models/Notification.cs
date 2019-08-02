using System;
using System.Collections.Generic;
using System.Text;
using Abp.Domain.Entities;

namespace MyTestingProject.Models
{
    public class Notification : Entity
    {
        public DateTime ExecuteDateTime { get; set; }

        public int AgentId { get; set; }

        public string AgentEmail { get; set; }

        public string Text { get; set; }

        public int NotificationStatus { get; set; }
    }
}
