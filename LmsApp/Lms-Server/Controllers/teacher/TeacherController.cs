using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Lms.Service;
using Model;

namespace Lms_Server.Controllers.teacher
{
    public class TeacherController : ApiController
    {
        public IHttpActionResult Post(Teacher teacher)
        {
            if (ModelState.IsValid)
            {
                return this.BadRequest("Please all field fill up");
            }
            TeacherService service = new TeacherService();
            var add = service.Add(teacher); 
            return this.Ok(add);
        }
    }
}
