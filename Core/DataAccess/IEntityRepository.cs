using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    //class -> referans tip olabilir demek
    //IEntity -> IEntity olabilir veya bunu implemente eden bir nesne olabilir
    //new() -> newlenebilir olmalı yani IEntity olmasını (soyut nesne olmasını) engellemiş olduk

    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null); //Filtreler yazabilmemizi sağlar
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
