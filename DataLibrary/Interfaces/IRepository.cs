using System;
using System.Collections.Generic;

namespace DataLibrary.Interfaces
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();
        T GetById(Guid id);
        int Insert(T entity);
        int Update(T entity);
        int Delete(Guid id);
    }
}
