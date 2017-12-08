using Lms.IdentityModel;
using RequestModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ViewModel;

namespace Lms_Server.Controllers
{
    [RoutePrefix("api/Resource")]
    public class ResourceController : BaseController<Resource, ResourceRequestModel, ResourceViewModel>
    {
        public ResourceController() : base (new ApplicationDbContext())
        {

        }
    }
}
