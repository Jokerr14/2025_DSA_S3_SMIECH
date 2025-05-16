using AutoMapper;
using DSaA_Project_TimeTracker.Database.Entities;
using DSaA_Project_TimeTracker.DTOs.TaskAssignment;
using Microsoft.EntityFrameworkCore;

namespace DSaA_Project_TimeTracker.Database.Repos;

public class TaskAssignmentRepo
{
    private readonly IMapper _mapper;

    public TaskAssignmentRepo()
    {
        var config = new MapperConfiguration(cfg =>
        {
            cfg.AddProfile<TTMappingProfile>();
        });

        _mapper = config.CreateMapper();
    }

    public async Task<IEnumerable<TaskAssignmentDto>?> GetAll()
    {
        using (var context = new TTDbContext())
        {
            var taskAssignments = await context.TaskAssignments
                .Include(ta => ta.TaskToDo)
                .Include(ta => ta.User)
                .ToListAsync();

            if (taskAssignments is null)
                return null;

            var taskAssignmentDtos = _mapper.Map<List<TaskAssignmentDto>>(taskAssignments);
            return taskAssignmentDtos;
        }
    }

    public async Task<TaskAssignmentDto?> GetById(int taskId, int userId)
    {
        using (var context = new TTDbContext())
        {
            var taskAssignment = await context.TaskAssignments
                .Include(ta => ta.TaskToDo)
                .Include(ta => ta.User)
                .FirstOrDefaultAsync(ta => ta.TaskId == taskId && ta.UserId == userId);

            if (taskAssignment is null)
                return null;

            return _mapper.Map<TaskAssignmentDto>(taskAssignment);
        }
    }

    public async Task Add(ModifyTaskAssignmentDto createDto)
    {
        using (var context = new TTDbContext())
        {
            var taskAssignment = _mapper.Map<TaskAssignment>(createDto);
            context.TaskAssignments.Add(taskAssignment);
            await context.SaveChangesAsync();
        }
    }

    public async Task Update(int taskId, int userId, ModifyTaskAssignmentDto updateDto)
    {
        using (var context = new TTDbContext())
        {
            var taskAssignment = await context.TaskAssignments
                .FirstOrDefaultAsync(ta => ta.TaskId == taskId && ta.UserId == userId);

            if (taskAssignment != null)
            {
                _mapper.Map(updateDto, taskAssignment);
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
