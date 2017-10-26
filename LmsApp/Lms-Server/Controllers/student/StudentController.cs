using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Lms_Server.Controllers.student
{
    using Lms.Service;
    using Model;

    public class StudentController : ApiController
    {
        public IHttpActionResult Post(Student student)
        {
            if (ModelState.IsValid)
            {
                return this.BadRequest("Please all field fill up");
            }
            StudentService service = new StudentService();
           var add = service.Add(student);
            return this.Ok(add);
        }
    }
}
