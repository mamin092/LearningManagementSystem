using Lms.Service;
using Model;
using RequestModel;
using System.Web.Http;
using ViewModel;

namespace Lms_Server.Controllers
{
    public class BaseQueryController<T, TR, TV> : ApiController where T : Entity where TR : BaseRequestModel<T> where TV : BaseViewModel<T>
    {
        [Route("Search")]
        [ActionName("Search")]
        [HttpPost]
        public IHttpActionResult Search(TR request)

        {
            var service = new BaseService<T, TR, TV>();
            var students = service.Search(request);
            return this.Ok(students);
        }
    }

}