using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Lms.Server.Models;
using System.Web.Http.Description;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace Lms.Server.Controllers.Identity
{
    public class ResourceController : ApiController
    {
        ApplicationDbContext db = new ApplicationDbContext();
        //Put: api/Resource/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutAspNetResource(string id, AspNetResource aspNetResource)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (id != aspNetResource.Id)
            {
                return BadRequest();
            }

            db.Entry(aspNetResource).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AspNetResourceExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }

            }
            return StatusCode(HttpStatusCode.NoContent);
        }


        //Post : api/Resource
        [ResponseType(typeof(AspNetResource))]

        public IHttpActionResult PostAspNetResource(AspNetResource aspNetResource)
        {
            aspNetResource.Id = Guid.NewGuid().ToString();
            aspNetResource.CreatedBy = User.Identity.Name;
            aspNetResource.ModifiedBy = User.Identity.Name;

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            db.AspNetResources.Add(aspNetResource);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (AspNetResourceExists(aspNetResource.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }

            }
            return Ok();
        }

        //DELETE:api/Recource/5

        [ResponseType(typeof(AspNetResource))]

        public IHttpActionResult DeleteAspNetResource(string id)
        {
            AspNetResource aspNetResource = db.AspNetResources.Find(id);

            if (aspNetResource == null)
            {
                return NotFound();
            }

            db.AspNetResources.Remove(aspNetResource);
            db.SaveChanges();
            return Ok(aspNetResource);
        }


        protected override void Dispose(bool disposing)
        {

            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }


        private bool AspNetResourceExists(string id)
        {
            return db.AspNetResources.Count(e => e.Id == id) > 0;


        }
    }
}
