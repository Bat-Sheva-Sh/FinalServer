using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyProject.Common.DTOs;
using MyProject.WebApi_.Models;
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
    public class ChildController : ControllerBase
    {
        private readonly IChildService _childService;

        public ChildController(IChildService childService)
        {
            _childService = childService;
        }

        [HttpGet]
        public async Task<List<ChildDTO>> Get()
        {
            return await _childService.GetListAsync();
        }

        [HttpGet("{childId}")]
        public async Task<ActionResult<ChildDTO>> Get(string childId)
        {
            return await _childService.GetByTzAsync(childId);
        }

        [HttpPost]
        public async Task<ActionResult<ChildDTO>> Post([FromBody] ChildModel model)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            return await _childService.AddAsync(new ChildDTO() { 
                Name=model.Name,
                ChildId=model.ChildId,
                DateOfBirth=model.DateOfBirth, 
                ParentId = model.ParentId });
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<ChildDTO>> Put(int id, [FromBody] ChildModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            return await _childService.UpdateAsync(new ChildDTO()
            {
                Id = id,
                Name = model.Name,
                ChildId = model.ChildId,
                DateOfBirth = model.DateOfBirth,
                ParentId = model.ParentId
            });
        }
    }
}

