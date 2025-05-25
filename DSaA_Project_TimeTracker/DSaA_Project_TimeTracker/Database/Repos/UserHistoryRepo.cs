using AutoMapper;
using DSaA_Project_TimeTracker.Database.Entities;
using DSaA_Project_TimeTracker.DTOs.UserHistory;
using Microsoft.EntityFrameworkCore;

namespace DSaA_Project_TimeTracker.Database.Repos;

public class UserHistoryRepo
{
    public async Task Add(int userId, UserEventDto userHistoryDto)
    {
        using (var context = new TTDbContext())
        {
            var userHistory = new UserHistory()
            {
                UserId = userId,
                EventType = userHistoryDto.EventType,
                EventDate = userHistoryDto.EventDate,
                Notes = userHistoryDto.Notes
            };
            context.UserHistory.Add(userHistory);
            await context.SaveChangesAsync();
        }
    }

    public async Task UpdateById(int eventId, UserEventDto modifyHistoryDto)
    {
        using (var context = new TTDbContext())
        {
            var userHistory = await context.UserHistory
                .FirstOrDefaultAsync(uh => uh.Id == eventId);

            if (userHistory != null)
            {
                userHistory.EventType = modifyHistoryDto.EventType;
                userHistory.EventDate = modifyHistoryDto.EventDate;
                userHistory.Notes = modifyHistoryDto.Notes;
                await context.SaveChangesAsync();
            }
        }
    }

    public async Task DeleteById(int eventId)
    {
        using (var context = new TTDbContext())
        {
            var userHistory = await context.UserHistory
                .FirstOrDefaultAsync(uh => uh.Id == eventId);

            if (userHistory != null)
            {
                context.UserHistory.Remove(userHistory);
                await context.SaveChangesAsync();
            }
        }
    }
}
