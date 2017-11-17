using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Lms.Service;
using RequestModel;

namespace Lms_Server.Controllers.student
{
    public class StudentQueryController : ApiController
    {

        public IHttpActionResult Post(StudentRequestModel request)
        {
            StudentService service = new StudentService();
            var students = service.Search(request);
            return this.Ok(students);
        }
    }
}
