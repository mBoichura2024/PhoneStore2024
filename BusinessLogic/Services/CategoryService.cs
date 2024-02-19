using DataAccess;
using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
    public class CategoryService
    {
        ApplicationDbContext _context;
        public CategoryService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Category> Get(int id)
        {
            return await _context.Categories.FindAsync(id);
        }

        public async Task<Category[]> GetAll()
        {
            return await _context.Categories.ToArrayAsync();
        }

        public async Task Add(Category category)
        {
            await _context.Categories.AddAsync(category);
            await _context.SaveChangesAsync();
        }

        public async Task Update(int categoryId)
        {
            Category category = await Get(categoryId);
            _context.Categories.Update(category);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int productId)
        {
            Category category = await Get(productId);
            _context.Categories.Remove(category);
            await _context.SaveChangesAsync();
        }
    }
}
