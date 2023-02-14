using MyProject.Common.DTOs;
using MyProject.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Services.Interfaces
{
    public interface IChildService
    {
        Task<List<ChildDTO>> GetListAsync();

        Task<ChildDTO> GetByTzAsync(string childId);

        Task<ChildDTO> AddAsync(ChildDTO child);

        Task<ChildDTO> UpdateAsync(ChildDTO child);
    }
}
