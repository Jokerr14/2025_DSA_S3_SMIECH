using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSaA_Project_TimeTracker.DTOs.TaskAssignment
{
    public class TaskAssignmentDto
    {
        public int TaskId { get; set; }
        public int UserId { get; set; }
        public decimal? TimeSpentHours { get; set; }
        public string TaskTitle { get; set; }
        public string UserUsername { get; set; }
    }
}
