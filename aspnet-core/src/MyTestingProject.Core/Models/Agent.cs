using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Abp.Domain.Entities;
using Abp.Modules;
using Microsoft.EntityFrameworkCore.Update.Internal;

namespace MyTestingProject.Models
{
    [Table("MyTestingProjectDb", Schema = "test")]
    public class Agent : Entity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
    }
}
