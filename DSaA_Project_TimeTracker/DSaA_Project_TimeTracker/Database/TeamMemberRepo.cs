using AutoMapper;
using DSaA_Project_TimeTracker.Database.Entities;
using DSaA_Project_TimeTracker.DTOs.TeamMember;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DSaA_Project_TimeTracker.Database
{
    public class TeamMemberRepo
    {
        private readonly IMapper _mapper;

        public TeamMemberRepo()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<TTMappingProfile>();
            });

            _mapper = config.CreateMapper();
        }

        public async Task<IEnumerable<TeamMemberDto>> GetAll()
        {
            using (var context = new TTDbContext())
            {
                var teamMembers = await context.TeamMembers.ToListAsync();
                return _mapper.Map<List<TeamMemberDto>>(teamMembers);
            }
        }

        public async Task<TeamMemberDto> GetById(int teamId, int userId)
        {
            using (var context = new TTDbContext())
            {
                var teamMember = await context.TeamMembers
                    .FirstOrDefaultAsync(x => x.TeamId == teamId && x.UserId == userId);

                return _mapper.Map<TeamMemberDto>(teamMember);
            }
        }

        public async System.Threading.Tasks.Task Add(TeamMemberDto teamMemberDto)
        {
            using (var context = new TTDbContext())
            {
                var teamMember = _mapper.Map<TeamMember>(teamMemberDto);
                context.TeamMembers.Add(teamMember);
                await context.SaveChangesAsync();
            }
        }

        public async System.Threading.Tasks.Task UpdateById(int teamId, int userId, TeamMemberDto updatedDto)
        {
            using (var context = new TTDbContext())
            {
                var teamMember = await context.TeamMembers
                    .FirstOrDefaultAsync(x => x.TeamId == teamId && x.UserId == userId);

                _mapper.Map(updatedDto, teamMember);
                await context.SaveChangesAsync();
            }
        }

        public async System.Threading.Tasks.Task DeleteById(int teamId, int userId)
        {
            using (var context = new TTDbContext())
            {
                var teamMember = await context.TeamMembers
                    .FirstOrDefaultAsync(x => x.TeamId == teamId && x.UserId == userId);

                context.TeamMembers.Remove(teamMember);
                await context.SaveChangesAsync();
            }
        }
    }
}
