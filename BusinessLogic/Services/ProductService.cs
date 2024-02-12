using DataAccess;
using DataAccess.Entities;
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

        public List<Phone> Filter(string name)
        {
            List<Phone> phones = _context.Phones.ToList();
            List<Phone> filteredPhones = new List<Phone>();
            for (int i = 0; i < phones.Count; i++)
            {
                if (phones[i].Name.Contains(name))
                {
                    filteredPhones.Add(phones[i]);
                }
            }
            return filteredPhones;
        }

        public Phone Get(int id)
        {
            return _context.Phones.Find(id);
        }

        public Phone[] GetAll()
        {
            return _context.Phones.ToArray();
        }

        public void Add(Phone phone)
        {
            _context.Phones.Add(phone);
            _context.SaveChanges();
        }

        public void Edit(Phone phone)
        {
            _context.Phones.Update(phone);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            Phone phone = Get(id);
            _context.Phones.Remove(phone);
            _context.SaveChanges();
        }
    }
}
