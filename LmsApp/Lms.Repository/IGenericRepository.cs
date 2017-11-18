using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Repository
{
   public interface IGenericRepository<T>
        where T: Entity
    {
        bool Add(T entity);

        IQueryable<T> Get();

        T GetDetail(string id);

        bool Delete(string id);
    }
}
