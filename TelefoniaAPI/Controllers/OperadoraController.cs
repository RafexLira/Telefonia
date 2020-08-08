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
    public class OperadoraController : ApiController
    {
        private TelefoniaContext db = new TelefoniaContext();

        // GET: api/Operadora
        public IQueryable<Operadora> GetOperadoras()
        {
            return db.Operadoras;
        }

        // GET: api/Operadora/5
        [ResponseType(typeof(Operadora))]
        public IHttpActionResult GetOperadora(int id)
        {
            Operadora operadora = db.Operadoras.Find(id);
            if (operadora == null)
            {
                return NotFound();
            }

            return Ok(operadora);
        }

        // PUT: api/Operadora/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutOperadora(int id, Operadora operadora)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != operadora.Id)
            {
                return BadRequest();
            }

            db.Entry(operadora).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OperadoraExists(id))
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

        // POST: api/Operadora
        [ResponseType(typeof(Operadora))]
        public IHttpActionResult PostOperadora(Operadora operadora)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Operadoras.Add(operadora);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = operadora.Id }, operadora);
        }

        // DELETE: api/Operadora/5
        [ResponseType(typeof(Operadora))]
        public IHttpActionResult DeleteOperadora(int id)
        {
            Operadora operadora = db.Operadoras.Find(id);
            if (operadora == null)
            {
                return NotFound();
            }

            db.Operadoras.Remove(operadora);
            db.SaveChanges();

            return Ok(operadora);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool OperadoraExists(int id)
        {
            return db.Operadoras.Count(e => e.Id == id) > 0;
        }
    }
}