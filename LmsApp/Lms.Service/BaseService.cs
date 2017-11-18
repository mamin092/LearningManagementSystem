using System;
using System.Data;
using System.Linq;
using Lms.Repository;
using Model;
using RequestModel;
using System.Linq.Expressions;
using ViewModel;
using System.Collections.Generic;

namespace Lms.Service
{
    
    public class BaseService<T,Tr,Tv> where T : Entity where Tr: BaseRequestModel<T> where Tv: BaseViewModel<T>
    {
        GenericRepository<T> repository;
        public BaseService()
        {
            repository = new GenericRepository<T>();
        }
        public IQueryable<T> SearcgQueryable(BaseRequestModel<T> requset)
        {

           
            IQueryable<T> students = repository.Get();
            Expression<Func<T, bool>> expression = requset.GetExpression();
            students = students.Where(expression);
            students = requset.OrderByFunc()(students);
            students = requset.SkipAndTake(students);
            return students;

        }
        public bool Add(T model)
        {


            return repository.Add(model);
        }
        public List<Tv> Search(Tr request)
        {
            var queryable = SearcgQueryable(request);
            var list = queryable.ToList().ConvertAll(CreateVmInstance);
            return list;
        }

        private static Tv CreateVmInstance(T x)
        {
            return (Tv)Activator.CreateInstance(typeof(Tv), x); 
        }
        public Tv Detail(string id) 
        {
            T x = repository.GetDetail(id);
            if (x == null)
            {
                throw new ObjectNotFoundException();
            }

            var vm = CreateVmInstance(x);

            return vm;
        }

    }
}
