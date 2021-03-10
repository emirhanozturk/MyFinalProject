﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    // generic constraint--> Generic kısıtlama
    //class: aşağıdaki referans tip olabilir demek
    //IEntity olabilir ya da IEntity implemente eden bir nesne olabilir.
    //new(): new'lenebilir olmalı.IEntity new'lenemeyeceği için olamaz.
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
