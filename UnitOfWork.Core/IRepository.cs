using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitOfWork.Core
{
    public interface IRepository<T>
    {
        T AddEntity(T entity);
        void RemoveEntity(T entity);
        T Find(int id);
        IEnumerable<T> FindAll();
    }
}
