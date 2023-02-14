using MyProject.Repositories.Entities;
using System;

namespace MyProject.WebApi_.Models
{
    public class UserModel
    {
        public string UserId { get; set; }//tz

        public string Name { get; set; }

        public string FamilyName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Kind { get; set; }

        public string Hmo { get; set; }
    }
}
