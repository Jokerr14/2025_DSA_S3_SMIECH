using AutoMapper;
using DSaA_Project_TimeTracker.Database.Entities;
using DSaA_Project_TimeTracker.DTOs.User;
using DSaA_Project_TimeTracker.DTOs.Team;
using DSaA_Project_TimeTracker.DTOs.Project;

using DSaA_Project_TimeTracker.DTOs.Task;
using DSaA_Project_TimeTracker.DTOs.UserHistory;
using DSaA_Project_TimeTracker.DTOs.TaskAssignment;

namespace DSaA_Project_TimeTracker
{
    public class TTMappingProfile : Profile
    {
        public TTMappingProfile()
        {
            #region User Map

            CreateMap<User, UserDto>()
                .ForMember(m => m.RoleName, c => c.MapFrom(s => s.Role.RoleName));

            CreateMap<User, UpdateUserDto>();

            CreateMap<AddUserDto, User>();

            CreateMap<UpdateUserDto, User>();

            CreateMap<LoginUserDto, User>();

            #endregion 

            #region Team Map

            CreateMap<Team, TeamDto>();

            CreateMap<TeamDto, Team>()
                .ForMember(dest => dest.Id, opt => opt.Ignore());

            #endregion

            #region Project Map

            CreateMap<Team, TeamDto>()
                .ForMember(x => x.Members, x => x.MapFrom(y => y.TeamMembers.Select(z => z.User)));

            CreateMap<Project, ProjectDto>().ReverseMap();

            CreateMap<ModifyProjectDto, Project>();

            #endregion

            #region TaskProgram Map
            CreateMap<Project, ProjectDto>()
                .ForMember(dest => dest.Tasks, opt => opt.MapFrom(src => src.Tasks));


            CreateMap<TaskToDo, TaskToDoDto>();

            CreateMap<ModifyTaskToDoDto, TaskToDo>();

            #endregion

            #region UserHistory Map

            CreateMap<UserHistory, UserEventDto>();
            CreateMap<UserEventDto, UserHistory>();

            #endregion

            #region TaskAssignment Map

            CreateMap<TaskAssignment, TaskAssignmentDto>()
                .ForMember(dest => dest.Task.Title, opt => opt.MapFrom(src => src.TaskToDo.Title))
                .ForMember(dest => dest.User.Username, opt => opt.MapFrom(src => src.User.Username));

            CreateMap<ModifyTaskAssignmentDto, TaskAssignment>();

            #endregion

        }
    }
}
