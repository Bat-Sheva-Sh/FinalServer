using MyProject.Common.DTOs;
using MyProject.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Services.Interfaces
{
    public interface IUserService
    {
        Task<List<UserDTO>> GetListAsync();

        Task<UserDTO> GetByTzAsync(string userId);

        Task<UserDTO> AddAsync(UserDTO user);

        Task<UserDTO> UpdateAsync(UserDTO user);
    }
}
