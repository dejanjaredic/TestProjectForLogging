using System;
using System.Collections.Generic;
using System.Text;
using Abp.Application.Services;
using MyTestingProject.Notificatin.Dto;

namespace MyTestingProject.Notificatin
{
    public interface INotificationAppService : IApplicationService
    {
        void CreateNotification(NotificationDto input);
    }
}
