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
        public IQueryable<T> SearchQueryable(BaseRequestModel<T> request)
        {
            IQueryable<T> queryable = repository.Get();
            Expression<Func<T, bool>> expression = request.GetExpression();
            queryable = queryable.Where(expression);
            queryable = request.OrderByFunc()(queryable);
            queryable = request.SkipAndTake(queryable);
            queryable = request.IncludeParents(queryable);
            return queryable;
        }
        public bool Add(T model)
        {


            return repository.Add(model);
        }
        public List<Tv> Search(Tr request)
        {
            var queryable = SearchQueryable(request);
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
