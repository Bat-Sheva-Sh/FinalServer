using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Common.DTOs
{
    public class UserDTO
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
