using Core.Entities;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    internal class CategoryService : ICategoryService
    {
        private readonly IRepository<Category> _categoryRepo;
        public CategoryService(IRepository<Category> categoryRepo)
        {
            _categoryRepo = categoryRepo;
        }

        public async Task<Category> Get(int id)
        {
            return await _categoryRepo.GetByID(id);
        }

        public async Task<List<Category>> GetAll()
        {
            return await _categoryRepo.GetAll();
        }

        public async Task Add(Category category)
        {
            await _categoryRepo.Insert(category);
            await _categoryRepo.Save();
        }

        public async Task Update(Category category)
        {
            await _categoryRepo.Update(category);
            await _categoryRepo.Save();
        }

        public async Task Delete(int categoryId)
        {
            var category = await Get(categoryId);
            await _categoryRepo.Delete(category);
            await _categoryRepo.Save();
        }
    }
}
