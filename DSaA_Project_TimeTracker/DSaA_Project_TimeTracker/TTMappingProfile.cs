using AutoMapper;
using DSaA_Project_TimeTracker.Database.Entities;
using DSaA_Project_TimeTracker.DTOs;

namespace DSaA_Project_TimeTracker
{
    public class TTMappingProfile : Profile
    {
        public TTMappingProfile()
        {
            CreateMap<User, UserDto>()
                .ForMember(m => m.RoleName, c => c.MapFrom(s => s.Role.RoleName));
        }
    }
}
