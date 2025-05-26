using AutoMapper;
using DSaA_Project_TimeTracker.Database.Entities;
using DSaA_Project_TimeTracker.DTOs.Team;
using Microsoft.EntityFrameworkCore;

namespace DSaA_Project_TimeTracker.Database.Repos;

public class TeamRepo
{
    public async Task<IEnumerable<Team>> GetAll()
    {
        using (var context = new TTDbContext())
        {
            var teams = await context.Teams
                .Include(x => x.TeamProjects)
                    .ThenInclude(x => x.Project)
                .Include(x => x.TeamMembers)
                    .ThenInclude(x => x.User)
                        .ThenInclude(x => x.Role)
                .Include(x => x.TeamMembers)
                    .ThenInclude(x => x.User)
                        .ThenInclude(x => x.UserEvents)
                .ToListAsync();

            if (teams is null)
                return new List<Team>();

            return teams;
        }
    }

    public async Task<Team> GetById(int id)
    {
        using (var context = new TTDbContext())
        {
            var team = await context.Teams
                .Include(x => x.TeamProjects)
                    .ThenInclude(x => x.Project)
                .Include(x => x.TeamMembers)
                    .ThenInclude(x => x.User)
                        .ThenInclude(x => x.Role)
                .Include(x => x.TeamMembers)
                    .ThenInclude(x => x.User)
                        .ThenInclude(x => x.UserEvents)
                .FirstOrDefaultAsync(x => x.Id == id);

            if (team is null)
                return new Team();
            
            return team;
        }
    }

    public async Task Add(ModifyTeamDto addTeamDto)
    {
        using (var context = new TTDbContext())
        {
            var team = new Team()
            {
                TeamName = addTeamDto.TeamName,
                Description = addTeamDto.Description,
            };

            await context.Teams.AddAsync(team);
            await context.SaveChangesAsync();
        }
    }

    public async Task UpdateById(int teamId, ModifyTeamDto teamDto)
    {
        using (var context = new TTDbContext())
        {
            var team = await context.Teams.FirstOrDefaultAsync(x => x.Id == teamId);

            if (team is not null)
            {
                team.TeamName = teamDto.TeamName;
                team.Description = teamDto.Description;
                await context.SaveChangesAsync();
            }
        }
    }

    public async Task DeleteById(int id)
    {
        using (var context = new TTDbContext())
        {
            var team = await context.Teams.FirstOrDefaultAsync(x => x.Id == id);

            context.Teams.Remove(team);
            await context.SaveChangesAsync();
        }
    }
}
