using DataAccess;
using DataAccess.Entities;
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
        }
    }
}
