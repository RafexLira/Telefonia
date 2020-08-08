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
using TelefoniaDomain;
using TelefoniaInfra.DataContext;

namespace TelefoniaAPI.Controllers
{
    public class PlanoController : ApiController
    {
        private TelefoniaContext db = new TelefoniaContext();

        // GET: api/Plano
        public IQueryable<Plano> GetPlanos()
        {
            return db.Planos;
        }

        // GET: api/Plano/5
        [ResponseType(typeof(Plano))]
        public IHttpActionResult GetPlano(int id)
        {
            Plano plano = db.Planos.Find(id);
            if (plano == null)
            {
                return NotFound();
            }

            return Ok(plano);
        }

        // PUT: api/Plano/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutPlano(int id, Plano plano)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != plano.Id)
            {
                return BadRequest();
            }

            db.Entry(plano).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PlanoExists(id))
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

        // POST: api/Plano
        [ResponseType(typeof(Plano))]
        public IHttpActionResult PostPlano(Plano plano)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Planos.Add(plano);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = plano.Id }, plano);
        }

        // DELETE: api/Plano/5
        [ResponseType(typeof(Plano))]
        public IHttpActionResult DeletePlano(int id)
        {
            Plano plano = db.Planos.Find(id);
            if (plano == null)
            {
                return NotFound();
            }

            db.Planos.Remove(plano);
            db.SaveChanges();

            return Ok(plano);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PlanoExists(int id)
        {
            return db.Planos.Count(e => e.Id == id) > 0;
        }
    }
}