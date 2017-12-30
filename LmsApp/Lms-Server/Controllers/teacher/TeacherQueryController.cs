using RequestModel;
using ViewModel;
using Model;
using System.Web.Http;

namespace Lms.Server.Controllers.teacher
{
    [RoutePrefix("api/TeacherQuery")]
    public class TeacherQueryController : BaseQueryController<Teacher, TeacherRequestModel, TeacherViewModel>
    {
       
    }
}
