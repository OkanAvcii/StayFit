﻿using Microsoft.EntityFrameworkCore.Query;
using StayFIT_CORE.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace StayFIT_DAL.Interfaces
{
    public interface IBaseRepo<T> where T : IEntity
    {
        int Create(T entity);
        int Update(T entity);
        int Delete(T entity);
        T GetById(int id);
        bool GetAny(Expression<Func<T, bool>> expression);
        IList<T> GetAll();
        IList<TResult> GetFilteredList<TResult>(
            Expression<Func<T, TResult>> select,
            Expression<Func<T, bool>> where = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            Func<IQueryable<T>, IIncludableQueryable<T, object>> join = null);
        TResult GetFilteredFirstOrDefault<TResult>(
            Expression<Func<T, TResult>> select,
            Expression<Func<T, bool>> where = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            Func<IQueryable<T>, IIncludableQueryable<T, object>> join = null);
    }
}
