using AutoMapper;
using DSaA_Project_TimeTracker.Database.Entities;
using DSaA_Project_TimeTracker.DTOs.User;
using Microsoft.EntityFrameworkCore;

namespace DSaA_Project_TimeTracker.Database.Repos;

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

    public async Task<IEnumerable<UserDto>?> GetAll()
    {
        using (var context = new TTDbContext())
        {
             var users = await context.Users
                .Include(x => x.Role)
                .Include(x => x.UserEvents)
                .Include(x => x.TaskAssignments)
                    .ThenInclude(x => x.TaskToDo)
                .ToListAsync();

            if (users is null)
                return null;
          
            var userDtos = _mapper.Map<List<UserDto>>(users);
            return userDtos;
        }
    }

    public async Task<UserDto?> GetById(int id)
    {
        using (var context = new TTDbContext())
        {
            var user = await context.Users
            .Include(x => x.Role)
                .Include(x => x.UserEvents)
                .Include(x => x.TaskAssignments)
                    .ThenInclude(x => x.TaskToDo)
            .FirstOrDefaultAsync(u => u.Id == id);

            if (user is null)
                return null;
            
            var userDto = _mapper.Map<UserDto>(user);
            return userDto;
        }
    }

    public async Task Add(AddUserDto addUserDto)
    {
        using (var context = new TTDbContext())
        {
            var user = _mapper.Map<User>(addUserDto);

            //hash the password here
            user.PasswordHash = addUserDto.Password;

            await context.Users.AddAsync(user);
            await context.SaveChangesAsync();
        }
    }

    public async Task UpdateById(int id, UpdateUserDto updateUserDto)
    {
        using (var context = new TTDbContext())
        {
            var user = await context.Users.FirstOrDefaultAsync(x => x.Id == id);

            if (user != null)
            {
                user = _mapper.Map(updateUserDto, user);
                context.Users.Update(user);
                await context.SaveChangesAsync();
            }
        }
    }

    public async Task DeleteById(int id)
    {
        using (var context = new TTDbContext())
        {
            var user = await context.Users.FirstOrDefaultAsync(x => x.Id == id);

            if (user != null)
            {
                context.Users.Remove(user);
                await context.SaveChangesAsync();
            }

        }
    }

    public async Task<UserDto?> Login(LoginUserDto loginUserDto)
    {
        using (var context = new TTDbContext())
        {
            var user = await context.Users
                .Include(u => u.Role)
                .FirstOrDefaultAsync(u => u.Username == loginUserDto.Username);

            if (user == null)
                return null;

            if (user.PasswordHash != loginUserDto.Password)
                return null;

            var userDto = _mapper.Map<UserDto>(user);
            return userDto;
        }
    }
}
