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
    public class TomadasController : ApiController
    {
        [EnableCors(origins: "*", headers: "*", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        // GET: api/Tomadas
        public IEnumerable<solicitud> Get()
        {
            GestorSolicitud gSolicitud = new GestorSolicitud();
            return gSolicitud.GetSolicitudTomadas();
        }

        // GET: api/Tomadas/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Tomadas
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Tomadas/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Tomadas/5
        public void Delete(int id)
        {
        }
    }
}
