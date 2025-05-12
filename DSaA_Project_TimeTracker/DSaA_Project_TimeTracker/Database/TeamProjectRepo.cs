using DSaA_Project_TimeTracker.Database.Entities;
using DSaA_Project_TimeTracker.DTOs.TeamProject;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using DSaA_Project_TimeTracker.Database;

namespace DSaA_Project_TimeTracker.Database
{
    public class TeamProjectRepo
    {
        private readonly IMapper _mapper;

        public TeamProjectRepo()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<TTMappingProfile>();
            });

            _mapper = config.CreateMapper();
        }

        public async Task<List<TeamProjectDto>> GetAll()
        {
            using (var context = new TTDbContext())
            {
                var links = await context.TeamProjects.ToListAsync();
                return _mapper.Map<List<TeamProjectDto>>(links);
            }
        }

        public async Task<TeamProjectDto> GetById(int teamId, int projectId)
        {
            using (var context = new TTDbContext())
            {
                var link = await context.TeamProjects
                    .FirstOrDefaultAsync(tp => tp.TeamId == teamId && tp.ProjectId == projectId);
                return _mapper.Map<TeamProjectDto>(link);
            }
        }

        public async System.Threading.Tasks.Task Add(TeamProjectDto createDto)
        {
            using (var context = new TTDbContext())
            {
                var exists = await context.TeamProjects.AnyAsync(tp =>
                    tp.TeamId == createDto.TeamId && tp.ProjectId == createDto.ProjectId);

                var link = _mapper.Map<TeamProject>(createDto);
                context.TeamProjects.Add(link);
                await context.SaveChangesAsync();
            }
        }

        public async System.Threading.Tasks.Task DeleteById(int teamId, int projectId)
        {
            using (var context = new TTDbContext())
            {
                var link = await context.TeamProjects
                    .FirstOrDefaultAsync(tp => tp.TeamId == teamId && tp.ProjectId == projectId);

                context.TeamProjects.Remove(link);
                await context.SaveChangesAsync();
            }
        }
    }
}
