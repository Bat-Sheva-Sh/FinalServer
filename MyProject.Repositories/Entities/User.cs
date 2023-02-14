using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Repositories.Entities
{
    public class User
    {
        public int Id { get; set; }

        public string UserId { get; set; }//tz

        public string Name { get; set; }

        public string FamilyName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Kind { get; set; }

        public string Hmo { get; set; }
    }
}
