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
    public class CerradasController : ApiController
    {
        // GET: api/Cerradas
        public IEnumerable<solicitud> Get()
        {
            GestorSolicitud gSolicitud = new GestorSolicitud();
            return gSolicitud.GetSolicitudsCerradas();
        }

        // GET: api/Cerradas/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Cerradas
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Cerradas/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Cerradas/5
        public void Delete(int id)
        {
        }
    }
}
