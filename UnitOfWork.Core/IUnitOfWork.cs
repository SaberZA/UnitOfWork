using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitOfWork.Core
{
    public interface IUnitOfWork<T>
    {        
        T GetRepository<R>();
    }    
}
