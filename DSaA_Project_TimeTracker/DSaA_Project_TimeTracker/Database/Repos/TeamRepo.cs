using AutoMapper;
using DSaA_Project_TimeTracker.Database.Entities;
using DSaA_Project_TimeTracker.DTOs.Team;
using Microsoft.EntityFrameworkCore;

namespace DSaA_Project_TimeTracker.Database.Repos;

public class TeamRepo
{
    private readonly IMapper _mapper;

    public TeamRepo()
    {
        var config = new MapperConfiguration(cfg =>
        {
            cfg.AddProfile<TTMappingProfile>();
        });

        _mapper = config.CreateMapper();
    }

    public async Task<IEnumerable<TeamDto>?> GetAll()
    {
        using (var context = new TTDbContext())
        {
            var teams = await context.Teams
                .Include(x => x.TeamProjects)
                    .ThenInclude(x => x.Project)
                .Include(x => x.TeamMembers)
                    .ThenInclude(x => x.User)
                .ToListAsync();

            if (teams is null)
                return null;

            var teamDtos = _mapper.Map<List<TeamDto>>(teams);
            return teamDtos;
        }
    }

    public async Task<TeamDto?> GetById(int id)
    {
        using (var context = new TTDbContext())
        {
            var team = await context.Teams
                .Include(x => x.TeamProjects)
                    .ThenInclude(x => x.Project)
                .Include(x => x.TeamMembers)
                    .ThenInclude(x => x.User)
                .FirstOrDefaultAsync(x => x.Id == id);

            if (team is null)
                return null;
            
            var teamDto = _mapper.Map<TeamDto>(team);
            return teamDto;
        }
    }

    public async Task Add(TeamDto addTeamDto)
    {
        using (var context = new TTDbContext())
        {
            var team = _mapper.Map<Team>(addTeamDto);

            context.Teams.Add(team);
            await context.SaveChangesAsync();
        }
    }

    public async Task UpdateById(int id, TeamDto teamDto)
    {
        using (var context = new TTDbContext())
        {
            var team = await context.Teams.FirstOrDefaultAsync(x => x.Id == id);

            _mapper.Map(teamDto, team);
            await context.SaveChangesAsync();
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
