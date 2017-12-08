
using Model;
using RequestModel;
using System.Web.Http;
using ViewModel;
using System.Data.Entity;

namespace Lms_Server.Controllers.teacher
{
    [RoutePrefix("api/Teacher")]
    public class TeacherController : BaseController<Teacher, TeacherRequestModel, TeacherViewModel>
    {
        public TeacherController(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
