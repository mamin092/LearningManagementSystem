using Lms.Service;
using Model;
using RequestModel;
using System.Web.Http;
using ViewModel;

namespace Lms_Server.Controllers
{
   
    public class BaseController<T, Tr, Tv> : ApiController where T : Entiry where Tr : BaseRequestModel<T> where Tv : BaseViewModel<T>
    {
        [HttpPost]
        [Route("Add")]
        [ActionName("Add")]
        public IHttpActionResult Add(T model)
        {
            if (ModelState.IsValid)
            {
                return this.BadRequest("Please all field fill up");
            }
            var service = new BaseService<T, Tr, Tv>();
            var add = service.Add(model);
            return this.Ok(add);
        }

    }
}
