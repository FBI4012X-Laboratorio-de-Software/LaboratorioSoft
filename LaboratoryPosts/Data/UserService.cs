using LaboratoryPosts.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaboratoryPosts.Data
{
    public class UserService
    {
        private readonly LaboratoryDbContext _context;

        public UserService(LaboratoryDbContext context)
        {
            this._context = context;
        }

        public async Task<User> FindAsync(User user)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.Login.Equals(user.Login) && u.Password.Equals(user.Password));
        }
    }
}
