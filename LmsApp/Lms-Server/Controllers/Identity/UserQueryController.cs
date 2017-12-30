using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Lms.Server.Models;
using ViewModel;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity;

namespace Lms.Server.Controllers.Identity
{
    [RoutePrefix("api/UserQuery")]
    public class UserQueryController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        [Route("GetSelectList")]

        [ActionName("GetSelectList")]

        public List<SelectViewModel> GetSelectList()
        {
            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(db));

            var roles = userManager.Users.Select(u => new SelectViewModel { Id = u.Id, Value = u.UserName }).ToList();
            return roles;
        }


    }
}
