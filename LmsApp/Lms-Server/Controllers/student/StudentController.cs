using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Lms_Server.Controllers.student
{
    using System.Data.Entity;
    using Lms.Service;
    using Model;
    using RequestModel;
    using ViewModel;
    [RoutePrefix("api/Student")]
    public class StudentController : BaseController<Student, StudentRequestModel, StudentViewModel>
    {
        public StudentController(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
