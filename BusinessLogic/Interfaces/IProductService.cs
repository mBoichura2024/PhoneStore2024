using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IProductService
    {
        public Task<Phone> Get(int id);

        public Task<Phone[]> GetAll();

        public Task Add(Phone category);

        public Task Update(Phone category);

        public Task Delete(int categoryId);
    }
}
