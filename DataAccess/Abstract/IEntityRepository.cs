using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IEntityRepository<T> where T:class,IEntity
    {
        //generic constraint
        //class --> referans tip
        //Ientity --> IEntity olabilir veya Ientity implemente eden bir nesne olabilir
        //new() --> new'lenebilir olmalı
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);


    }
}
