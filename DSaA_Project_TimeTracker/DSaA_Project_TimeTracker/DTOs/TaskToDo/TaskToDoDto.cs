using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSaA_Project_TimeTracker.DTOs.Project;

namespace DSaA_Project_TimeTracker.DTOs.Task
{
    public class TaskToDoDto()
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public DateTime? DueDate { get; set; }
        public ProjectDto Project { get; set; }
    }
}
