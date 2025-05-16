using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSaA_Project_TimeTracker.Database.Entities
{
    public class TeamMember
    {
        public int TeamId { get; set; }
        public int UserId { get; set; }
        public virtual Team Team { get; set; }
        public virtual User User { get; set; }
    }
}
