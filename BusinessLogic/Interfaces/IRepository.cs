using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {
        public Task Save();

        public Task<TEntity> GetByID(object id);

        public Task<TEntity[]> GetAll();

        public Task Insert(TEntity entity);

        public Task Delete(object id);

        public Task Delete(TEntity entityToDelete);

        public Task Update(TEntity entityToUpdate);
    }
}
