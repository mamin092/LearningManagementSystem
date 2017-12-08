using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Model;
using RequestModel;
using ViewModel;
namespace Lms_Server.Controllers
{
    [RoutePrefix("api/Content")]
    public class ContentController : BaseController<Content, ContentRequestModel, ContentViewModel>
    {
        public ContentController(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
