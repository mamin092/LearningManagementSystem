using System;
using System.Data;
using System.Linq;
using Lms.Repository;
using Model;
using RequestModel;
using System.Linq.Expressions;

namespace Lms.Service
{
    //public class BaseService<T,Tr> where T : Entiry where Tr: BaseRequestModel<T>
    public class BaseService<T> where T : Entiry 
    {
        public IQueryable<T> SearcgQueryable(BaseRequestModel<T> requset)
        {

            var repository = new GenericRepository<T>();
            IQueryable<T> students = repository.Get();
            Expression<Func<T, bool>> expression = requset.GetExpression();
            students = students.Where(expression);
            students = requset.OrderByFunc()(students);
            students = requset.SkipAndTake(students);
            return students;

        }
    }
}
