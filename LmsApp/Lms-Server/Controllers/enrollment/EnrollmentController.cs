using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Model;
using RequestModel;
using ViewModel;
namespace Lms_Server.Controllers
{
    [RoutePrefix("api/Enrollment")]
    public class EnrollmentController : BaseController<Enrollment, EnrollmentRequestModel, EnrollmentViewModel>
    {
        public EnrollmentController(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
