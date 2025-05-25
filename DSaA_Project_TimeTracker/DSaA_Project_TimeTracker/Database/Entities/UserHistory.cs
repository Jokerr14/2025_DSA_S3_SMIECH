using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSaA_Project_TimeTracker.Database.Entities
{
    public class UserHistory
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string EventType { get; set; } = "";
        public DateTime? EventDate { get; set; }
        public string Notes { get; set; } = "";
        public virtual User User { get; set; }
    }
}
