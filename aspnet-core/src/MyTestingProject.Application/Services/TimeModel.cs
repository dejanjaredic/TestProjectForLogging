using System;
using System.Collections.Generic;
using System.Text;
using Abp.Domain.Entities;

namespace MyTestingProject.Services
{
    public class TimeModel : Entity
    {
        public DateTime DateTime { get; set; }
    }
}
