using DataAccess;
using DataAccess.Entities;
<<<<<<< Updated upstream
=======
using Microsoft.EntityFrameworkCore;
>>>>>>> Stashed changes
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

<<<<<<< Updated upstream
        public Category Get(int id)
        {
            return _context.Categories.Find(id);
        }

        public Category[] GetAll()
        {
            return _context.Categories.ToArray();
        }

        public void Add(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
        }

        public void Edit(Category category)
        {
            _context.Categories.Update(category);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            Category category = Get(id);
            _context.Categories.Remove(category);
            _context.SaveChanges();
=======
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
>>>>>>> Stashed changes
        }
    }
}
