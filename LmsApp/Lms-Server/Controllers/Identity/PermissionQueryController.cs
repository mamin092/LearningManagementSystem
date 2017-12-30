using Lms.Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace Lms.Server.Controllers.Identity
{
    public class PermissionQueryController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // Get : api/PermissionQuery

        public IQueryable<AspNetPermission> GetAspNetPermissions()
        {
            return db.AspNetPermissions;
        }

        // GET: api/PermissionQuery/5

        [ResponseType(typeof(AspNetPermission))]

        public IHttpActionResult GetAspNetPermission(string id)
        {
            AspNetPermission aspNetPermission = db.AspNetPermissions.Find(id);
            if (aspNetPermission == null)
            {
                return NotFound();

            }
            return Ok(aspNetPermission);
        }

        protected override void Dispose(bool disposing)
        {

            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool AspNetPermissionExists(string id)
        {
            return db.AspNetPermissions.Count(e => e.Id == id) > 0;
        }
    }
}
