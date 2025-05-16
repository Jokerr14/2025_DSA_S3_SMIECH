using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSaA_Project_TimeTracker.Database.Entities;

namespace DSaA_Project_TimeTracker.DTOs
{
    public class LoginUserDto
    {
        public string Username { get; set;}
        public string Password { get; set;}
    }
}
