using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSaA_Project_TimeTracker.Database.Entities;

public class TaskProgram
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Status {  get; set; }
    public DateTime? DueDate { get; set; }
    public int ProjectId { get; set; }
    public virtual Project Project { get; set; }
    public virtual ICollection<TaskAssignment> TaskAssignments { get; set; }

}
