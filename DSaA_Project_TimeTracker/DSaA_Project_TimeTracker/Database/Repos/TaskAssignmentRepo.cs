using AutoMapper;
using DSaA_Project_TimeTracker.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace DSaA_Project_TimeTracker.Database.Repos;

public class TaskAssignmentRepo
{
    public async Task<IEnumerable<TaskAssignment>> GetAll()
    {
        using (var context = new TTDbContext())
        {
            var taskAssignments = await context.TaskAssignments
                .Include(ta => ta.TaskToDo)
                .Include(ta => ta.User)
                .ToListAsync();

            if (taskAssignments is null)
                return new List<TaskAssignment>();

            return taskAssignments;
        }
    }

    public async Task<TaskAssignment> GetById(int taskId, int userId)
    {
        using (var context = new TTDbContext())
        {
            var taskAssignment = await context.TaskAssignments
                .Include(ta => ta.TaskToDo)
                .Include(ta => ta.User)
                .FirstOrDefaultAsync(ta => ta.TaskId == taskId && ta.UserId == userId);

            if (taskAssignment is null)
                return new TaskAssignment();

            return taskAssignment;
        }
    }

    public async Task Add(int taskId, int userId)
    {
        using (var context = new TTDbContext())
        {
            var taskAssignment = new TaskAssignment() { TaskId = taskId, UserId = userId };
            await context.TaskAssignments.AddAsync(taskAssignment);
            await context.SaveChangesAsync();
        }
    }

    public async Task Update(int taskId, int userId, decimal timeHoursSpent)
    {
        using (var context = new TTDbContext())
        {
            var taskAssignment = await context.TaskAssignments
                .FirstOrDefaultAsync(ta => ta.TaskId == taskId && ta.UserId == userId);

            if (taskAssignment != null)
            {
                taskAssignment.TimeSpentHours = timeHoursSpent;
                await context.SaveChangesAsync();
            }
        }
    }

    public async Task Delete(int taskId, int userId)
    {
        using (var context = new TTDbContext())
        {
            var taskAssignment = await context.TaskAssignments
                .FirstOrDefaultAsync(ta => ta.TaskId == taskId && ta.UserId == userId);

            if (taskAssignment != null)
            {
                context.TaskAssignments.Remove(taskAssignment);
                await context.SaveChangesAsync();
            }
        }
    }
}
