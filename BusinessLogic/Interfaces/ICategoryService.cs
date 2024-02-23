using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface ICategoryService
    {
        public Task<Category> Get(int id);

        public Task<Category[]> GetAll();

        public Task Add(Category category);

        public Task Update(Category category);

        public Task Delete(int categoryId);
    }
}
