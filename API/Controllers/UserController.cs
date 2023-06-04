using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using API.Models;

namespace API.Controllers
{
    public class UserController : ApiController
    {
        private User_masterEntities db = new User_masterEntities();

        // GET: api/User
        public IQueryable<User_Master_Table_1> GetUser_Master_Table_1()
        {
            return db.User_Master_Table_1;
        }

        // GET: api/User/5
        [ResponseType(typeof(User_Master_Table_1))]
        public IHttpActionResult GetUser_Master_Table_1(int id)
        {
            User_Master_Table_1 user_Master_Table_1 = db.User_Master_Table_1.Find(id);
            if (user_Master_Table_1 == null)
            {
                return NotFound();
            }

            return Ok(user_Master_Table_1);
        }

        // PUT: api/User/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutUser_Master_Table_1(int id, User_Master_Table_1 user_Master_Table_1)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != user_Master_Table_1.User_MasterID)
            {
                return BadRequest();
            }

            db.Entry(user_Master_Table_1).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!User_Master_Table_1Exists(id))
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

        // POST: api/User
        [ResponseType(typeof(User_Master_Table_1))]
        public IHttpActionResult PostUser_Master_Table_1(User_Master_Table_1 user_Master_Table_1)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.User_Master_Table_1.Add(user_Master_Table_1);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = user_Master_Table_1.User_MasterID }, user_Master_Table_1);
        }

        // DELETE: api/User/5
        [ResponseType(typeof(User_Master_Table_1))]
        public IHttpActionResult DeleteUser_Master_Table_1(int id)
        {
            User_Master_Table_1 user_Master_Table_1 = db.User_Master_Table_1.Find(id);
            if (user_Master_Table_1 == null)
            {
                return NotFound();
            }

            db.User_Master_Table_1.Remove(user_Master_Table_1);
            db.SaveChanges();

            return Ok(user_Master_Table_1);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool User_Master_Table_1Exists(int id)
        {
            return db.User_Master_Table_1.Count(e => e.User_MasterID == id) > 0;
        }
    }
}