using DSaA_Project_TimeTracker.DTOs.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSaA_Project_TimeTracker.DTOs.Team
{
    public class TeamDto
    {
        public int Id { get; set; }
        public string TeamName { get; set; }
        public string Description { get; set; }

        public List<UserDto> Members { get; set; }
    }
}
