using System;
using System.Collections.Generic;

namespace HW._11.ReppositoryPattern
{
    interface IRepository<T> where T : class
    {
        List<T> GetAll();
        T GetByID(Guid id);
        void Create(T item);
        void Update(Guid id);
        void Delete(Guid id);
    }
}