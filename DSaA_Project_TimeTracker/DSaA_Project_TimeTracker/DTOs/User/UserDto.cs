using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSaA_Project_TimeTracker.Database.Entities;
using DSaA_Project_TimeTracker.DTOs.Task;
using DSaA_Project_TimeTracker.DTOs.UserHistory;

namespace DSaA_Project_TimeTracker.DTOs.User
{
    public class UserDto
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string EmploymentStatus { get; set; }
        public string RoleName { get; set; }
        public List<TaskToDoDto> Tasks { get; set; }
        public List<UserEventDto> UserHistory { get; set; }
    }
}
