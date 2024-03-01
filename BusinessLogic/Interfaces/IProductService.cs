using Ardalis.Specification;
using Core.DTOs;
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
        public Task<List<PhoneDto>> GetAllWIthCateg();

        public Task<PhoneDto> Get(int id);

        public Task<List<Phone>> GetAll();

        public Task Add(Phone category);

        public Task Update(Phone category);

        public Task Delete(int categoryId);
    }
}
