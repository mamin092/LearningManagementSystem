using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Lms.Service;
using RequestModel;

namespace Lms_Server.Controllers.teacher
{
    public class TeacherQueryController : ApiController
    {
        public IHttpActionResult Post(TeacherRequestModel request)
        {
            var service = new TeacherService();
            var teachers = service.Search(request);
            return this.Ok(teachers);
        }
    }
}
