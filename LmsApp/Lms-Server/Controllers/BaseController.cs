using Lms.Service;
using Model;
using RequestModel;
using System;
using System.Web.Http;
using ViewModel;

namespace Lms_Server.Controllers
{
    public class BaseController<T, TR, TV> : ApiController where T : Entity where TR : BaseRequestModel<T> where TV : BaseViewModel<T>
    {
        [HttpPost]
        [Route("Add")]
        [ActionName("Add")]
        public IHttpActionResult Add(T model)
        {
            if (!ModelState.IsValid)
            {
                return this.BadRequest("bhai, please sob field fill up koren");
            }

            model.Id = Guid.NewGuid().ToString();
            var service = new BaseService<T, TR, TV>();
            var add = service.Add(model);
            return this.Ok(add);
        }
    }
}
