using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyProject.WebApi_.Models;
using MyProject.Common.DTOs;
using MyProject.Repositories.Entities;
using MyProject.Repositories.Interfaces;
using MyProject.Repositories.Repositories;
using MyProject.Services.Interfaces;
using MyProject.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.WebApi_.Controllers
{
    [Route("/[controller]")]//api
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<List<UserDTO>> Get()
        {
            return await _userService.GetListAsync();
        }

        [HttpGet("{userId}")]
        public async Task<ActionResult<UserDTO>> Get(string userId)
        {
            return await _userService.GetByTzAsync(userId);
        }

        [HttpPost]
        public async Task<ActionResult<UserDTO>> Post([FromBody] UserModel model)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            return await _userService.AddAsync(new UserDTO() { 
                Name=model.Name,
                UserId=model.UserId,
                DateOfBirth=model.DateOfBirth,
                FamilyName = model.FamilyName,
                Kind = model.Kind,
                Hmo = model.Hmo });
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<UserDTO>> Put(int id, [FromBody] UserModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            return await _userService.UpdateAsync(new UserDTO()
            {
                Id=id,
                Name=model.Name,
                UserId=model.UserId,
                DateOfBirth=model.DateOfBirth,
                FamilyName=model.FamilyName,                  
                Kind = model.Kind,
                Hmo = model.Hmo
            });
        }
    }
}

