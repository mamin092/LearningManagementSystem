
using Model;
using RequestModel;
using System.Web.Http;
using ViewModel;

namespace Lms_Server.Controllers.teacher
{
    [RoutePrefix("api/Teacher")]
    public class TeacherController : BaseController<Teacher,TeacherRequestModel,TeacherViewModel>
    {
       
    }
}
