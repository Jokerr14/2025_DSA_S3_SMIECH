using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSaA_Project_TimeTracker.Database.Entities;

public class Team
{
    public int Id { get; set; }
    public string TeamName { get; set; }
    public string Description { get; set; }
    public virtual ICollection<TeamMember> TeamMembers { get; set; }
    public virtual ICollection<TeamProject> TeamProjects { get; set; }

}

