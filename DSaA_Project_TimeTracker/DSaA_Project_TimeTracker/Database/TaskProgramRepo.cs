using AutoMapper;
using DSaA_Project_TimeTracker.Database.Entities;
using DSaA_Project_TimeTracker.DTOs.Task;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSaA_Project_TimeTracker.Database
{
    public class TaskRepo
    {
        private readonly IMapper _mapper;

        public TaskRepo()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<TTMappingProfile>();
            });
            _mapper = config.CreateMapper();
        }
        public async Task<IEnumerable<TaskProgramDto>> GetAll()
        {
            using (var context = new TTDbContext())
            {
                var tasks = await context.Tasks.Include(t => t.Project).ToListAsync();
                return _mapper.Map<List<TaskProgramDto>>(tasks);
            }
        }
        public async Task<TaskProgramDto> GetById(int id)
        {
            using (var context = new TTDbContext())
            {
                var task = await context.Tasks.Include(t => t.Project)
                                              .FirstOrDefaultAsync(x => x.Id == id);
                if(task == null)
                {
                    return new TaskProgramDto();
                }
                else
                {
                    var taskDto = _mapper.Map<TaskProgramDto>(task);
                    return taskDto;
                }

            }
        }

        public async Task Add(ModifyTaskProgramDto taskAddDto)
        {
            using (var context = new TTDbContext())
            {
                var task = _mapper.Map<TaskProgram>(taskAddDto);
                context.Tasks.Add(task);
                await context.SaveChangesAsync();
            }
        }
        public async Task UpdateById(int id, ModifyTaskProgramDto taskUpdateDto)
        {
            using (var context = new TTDbContext())
            {
                var task = await context.Tasks.FirstOrDefaultAsync(x => x.Id == id);
                if (task != null)
                {
                    _mapper.Map(taskUpdateDto, task);
                    await context.SaveChangesAsync();
                }
            }
        }
        public async Task DeleteById(int id)
        {
            using (var context = new TTDbContext())
            {
                var task = await context.Tasks.FirstOrDefaultAsync(x => x.Id == id);
                if (task != null)
                {
                    context.Tasks.Remove(task);
                    await context.SaveChangesAsync();
                }
            }
        }
    }
}
