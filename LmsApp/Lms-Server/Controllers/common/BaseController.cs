using Lms.Service;
using Microsoft.AspNet.Identity;
using Model;
using RequestModel;
using System;
using System.Web.Http;
using ViewModel;

namespace Lms.Server.Controllers
{
    public class BaseController<T, TR, TV> : ApiController where T : Entity where TR : BaseRequestModel<T> where TV : BaseViewModel<T>
    {
        private BaseService<T, TR, TV> service;
        public BaseController()
        {
            service = new BaseService<T, TR, TV>();
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
            model.ModifiedBy = User.Identity.GetUserName();
            model.ModifiedBy = User.Identity.GetUserName();
            model.Id = Guid.NewGuid().ToString();           
            var add = service.Add(model);
            return this.Ok(add);
        }
    }
}
