using LaboratoryPosts.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaboratoryPosts.Data
{
    public class PostService
    {
        private readonly LaboratoryDbContext _context;

        public PostService(LaboratoryDbContext context)
        {
            this._context = context;
        }

        public async Task<List<Post>> FindAllAsync()
        {
            return await _context.Posts.ToListAsync();
        }

        public async Task<Post> FindByIdAsync(int id)
        {
            return await _context.Posts.FirstOrDefaultAsync(p => p.ID == id);
        }
    }
}
