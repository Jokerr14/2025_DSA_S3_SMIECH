using AutoMapper;
using DSaA_Project_TimeTracker.Database.Entities;
using DSaA_Project_TimeTracker.DTOs.UserHistory;
using Microsoft.EntityFrameworkCore;

namespace DSaA_Project_TimeTracker.Database.Repos;

public class UserHistoryRepo
{
    private readonly IMapper _mapper;
    public UserHistoryRepo()
    {
        var config = new MapperConfiguration(cfg =>
        {
            cfg.AddProfile<TTMappingProfile>();
        });

        _mapper = config.CreateMapper();
    }

    public async Task Add(UserEventDto userHistoryDto)
    {
        using (var context = new TTDbContext())
        {
            var userHistory = _mapper.Map<UserHistory>(userHistoryDto);
            context.UserHistory.Add(userHistory);
            await context.SaveChangesAsync();
        }
    }

    public async Task UpdateById(int id, UserEventDto modifyHistoryDto)
    {
        using (var context = new TTDbContext())
        {
            var userHistory = await context.UserHistory
                .FirstOrDefaultAsync(uh => uh.Id == id);

            if (userHistory != null)
            {
                _mapper.Map(modifyHistoryDto, userHistory);
                await context.SaveChangesAsync();
            }
        }
    }

    public async Task DeleteById(int id)
    {
        using (var context = new TTDbContext())
        {
            var userHistory = await context.UserHistory
                .FirstOrDefaultAsync(uh => uh.Id == id);

            if (userHistory != null)
            {
                context.UserHistory.Remove(userHistory);
                await context.SaveChangesAsync();
            }
        }
    }
}
