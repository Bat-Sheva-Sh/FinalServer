using Microsoft.EntityFrameworkCore;
using MyProject.Repositories.Entities;
using MyProject.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Repositories.Repositories
{
    public class ChildRepository:IChildRepository
    {
        private readonly IContext _context;
        public ChildRepository(IContext context)
        {
            _context = context;
        }
        public async Task<Child> AddAsync(Child child)
        {
            //i thought to do this condition but then i realized i don't know what is this little app used for
            //and if it's for someone who wants to have every update as a new child this validation is not good.

            //if (_context.Children.Count(u => u.ChildId == childId) == 1)
            //    throw new Exception("משתמש קיים");
            _context.Children.Add(child);
            await _context.SaveChangesAsync();
            return child;
        }

        public async Task<List<Child>> GetAllAsync()
        {
            return await _context.Children.Include(p=>p.Parent).ToListAsync();
        }

        public async Task<Child> GetByTzAsync(string childId)
        {
            return await _context.Children.Include(p => p.Parent).FirstOrDefaultAsync(p => p.ChildId == childId);
        }

        public async Task<Child> UpdateAsync(Child child)
        {
            var updatedChild = _context.Children.Update(child);
            await _context.SaveChangesAsync();
            return updatedChild.Entity;
        }
    }
}
