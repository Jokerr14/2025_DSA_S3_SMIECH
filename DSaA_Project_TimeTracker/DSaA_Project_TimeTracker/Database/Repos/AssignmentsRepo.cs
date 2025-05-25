using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSaA_Project_TimeTracker.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace DSaA_Project_TimeTracker.Database.Repos
{
    public class AssignmentsRepo
    {
        public async Task AssignMemberToTeam(int teamId, int userId)
        {
            using (var context = new TTDbContext())
            {
                var teamMember = new TeamMember()
                {
                    TeamId = teamId,
                    UserId = userId
                };
                await context.TeamMembers.AddAsync(teamMember);
                await context.SaveChangesAsync();
            }
        }

        public async Task DeleteMemberFromTeam(int teamId, int userId)
        {
            using (var context = new TTDbContext())
            {
                var teamMember = await context.TeamMembers
                    .FirstOrDefaultAsync(ta => ta.TeamId == teamId && ta.UserId == userId);

                if (teamMember != null)
                {
                    context.TeamMembers.Remove(teamMember);
                    await context.SaveChangesAsync();
                }
            }
        }


        public async Task AssignProjectToTeam(int teamId, int projectId)
        {
            using (var context = new TTDbContext())
            {
                var teamProject = new TeamProject()
                {
                    TeamId = teamId,
                    ProjectId = projectId,
                };
                await context.TeamProjects.AddAsync(teamProject);
                await context.SaveChangesAsync();
            }
        }

        public async Task DeleteProjectFromTeam(int teamId, int projectId)
        {
            using (var context = new TTDbContext())
            {
                var teamProject = await context.TeamProjects
                    .FirstOrDefaultAsync(ta => ta.TeamId == teamId && ta.ProjectId == projectId);

                if (teamProject != null)
                {
                    context.TeamProjects.Remove(teamProject);
                    await context.SaveChangesAsync();
                }
            }
        }
    }
}
