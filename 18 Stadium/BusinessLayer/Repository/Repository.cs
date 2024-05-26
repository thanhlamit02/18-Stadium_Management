﻿using AutoMapper;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace BusinessLayer.Repository
{
    public class Repository<T> : IDisposable where T : class
    {
        protected readonly StadiumContext _db;
        internal DbSet<T> dbSet;
        private readonly MapperConfiguration config;
        protected readonly IMapper mapper;

        public Repository()
        {
            _db = new StadiumContext();
            dbSet = _db.Set<T>();
            config = new MapperConfiguration(cfg => cfg.AddProfile(new MappingConfig()));
            mapper = config.CreateMapper();
        }

        public void Add(T entity)
        {
            dbSet.Add(entity);
        }

        public T GetById(int id)
        {
            return dbSet.Find(id);
        }

        public IEnumerable<T> GetAll(Expression<Func<T, bool>> filter = null,
                              Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null)
        {
            IQueryable<T> query = dbSet;
            if (filter != null)
            {
                query = query.Where(filter);
            }

            if (orderBy != null)
            {
                return orderBy(query);
            }
            return query;
        }

        public T GetFirstOrDefault(Expression<Func<T, bool>> filter = null)
        {
            IQueryable<T> query = dbSet;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            return query.FirstOrDefault();
        }

        public void Remove(int id)
        {
            T entity = dbSet.Find(id);
            Remove(entity);
        }

        public void Remove(T entity)
        {
            dbSet.Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entity)
        {
            dbSet.RemoveRange(entity);
        }

        public void Save()
        {
            _db.SaveChanges();
        }

        public void Dispose()
        {
            _db.Dispose();
        }
    }
}
