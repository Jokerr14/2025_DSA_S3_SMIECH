using AutoMapper;
using DSaA_Project_TimeTracker.Database.Entities;
using DSaA_Project_TimeTracker.DTOs.Task;
using Microsoft.EntityFrameworkCore;

namespace DSaA_Project_TimeTracker.Database.Repos;

public class TaskRepo
{
    public async Task<IEnumerable<TaskToDo>> GetAll()
    {
        using (var context = new TTDbContext())
        {
            var tasks = await context.Tasks
                .Include(t => t.Project)
                .Include(x => x.TaskAssignments)
                    .ThenInclude(x => x.User)
                .ToListAsync();

            if (tasks is null)
                return new List<TaskToDo>();
            
            return tasks;
        }
    }

    public async Task<TaskToDo> GetById(int id)
    {
        using (var context = new TTDbContext())
        {
            var task = await context.Tasks
                .Include(t => t.Project)
                .Include(x => x.TaskAssignments)
                    .ThenInclude(x => x.User)
                .FirstOrDefaultAsync(x => x.Id == id);

            if (task is null)
                return new TaskToDo();
            
            return task;
        }
    }

    public async Task Add(int projectId, ModifyTaskToDoDto taskAddDto)
    {
        using (var context = new TTDbContext())
        {
            var task = new TaskToDo()
            {
                ProjectId = projectId,
                Title = taskAddDto.Title,
                Description = taskAddDto.Description,
                Status = taskAddDto.Status,
                DueDate = taskAddDto.DueDate,
            };
            await context.Tasks.AddAsync(task);
            await context.SaveChangesAsync();
        }
    }

    public async Task UpdateById(int taskId, ModifyTaskToDoDto taskUpdateDto)
    {
        using (var context = new TTDbContext())
        {
            var task = await context.Tasks.FirstOrDefaultAsync(x => x.Id == taskId);
            if (task != null)
            {
                task.Title = taskUpdateDto.Title;
                task.Description = taskUpdateDto.Description;
                task.Status = taskUpdateDto.Status;
                task.DueDate = taskUpdateDto.DueDate;
                await context.SaveChangesAsync();
            }
        }
    }

    public async Task DeleteById(int taskId)
    {
        using (var context = new TTDbContext())
        {
            var task = await context.Tasks.FirstOrDefaultAsync(x => x.Id == taskId);
            if (task != null)
            {
                context.Tasks.Remove(task);
                await context.SaveChangesAsync();
            }
        }
    }
}
