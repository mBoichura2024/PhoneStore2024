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
    internal class ProductService : IProductService
    {
        private readonly IRepository<Phone> _phoneRepo;
        public ProductService(IRepository<Phone> phoneRepo)
        {
            _phoneRepo = phoneRepo;
        }

        public async Task<Phone> Get(int id)
        {
            return await _phoneRepo.GetByID(id);
        }

        public async Task<Phone[]> GetAll()
        {
            return await _phoneRepo.GetAll();
        }

        public async Task Add(Phone product)
        {
            await _phoneRepo.Insert(product);
            await _phoneRepo.Save();
        }

        public async Task Update(Phone product)
        {
            await _phoneRepo.Update(product);
            await _phoneRepo.Save();
        }

        public async Task Delete(int productId)
        {
            var product = await Get(productId);
            await _phoneRepo.Delete(product);
            await _phoneRepo.Save();
        }
    }
}
