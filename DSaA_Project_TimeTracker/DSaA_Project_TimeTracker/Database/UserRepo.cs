using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoMapper;
using AutoMapper.Extensions.ExpressionMapping;
using DSaA_Project_TimeTracker.Database.Entities;
using DSaA_Project_TimeTracker.DTOs;
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

        public Task<UserDto> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> Add(AddUserDto addUserDto)
        {
            throw new NotImplementedException();
        }

        public Task UpdateById(int id, UpdateUserDto updateUserDto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<UserDto?> Login(LoginUserDto loginUserDto)
        {
            using (var context = new TTDbContext())
            {
                // Try to find the user by email
                var user = await context.Users
                    .Include(u => u.Role) // include role navigation property
                    .FirstOrDefaultAsync(u => u.Username == loginUserDto.Username);

                if (user == null)
                    return null; 

                // add hashing passwords
                if (user.PasswordHash != loginUserDto.Password)
                    return null; 

                // Map entity to DTO and return it
                var userDto = _mapper.Map<UserDto>(user);
                return userDto;
            }
        }
    }
}
