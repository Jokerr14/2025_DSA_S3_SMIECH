using AutoMapper;
using DSaA_Project_TimeTracker.Database.Entities;
using DSaA_Project_TimeTracker.DTOs.Team;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSaA_Project_TimeTracker.Database
{
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

        public async Task<IEnumerable<TeamDto>> GetAll()
        {
            using (var context = new TTDbContext())
            {
                var teams = await context.Teams.ToListAsync();

                if (teams is null)
                {
                    return new List<TeamDto>();
                }
                else
                {
                    var teamDtos = _mapper.Map<List<TeamDto>>(teams);
                    return teamDtos;
                }
            }
        }

        public async Task<TeamDto> GetById(int id)
        {
            using (var context = new TTDbContext())
            {
                var team = await context.Teams.FirstOrDefaultAsync(x => x.Id == id);

                if (team is null)
                {
                    return new TeamDto();
                }
                else
                {
                    var teamDto = _mapper.Map<TeamDto>(team);
                    return teamDto;
                }
            }
        }

        public async System.Threading.Tasks.Task Add(TeamDto addTeamDto)
        {
            using (var context = new TTDbContext())
            {
                var team = _mapper.Map<Team>(addTeamDto);

                context.Teams.Add(team);
                await context.SaveChangesAsync();
            }
        }

        public async System.Threading.Tasks.Task UpdateById(int id, TeamDto teamDto)
        {
            using (var context = new TTDbContext())
            {
                var team = await context.Teams.FirstOrDefaultAsync(x => x.Id == id);

                _mapper.Map(teamDto, team);
                await context.SaveChangesAsync();
            }
        }

        public async System.Threading.Tasks.Task DeleteById(int id)
        {
            using (var context = new TTDbContext())
            {
                var team = await context.Teams.FirstOrDefaultAsync(x => x.Id == id);

                context.Teams.Remove(team);
                await context.SaveChangesAsync();
            }
        }
    }
}
