using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Abp.Domain.Entities;

namespace MyTestingProject.Models
{
    [Table("Logging", Schema = "log")]
    public class Log : Entity
    {
        public string Level { get; set; }
        public string Message { get; set; }
        public string Exception { get; set; }
    }
}
