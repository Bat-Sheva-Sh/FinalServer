using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Common.DTOs
{
    public class ChildDTO
    {
        public int Id { get; set; }
        public string ChildId { get; set; }//tz
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        [ForeignKey("Parent")]
        public int ParentId { get; set; }
        public UserDTO Parent { get; set; }
    }
}
