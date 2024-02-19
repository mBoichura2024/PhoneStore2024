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
    public class ProductService
    {
        ApplicationDbContext _context;
        public ProductService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Phone> Get(int id)
        {
            return await _context.Phones.FindAsync(id);
        }

        public async Task<Phone[]> GetAll()
        {
            return await _context.Phones.ToArrayAsync();
        }

        public async Task Add(Phone product)
        {
            await _context.Phones.AddAsync(product);
            await _context.SaveChangesAsync();
        }

        public async Task Update(Phone product)
        {
            await Task.Run(() =>//TODO remove async
            {
                _context.Phones.Update(product);
            });

            await _context.SaveChangesAsync();
        }

        public async Task Delete(int productId)
        {
            Phone product = await Get(productId);
            _context.Phones.Remove(product);
            await _context.SaveChangesAsync();
        }
    }
}
