using Model;
using RequestModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using ViewModel;

namespace Lms_Server.Controllers.course
{
    [RoutePrefix("api/CourseQuery")]
    public class CourseQueryController : BaseQueryController<Course, CourseRequestModel,CourseViewModel>
    {

    }
}
