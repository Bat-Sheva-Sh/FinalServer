using Microsoft.EntityFrameworkCore;
using MyProject.Repositories.Entities;
using MyProject.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Repositories.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly IContext _context;
        public UserRepository(IContext context)
        {
            _context = context;
        }
        public async Task<User> AddAsync(User user)
        {
            //i thought to do this condition but then i realized i don't know what is this little app used for
            //and if it's for someone who wants to have every update as a new person this validation is not good  so i deledted it.
            //if (_context.Users.Count(u => u.UserId == userId) == 1)
            //    throw new Exception("משתמש קיים");
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return user;
        }

        public async Task<List<User>> GetAllAsync()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<User> GetByTzAsync(string userId)
        {
            return await _context.Users.FirstOrDefaultAsync(p => p.UserId == userId);
        }

        public async Task<User> UpdateAsync(User user)
        {
            var updatedUser = _context.Users.Update(user);
            await _context.SaveChangesAsync();
            return updatedUser.Entity;
        }
    }
}
