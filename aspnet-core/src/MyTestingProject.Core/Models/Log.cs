using System;
using System.Collections.Generic;
using System.Text;
using Abp.Domain.Entities;

namespace MyTestingProject.Models
{
    public class Log : Entity
    {
        public string Level { get; set; }
        public string Message { get; set; }
        public string Exception { get; set; }
    }
}
