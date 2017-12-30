
using Model;
using RequestModel;
using System.Web.Http;
using ViewModel;
using System.Data.Entity;

namespace Lms.Server.Controllers.teacher
{
    [RoutePrefix("api/Teacher")]
    public class TeacherController : BaseController<Teacher, TeacherRequestModel, TeacherViewModel>
    {
       
    }
}
