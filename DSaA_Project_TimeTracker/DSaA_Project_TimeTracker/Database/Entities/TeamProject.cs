using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSaA_Project_TimeTracker.Database.Entities
{
    public class TeamProject
    {
        public int TeamId { get; set; }
        public virtual Team Team { get; set; }

        public int ProjectId { get; set; }
        public virtual Project Project { get; set; }
    }
}
