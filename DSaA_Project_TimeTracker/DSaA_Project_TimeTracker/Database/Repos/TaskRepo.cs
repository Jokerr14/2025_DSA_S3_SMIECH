using AutoMapper;
using DSaA_Project_TimeTracker.Database.Entities;
using DSaA_Project_TimeTracker.DTOs.Task;
using Microsoft.EntityFrameworkCore;

namespace DSaA_Project_TimeTracker.Database.Repos;

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
    public async Task<IEnumerable<TaskToDoDto>?> GetAll()
    {
        using (var context = new TTDbContext())
        {
            var tasks = await context.Tasks
                .Include(t => t.Project)
                .Include(x => x.TaskAssignments)
                    .ThenInclude(x => x.User)
                .ToListAsync();

            if (tasks is null)
                return null;
            
            return _mapper.Map<List<TaskToDoDto>>(tasks);
        }
    }

    public async Task<TaskToDoDto?> GetById(int id)
    {
        using (var context = new TTDbContext())
        {
            var task = await context.Tasks
                .Include(t => t.Project)
                .Include(x => x.TaskAssignments)
                    .ThenInclude(x => x.User)
                .FirstOrDefaultAsync(x => x.Id == id);

            if (task is null)
                return null;
            
            var taskDto = _mapper.Map<TaskToDoDto>(task);
            return taskDto;
        }
    }

    public async Task Add(ModifyTaskToDoDto taskAddDto)
    {
        using (var context = new TTDbContext())
        {
            var task = _mapper.Map<TaskToDo>(taskAddDto);
            context.Tasks.Add(task);
            await context.SaveChangesAsync();
        }
    }

    public async Task UpdateById(int id, ModifyTaskToDoDto taskUpdateDto)
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
