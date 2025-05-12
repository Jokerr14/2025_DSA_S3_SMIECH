using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DSaA_Project_TimeTracker.Database.Entities;
using DSaA_Project_TimeTracker.DTOs.Project;
using Microsoft.EntityFrameworkCore;

namespace DSaA_Project_TimeTracker.Database.Repositories
{
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

        public async Task<List<ProjectDto>> GetAll()
        {
            using (var context = new TTDbContext())
            {
                var projects = await context.Projects.ToListAsync();
                return _mapper.Map<List<ProjectDto>>(projects);
            }
        }

        public async Task<ProjectDto> GetById(int id)
        {
            using (var context = new TTDbContext())
            {
                var project = await context.Projects.FirstOrDefaultAsync(x => x.Id == id);
                return _mapper.Map<ProjectDto>(project);
            }
        }

        public async System.Threading.Tasks.Task Add(ModifyProjectDto addProjectDto)
        {
            using (var context = new TTDbContext())
            {
                var project = _mapper.Map<Project>(addProjectDto);
                context.Projects.Add(project);
                await context.SaveChangesAsync();
            }
        }

        public async System.Threading.Tasks.Task UpdateById(int id, ModifyProjectDto projectDto)
        {
            using (var context = new TTDbContext())
            {
                var project = await context.Projects.FirstOrDefaultAsync(x => x.Id == id);

                _mapper.Map(projectDto, project);
                await context.SaveChangesAsync();
            }
        }

        public async System.Threading.Tasks.Task DeleteById(int id)
        {
            using (var context = new TTDbContext())
            {
                var project = await context.Projects.FirstOrDefaultAsync(x => x.Id == id);

                context.Projects.Remove(project);
                await context.SaveChangesAsync();
            }
        }
    }
}
