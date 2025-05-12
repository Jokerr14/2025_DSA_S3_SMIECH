using AutoMapper;
using DSaA_Project_TimeTracker.Database.Entities;
using DSaA_Project_TimeTracker.DTOs.TaskAssignment;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSaA_Project_TimeTracker.Database
{
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

        public async Task<IEnumerable<TaskAssignmentDto>> GetAll()
        {
            using (var context = new TTDbContext())
            {
                var taskAssignments = await context.TaskAssignments
                    .Include(ta => ta.TaskProgram)
                    .Include(ta => ta.User)
                    .ToListAsync();

                var taskAssignmentDtos = _mapper.Map<List<TaskAssignmentDto>>(taskAssignments);
                return taskAssignmentDtos;
            }
        }

        public async Task<TaskAssignmentDto> GetById(int taskId, int userId)
        {
            using (var context = new TTDbContext())
            {
                var taskAssignment = await context.TaskAssignments
                    .Include(ta => ta.TaskProgram)
                    .Include(ta => ta.User)
                    .FirstOrDefaultAsync(ta => ta.TaskId == taskId && ta.UserId == userId);

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
}
