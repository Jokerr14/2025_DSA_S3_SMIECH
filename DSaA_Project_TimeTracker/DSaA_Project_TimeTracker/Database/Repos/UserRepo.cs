using DSaA_Project_TimeTracker.Database.Entities;
using DSaA_Project_TimeTracker.DTOs.User;
using DSaA_Project_TimeTracker.Utils;
using Microsoft.EntityFrameworkCore;

namespace DSaA_Project_TimeTracker.Database.Repos;

public class UserRepo
{
    public async Task<IEnumerable<User>> GetAll()
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
                return new List<User>();

            return users;
        }
    }

    public async Task<User> GetById(int id)
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
                return new User();

            return user;
        }
    }

    public async Task Add(AddUserDto addUserDto)
    {
        var assignRepo = new AssignmentsRepo();
        using (var context = new TTDbContext())
        {
            var user = new User()
            {

                Username = addUserDto.Username,
                Email = addUserDto.Email,
                EmploymentStatus = addUserDto.EmploymentStatus,
                RoleId = 2,

            };

            user.PasswordHash = PasswordHasher.HashPasword(addUserDto.Password);

            await context.Users.AddAsync(user);
            await context.SaveChangesAsync();

            if (addUserDto.TeamId.HasValue)
            {
                await assignRepo.AssignMemberToTeam(addUserDto.TeamId.Value, user.Id);
            }
        }
    }

    public async Task UpdateById(int userId, AddUserDto updateUserDto)
    {
        using (var context = new TTDbContext())
        {
            var user = await context.Users.FirstOrDefaultAsync(x => x.Id == userId);

            if (user != null)
            {
                user.Username = updateUserDto.Username;
                user.Email = updateUserDto.Email;
                user.EmploymentStatus = updateUserDto.EmploymentStatus;
                user.PasswordHash = updateUserDto.Password;
                user.RoleId = updateUserDto.RoleId;
                context.Users.Update(user);
                await context.SaveChangesAsync();
            }
        }
    }

    public async Task DeleteById(int userId)
    {
        using (var context = new TTDbContext())
        {
            var user = await context.Users.FirstOrDefaultAsync(x => x.Id == userId);

            if (user != null)
            {
                context.Users.Remove(user);
                await context.SaveChangesAsync();
            }

        }
    }

    public async Task<User?> Login(LoginUserDto loginUserDto)
    {
        using (var context = new TTDbContext())
        {
            var user = await context.Users
                .Include(u => u.Role)
                .FirstOrDefaultAsync(u => u.Username == loginUserDto.Username);

            if (user == null)
                return null;

            if (!PasswordHasher.VerifyPassword(loginUserDto.Password, user.PasswordHash))
                return null;

            return user;
        }
    }
}
