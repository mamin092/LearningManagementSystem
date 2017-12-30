using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Model;
using RequestModel;
using ViewModel;
namespace Lms.Server.Controllers
{
    [RoutePrefix("api/EnrollmentQuery")]
    public class EnrollmentQueryController : BaseQueryController<Enrollment,EnrollmentRequestModel, EnrollmentViewModel>
    {
    }
}
