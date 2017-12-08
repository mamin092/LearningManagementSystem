using Lms.Service;
using Model;
using RequestModel;
using System;
using System.Web.Http;
using ViewModel;
using Lms.IdentityModel;

namespace Lms_Server.Controllers
{
    public class BaseController<T, TR, TV> : ApiController where T : Entity where TR : BaseRequestModel<T> where TV : BaseViewModel<T>
    {
        private BaseService<T, TR, TV> service;
        public BaseController(System.Data.Entity.DbContext dbContext)
        {
            service = new BaseService<T, TR, TV>(dbContext);
        }
        [HttpPost]
        [Route("Add")]
        [ActionName("Add")]
        public IHttpActionResult Add(T model)
        {
            if (!ModelState.IsValid)
            {
                return this.BadRequest(ModelState);
            }

            model.Id = Guid.NewGuid().ToString();
            var service = new BaseService<T, TR, TV>();
            var add = service.Add(model);
            return this.Ok(add);
        }
    }
}
