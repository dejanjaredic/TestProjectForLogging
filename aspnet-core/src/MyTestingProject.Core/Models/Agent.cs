using System;
using System.Collections.Generic;
using System.Text;
using Abp.Domain.Entities;
using Abp.Modules;

namespace MyTestingProject.Models
{
    public class Agent : Entity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
    }
}
