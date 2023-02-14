using AutoMapper;
using MyProject.Common.DTOs;
using MyProject.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Services
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            //child
            CreateMap<Child, ChildDTO>().ReverseMap();
            //user
            CreateMap<User, UserDTO>().ReverseMap();


        }
    }
}
