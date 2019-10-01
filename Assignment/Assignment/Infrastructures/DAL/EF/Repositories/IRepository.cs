using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.Infrastructures.DAL.Repositories
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();
    }
}
