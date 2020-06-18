using LaboratoryPosts.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaboratoryPosts.Data
{
    public class ImgpostService
    {

        private readonly LaboratoryDbContext _context;
        public ImgpostService(LaboratoryDbContext context)
        {
            this._context = context;
        }

        public async Task<List<Imgpost>> FindAllByIdAsync(int id)
        {
            return await _context.ImgPosts.Where(i => i.ID == id).ToListAsync();
        }
    }
}
