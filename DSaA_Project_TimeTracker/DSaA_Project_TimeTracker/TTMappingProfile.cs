using AutoMapper;
using DSaA_Project_TimeTracker.Database.Entities;
using DSaA_Project_TimeTracker.DTOs.User;
using DSaA_Project_TimeTracker.DTOs.Role;
using DSaA_Project_TimeTracker.DTOs.Team;
using DSaA_Project_TimeTracker.DTOs.Project;
using DSaA_Project_TimeTracker.DTOs.TeamProject;
using DSaA_Project_TimeTracker.DTOs.TeamMember;
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

            CreateMap<User, ForUserUpdateDto>();

            CreateMap<AddUserDto, User>();

            CreateMap<UpdateUserDto, User>();

            #endregion 

            #region Role Map

            CreateMap<Role, RoleDto>();

            CreateMap<RoleDto, Role>()
                .ForMember(dest => dest.Id, opt => opt.Ignore());

            #endregion

            #region Team Map

            CreateMap<Team, TeamDto>();

            CreateMap<TeamDto, Team>()
                .ForMember(dest => dest.Id, opt => opt.Ignore());

            #endregion

            #region Project Map

            CreateMap<Project, ProjectDto>().ReverseMap();

            CreateMap<ModifyProjectDto, Project>();

            #endregion

            #region TeamProject Map

            CreateMap<TeamProject, TeamProjectDto>();

            CreateMap<TeamProjectDto, TeamProject>();

            #endregion

            #region TeamMember Map
            CreateMap<TeamMember, TeamMemberDto>().ReverseMap();

            #endregion

            #region TaskProgram Map

            CreateMap<TaskProgram, TaskProgramDto>()
                .ForMember(dest => dest.ProjectId, opt => opt.MapFrom(src => src.ProjectId));

            CreateMap<ModifyTaskProgramDto, TaskProgram>();

            #endregion

            #region UserHistory Map

            CreateMap<UserHistory, UserHistoryDto>();
            CreateMap<ModifyUserHistoryDto, UserHistory>();
            CreateMap<UserHistoryDto, UserHistory>();

            #endregion

            #region TaskAssignment Map

            CreateMap<TaskAssignment, TaskAssignmentDto>()
                .ForMember(dest => dest.TaskTitle, opt => opt.MapFrom(src => src.TaskProgram.Title))
                .ForMember(dest => dest.UserUsername, opt => opt.MapFrom(src => src.User.Username));

            CreateMap<ModifyTaskAssignmentDto, TaskAssignment>();

            #endregion

        }
    }
}
