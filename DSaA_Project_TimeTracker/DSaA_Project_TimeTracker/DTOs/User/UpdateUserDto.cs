using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSaA_Project_TimeTracker.DTOs.User
{
    public class UpdateUserDto
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string EmploymentStatus { get; set; }
    }
}

