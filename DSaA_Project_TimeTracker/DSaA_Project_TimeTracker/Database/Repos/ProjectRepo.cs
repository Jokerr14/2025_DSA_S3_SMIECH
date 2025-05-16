using AutoMapper;
using DSaA_Project_TimeTracker.Database.Entities;
using DSaA_Project_TimeTracker.DTOs.Project;
using Microsoft.EntityFrameworkCore;

namespace DSaA_Project_TimeTracker.Database.Repos;

public class ProjectRepo
{
    private readonly IMapper _mapper;

    public ProjectRepo()
    {
        var config = new MapperConfiguration(cfg =>
        {
            cfg.AddProfile<TTMappingProfile>();
        });

        _mapper = config.CreateMapper();
    }

    public async Task<List<ProjectDto>?> GetAll()
    {
        using (var context = new TTDbContext())
        {
            var projects = await context.Projects
                .Include(x => x.Tasks)
                .Include(x => x.TeamProjects)
                    .ThenInclude(x => x.Team)
                .ToListAsync();

            if (projects is null)
                return null;

            return _mapper.Map<List<ProjectDto>>(projects);
        }
    }

    public async Task<ProjectDto?> GetById(int id)
    {
        using (var context = new TTDbContext())
        {
            var project = await context.Projects
                .Include(x => x.Tasks)
                .Include(x => x.TeamProjects)
                    .ThenInclude(x => x.Team)
                .FirstOrDefaultAsync(x => x.Id == id);

            if (project is null)
                return null;

            return _mapper.Map<ProjectDto>(project);
        }
    }

    public async Task Add(ModifyProjectDto addProjectDto)
    {
        using (var context = new TTDbContext())
        {
            var project = _mapper.Map<Project>(addProjectDto);
            context.Projects.Add(project);
            await context.SaveChangesAsync();
        }
    }

    public async Task UpdateById(int id, ModifyProjectDto projectDto)
    {
        using (var context = new TTDbContext())
        {
            var project = await context.Projects.FirstOrDefaultAsync(x => x.Id == id);

            if (project is not null)
            {
                _mapper.Map(projectDto, project);
                await context.SaveChangesAsync();
            }
        }
    }

    public async Task DeleteById(int id)
    {
        using (var context = new TTDbContext())
        {
            var project = await context.Projects.FirstOrDefaultAsync(x => x.Id == id);

            if (project is not null)
            {
                context.Projects.Remove(project);
                await context.SaveChangesAsync();
            }
        }
    }
}
