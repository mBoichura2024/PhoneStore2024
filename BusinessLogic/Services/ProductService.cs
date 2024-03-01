using AutoMapper;
using Core.DTOs;
using Core.Entities;
using Core.Entities.Specifications;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    internal class ProductService : IProductService
    {
        private readonly IRepository<Phone> _phoneRepo;
        private readonly IMapper _mapper;
        public ProductService(IRepository<Phone> phoneRepo,
                              IMapper mapper)
        {
            _phoneRepo = phoneRepo;
            _mapper = mapper;
        }

        public async Task<PhoneDto> Get(int id)
        {
            var phone = await _phoneRepo.GetByID(id);
            return _mapper.Map<PhoneDto>(phone);
        }

        public async Task<List<PhoneDto>> GetAllWIthCateg()
        {
            var phones = await _phoneRepo.GetListBySpec(new Phones.AllWithCateg());
            return _mapper.Map<List<PhoneDto>>(phones);



            //TODO:this's for example: return await _phoneRepo.GetListBySpec(new Phones.AllWithPrice(300, 600));
        }

        public async Task<List<Phone>> GetAll()
        {
            //return await _phoneRepo.GetListBySpec(new Phones.All());
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
