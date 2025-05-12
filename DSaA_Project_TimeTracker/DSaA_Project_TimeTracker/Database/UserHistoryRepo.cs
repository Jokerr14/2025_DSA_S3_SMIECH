using AutoMapper;
using DSaA_Project_TimeTracker.Database.Entities;
using DSaA_Project_TimeTracker.DTOs.User;
using DSaA_Project_TimeTracker.DTOs.UserHistory;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSaA_Project_TimeTracker.Database
{
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

        public async Task<IEnumerable<UserHistoryDto>> GetAll()
        {
            using (var context = new TTDbContext())
            {
                var histories = await context.UserHistory
                    .Include(u => u.User)
                    .ToListAsync();

                if (histories is null)
                {
                    return new List<UserHistoryDto>();
                }
                else
                {
                    var historiesDtos = _mapper.Map<List<UserHistoryDto>>(histories);
                    return historiesDtos;
                }
            }
        }

        public async Task<UserHistoryDto> GetById(int id)
        {
            using (var context = new TTDbContext())
            {
                var history = await context.UserHistory
                    .Include(u => u.User)
                    .FirstOrDefaultAsync(x => x.Id == id);
                if (history == null)
                {
                    return new UserHistoryDto();
                }
                else
                {
                    var historyDto = _mapper.Map<UserHistoryDto>(history);
                    return historyDto;
                }
            }
        }

        public async Task Add(ModifyUserHistoryDto createDto)
        {
            using (var context = new TTDbContext())
            {
                var userHistory = _mapper.Map<UserHistory>(createDto);
                context.UserHistory.Add(userHistory);
                await context.SaveChangesAsync();
            }
        }

        public async Task UpdateById(int id, ModifyUserHistoryDto userHistoryDto)
        {
            using (var context = new TTDbContext())
            {
                var userHistory = await context.UserHistory
                    .FirstOrDefaultAsync(uh => uh.Id == id);

                if (userHistory != null)
                {
                    _mapper.Map(userHistoryDto, userHistory);
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
}
