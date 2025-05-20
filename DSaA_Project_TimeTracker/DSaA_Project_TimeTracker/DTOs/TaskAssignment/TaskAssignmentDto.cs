using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSaA_Project_TimeTracker.DTOs.Task;
using DSaA_Project_TimeTracker.DTOs.User;

namespace DSaA_Project_TimeTracker.DTOs.TaskAssignment
{
    public class TaskAssignmentDto
    {
        public decimal? TimeSpentHours { get; set; }
        public UserDto User { get; set; }
        public TaskToDoDto Task { get; set; }
    }
}
