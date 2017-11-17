using Lms.Service;
using Model;
using RequestModel;
using System.Web.Http;
using ViewModel;

namespace Lms_Server.Controllers
{
    public class BaseQueryController<T, Tr, Tv> : ApiController  where T: Entiry where Tr: BaseRequestModel<T> where Tv: BaseViewModel<T>
    {
        [Route("Search")]
        [ActionName("Search")]
        [HttpPost]
        public IHttpActionResult Search(Tr request)
        {
            var service = new BaseService<T, Tr, Tv>();
            var models = service.Search(request);
            return this.Ok(models);
        }
    }
}
