using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Core.Interfaces;
using Ardalis.Specification;
using Ardalis.Specification.EntityFrameworkCore;

namespace Infrastructure
{
    internal class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        internal ApplicationDbContext _context;
        internal DbSet<TEntity> _dbSet;

        public Repository(ApplicationDbContext context)
        {
            this._context = context;
            this._dbSet = context.Set<TEntity>();
        }

        public virtual async Task Save()
        {
            await _context.SaveChangesAsync();
        }

        public virtual async Task<TEntity> GetItemBySpec(ISpecification<TEntity> specification)
        {
            return await ApplySpecification(specification).FirstOrDefaultAsync();
        }

        public virtual async Task<List<TEntity>> GetListBySpec(ISpecification<TEntity> specification)
        {
            return await ApplySpecification(specification).ToListAsync();
        }

        private IQueryable<TEntity> ApplySpecification(ISpecification<TEntity> specification)
        {
            var evaluator = new SpecificationEvaluator();
            return evaluator.GetQuery(_dbSet, specification);
        }

        public virtual async Task<TEntity> GetByID(object id)
        {
            return await _dbSet.FindAsync(id);
        }

        public virtual async Task<List<TEntity>> GetAll()
        {
            return await _dbSet.ToListAsync();
        }

        public virtual async Task Insert(TEntity entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public virtual async Task Delete(object id)
        {
            TEntity entityToDelete = await GetByID(id);
            Delete(entityToDelete);
        }

        public virtual async Task Delete(TEntity entityToDelete)
        {
            await Task.Run(() =>
            {
                if (_context.Entry(entityToDelete).State == EntityState.Detached)
                {
                    _dbSet.Attach(entityToDelete);
                }
                _dbSet.Remove(entityToDelete);
            });
        }

        public virtual async Task Update(TEntity entityToUpdate)
        {
            await Task.Run(() =>
            {
                _dbSet.Attach(entityToUpdate);
                _context.Entry(entityToUpdate).State = EntityState.Modified;
            });
        }
    }
}