using AutoMapper;
using DSaA_Project_TimeTracker.Database.Entities;
using DSaA_Project_TimeTracker.DTOs.Role;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSaA_Project_TimeTracker.Database
{
    public class RoleRepo
    {
        private readonly IMapper _mapper;

        public RoleRepo()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<TTMappingProfile>();
            });

            _mapper = config.CreateMapper();
        }

        public async Task<IEnumerable<RoleDto>> GetAll()
        {
            using (var context = new TTDbContext())
            {
                var roles = await context.Roles
                    .ToListAsync();

                if(roles is null)
                {
                    return new List<RoleDto>();
                }
                else
                {
                    var roleDtos = _mapper.Map<List<RoleDto>>(roles);
                    return roleDtos;
                }
            }
        }

        public async Task<RoleDto> GetById(int id)
        {
            using (var context = new TTDbContext())
            {
                var role = await context.Roles.FirstOrDefaultAsync(x => x.Id == id);

                if (role == null)
                {
                    return new RoleDto();
                }
                else
                {
                    var roleDto = _mapper.Map<RoleDto>(role);
                    return roleDto;
                }
            }
        }

        public async System.Threading.Tasks.Task Add(RoleDto roleDto)
        {
            using (var context = new TTDbContext())
            {
                var role = _mapper.Map<Role>(roleDto);

                context.Roles.Add(role);
                await context.SaveChangesAsync();
            }
        }

        public async System.Threading.Tasks.Task UpdateById(int id, RoleDto roleDto)
        {
            using (var context = new TTDbContext())
            {
                var role = await context.Roles.FirstOrDefaultAsync(x=>x.Id == id);

                _mapper.Map(roleDto, role);
                await context.SaveChangesAsync();
            }
        }

        public async System.Threading.Tasks.Task DeleteById(int id)
        {
            using (var context = new TTDbContext())
            {
                var role = await context.Roles.FirstOrDefaultAsync(x => x.Id == id);

                context.Roles.Remove(role);
                await context.SaveChangesAsync();   
            }
        }
    }
}
