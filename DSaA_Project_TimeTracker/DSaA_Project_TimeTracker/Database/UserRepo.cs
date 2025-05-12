using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoMapper;
using AutoMapper.Extensions.ExpressionMapping;
using DSaA_Project_TimeTracker.Database.Entities;
using DSaA_Project_TimeTracker.DTOs.User;
using Microsoft.EntityFrameworkCore;

namespace DSaA_Project_TimeTracker.Database
{
    public class UserRepo
    {
        private readonly IMapper _mapper;

        public UserRepo()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<TTMappingProfile>();
            });

            _mapper = config.CreateMapper();
        }

        public async Task<IEnumerable<UserDto>> GetAll()
        {
            using (var context = new TTDbContext())
            {
                 var users = await context.Users
                    .Include(x => x.Role)
                    .ToListAsync();

                if (users is null)
                {
                    return new List<UserDto>();
                }
                else
                {
                    var userDtos = _mapper.Map<List<UserDto>>(users);
                    return userDtos;
                }

            }
        }

        public async Task<UserDto> GetById(int id)
        {
            using (var context = new TTDbContext())
            {
                var user = await context.Users
                    .Include(x => x.Role)
                    .FirstOrDefaultAsync(x => x.Id == id);

                if (user == null)
                {
                    return new UserDto();
                }
                else
                {
                    var userDto = _mapper.Map<UserDto>(user);
                    return userDto;
                }

            }
        }

        public async Task<ForUserUpdateDto> UpdateGetById(int id)
        {
            using (var context = new TTDbContext())
            {
                var user = await context.Users
                    .Include(x => x.Role)
                    .FirstOrDefaultAsync(x => x.Id == id);

                if (user == null)
                {
                    return new ForUserUpdateDto();
                }
                else
                {
                    var userDto = _mapper.Map<ForUserUpdateDto>(user);
                    return userDto;
                }

            }
        }

        public async System.Threading.Tasks.Task Add(AddUserDto addUserDto)
        {
            using (var context = new TTDbContext())
            {
                var user = _mapper.Map<User>(addUserDto);

                user.PasswordHash = addUserDto.PasswordHash;

                context.Users.Add(user);
                await context.SaveChangesAsync();
            }
        }

        public async System.Threading.Tasks.Task UpdateById(int id, UpdateUserDto updateUserDto)
        {
            using (var context = new TTDbContext())
            {
                var user = await context.Users.FirstOrDefaultAsync(x => x.Id == id);

                    _mapper.Map(updateUserDto, user);
                    await context.SaveChangesAsync();
            }
        }

        public async System.Threading.Tasks.Task DeleteById(int id)
        {
            using (var context = new TTDbContext())
            {
                var user = await context.Users.FirstOrDefaultAsync(x => x.Id == id);

                context.Users.Remove(user);
                await context.SaveChangesAsync();

            }
        }


    }
}
