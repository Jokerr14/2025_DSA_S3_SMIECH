using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSaA_Project_TimeTracker.Database.Entities;

namespace DSaA_Project_TimeTracker.DTOs.User
{
    public class ForUserUpdateDto
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public int RoleId { get; set; }
        public string EmploymentStatus { get; set; }
    }
}
