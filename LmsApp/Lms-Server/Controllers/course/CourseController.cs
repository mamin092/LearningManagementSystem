using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Lms.Server.Controllers.course
{
   
    using Model;
    using RequestModel;
    using ViewModel;

    [RoutePrefix("api/Course")]
    public class CourseController : BaseController<Course, CourseRequestModel, CourseViewModel>
    {
      
    }
}
