using Lms.Service;
using Model;
using RequestModel;
using System.Web.Http;
using ViewModel;

namespace Lms.Server.Controllers
{
    public class BaseQueryController<T, TR, TV> : ApiController where T : Entity where TR : BaseRequestModel<T> where TV : BaseViewModel<T>
    {

        private BaseService<T, TR, TV> service;

        public BaseQueryController()
        {
            service = new BaseService<T, TR, TV>();
        }

        [Route("Search")]
        [ActionName("Search")]
        [HttpPost]
        public IHttpActionResult Search(TR request)

        {
            var students = service.Search(request);
            return this.Ok(students);
        }
    }

}