﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Model;
using RequestModel;
using ViewModel;
namespace Lms_Server.Controllers.student
{
    [RoutePrefix("api/StudentContent")]
    public class StudentContentController : BaseController<StudentContent, StudentContentRequestModel, StudentContentViewModel>
    {
    }
}