using back_salidaActivos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace back_salidaActivos.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "GET,POST,PUT,DELETE,OPTIONS")]
    public class SolicitudHistorialController : ApiController
    {
        // GET: api/SolicitudHistorial
        public IEnumerable<Historial> Get()
        {
            GestorHistorial gSolicitud = new GestorHistorial();
            return gSolicitud.GetHistorial();
        }

        // GET: api/SolicitudHistorial/5
        public IEnumerable<Historial> Get(int id)
        {
            GestorHistorial gSolicitud = new GestorHistorial();
            return gSolicitud.GetSolicitudsByIdHistorial(id);
        }

        // POST: api/SolicitudHistorial
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/SolicitudHistorial/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/SolicitudHistorial/5
        public void Delete(int id)
        {
        }
    }
}
