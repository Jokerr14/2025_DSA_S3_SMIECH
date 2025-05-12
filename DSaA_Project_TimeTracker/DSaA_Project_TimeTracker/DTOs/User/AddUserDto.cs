using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSaA_Project_TimeTracker.DTOs.User
{
    public class AddUserDto
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; } // this needs to be hashed
        public int RoleId { get; set; }
        public string EmploymentStatus { get; set; }
    }
}
