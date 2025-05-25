using AutoMapper;
using DSaA_Project_TimeTracker.Database.Entities;
using DSaA_Project_TimeTracker.DTOs.Project;
using Microsoft.EntityFrameworkCore;

namespace DSaA_Project_TimeTracker.Database.Repos;

public class ProjectRepo
{
    public async Task<List<Project>> GetAll()
    {
        using (var context = new TTDbContext())
        {
            var projects = await context.Projects
                .Include(x => x.Tasks)
                .Include(x => x.TeamProjects)
                    .ThenInclude(x => x.Team)
                .ToListAsync();

            if (projects is null)
                return new List<Project>();

            return projects;
        }
    }

    public async Task<Project> GetById(int id)
    {
        using (var context = new TTDbContext())
        {
            var project = await context.Projects
                .Include(x => x.Tasks)
                .Include(x => x.TeamProjects)
                    .ThenInclude(x => x.Team)
                .FirstOrDefaultAsync(x => x.Id == id);

            if (project is null)
                return new Project();

            return project;
        }
    }

    public async Task Add(ModifyProjectDto addProjectDto)
    {
        using (var context = new TTDbContext())
        {
            var project = new Project()
            {
                ProjectName = addProjectDto.ProjectName,
                Description = addProjectDto.Description,
                StartDate = addProjectDto.StartDate,
                EndDate = addProjectDto.EndDate,
            };
            await context.Projects.AddAsync(project);
            await context.SaveChangesAsync();
        }
    }

    public async Task UpdateById(int projectId, ModifyProjectDto projectDto)
    {
        using (var context = new TTDbContext())
        {
            var project = await context.Projects.FirstOrDefaultAsync(x => x.Id == projectId);

            if (project is not null)
            {
                project.ProjectName = projectDto.ProjectName;
                project.Description = projectDto.Description;
                project.StartDate = projectDto.StartDate;
                project.EndDate = projectDto.EndDate;
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
