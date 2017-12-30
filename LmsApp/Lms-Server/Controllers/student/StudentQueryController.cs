using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Lms.Service;
using RequestModel;
using ViewModel;
using Model;

namespace Lms.Server.Controllers.student
{
    [RoutePrefix("api/StudentQuery")]
    public class StudentQueryController : BaseQueryController <Student,StudentRequestModel,StudentViewModel>
    {

       
    }
}
