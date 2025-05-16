using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSaA_Project_TimeTracker.Database.Entities
{
    public class Project
    {
        public int Id { get; set; }
        public string ProjectName { get; set; }
        public string Description { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public virtual ICollection<TaskToDo> Tasks { get; set; }
        public virtual ICollection<TeamProject> TeamProjects { get; set; }
    }
}
