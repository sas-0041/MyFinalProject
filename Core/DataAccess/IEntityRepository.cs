﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    //core katmanları diğer katmanları referans almaz***
    //generic constraint
    //class:Referans Type
    //IEntity: IEntity olabilir veya implemente eden bir nesne olabilir
    //new(): new'lenebilir olmalı şartı koyar.
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
