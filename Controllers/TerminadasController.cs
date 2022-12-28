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
    public class TerminadasController : ApiController
    {
        [EnableCors(origins: "*", headers: "*", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        // GET: api/Terminadas
        public IEnumerable<solicitud> Get()
        {
            GestorSolicitud gSolicitud = new GestorSolicitud();
            return gSolicitud.GetSolicitudTerminadas();
        }

        // GET: api/Terminadas/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Terminadas
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Terminadas/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Terminadas/5
        public void Delete(int id)
        {
        }
    }
}
