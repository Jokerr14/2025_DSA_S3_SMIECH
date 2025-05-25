using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSaA_Project_TimeTracker.Database.Entities
{
    public class TaskAssignment
    {
        public int TaskId { get; set; }
        public int UserId { get; set; }
        public decimal TimeSpentHours { get; set; }

        public virtual TaskToDo TaskToDo { get; set; }
        public virtual User User { get; set; }
    }

}
