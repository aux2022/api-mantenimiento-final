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
    public class PendientesController : ApiController
    {
        // GET: api/Pendientes
        public IEnumerable<solicitud> Get()
        {
            GestorSolicitud gSolicitud = new GestorSolicitud();
            return gSolicitud.GetSolicitudPendientes();
        }

        // GET: api/Pendientes/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Pendientes
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Pendientes/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Pendientes/5
        public void Delete(int id)
        {
        }
    }
}
