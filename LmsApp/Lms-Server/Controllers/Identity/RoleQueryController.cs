using Lms.Server.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ViewModel;

namespace Lms.Server.Controllers.Identity
{
    [RoutePrefix("api/RoleQuery")]
    public class RoleQueryController : ApiController
    {

        private ApplicationDbContext db = new ApplicationDbContext();
        [Route("GetSelectList")]
        [ActionName("GetSelectList")]
        public List<SelectViewModel> GetSelectList()
        {

            var roleManager = new RoleManager<ApplicationRole>(new RoleStore<ApplicationRole>(db));

            var roles = roleManager.Roles.Select(r => new SelectViewModel { Id = r.Id, Value = r.Name }).ToList();
            return roles;
        }




    }
}
