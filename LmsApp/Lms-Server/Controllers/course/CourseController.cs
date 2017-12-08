using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Lms_Server.Controllers.course
{
    using System.Data.Entity;
    using Model;
    using RequestModel;
    using ViewModel;

    [RoutePrefix("api/Course")]
    public class CourseController : BaseController<Course, CourseRequestModel, CourseViewModel>
    {
        public CourseController(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
