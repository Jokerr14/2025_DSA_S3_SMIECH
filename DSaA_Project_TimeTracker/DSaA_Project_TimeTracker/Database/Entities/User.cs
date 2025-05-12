using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSaA_Project_TimeTracker.Database.Entities;

public class User
{
    public int Id { get; set; }
    public string Username { get; set; }
    public string Email { get; set; }
    public string EmploymentStatus { get; set; }
    public string PasswordHash { get; set; }

    public int RoleId { get; set; }
    public virtual Role Role { get; set; }

    public virtual ICollection<TeamMember> TeamMembers { get; set; }
    public virtual ICollection<UserHistory> UserHistories { get; set; }
    public virtual ICollection<TaskAssignment> TaskAssignments { get; set; }
}
