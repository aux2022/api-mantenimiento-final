using back_salidaActivos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace back_salidaActivos.Controllers
{
    public class SolicitudesCerradasPorAreaController : ApiController
    {
        // GET: api/SolicitudesCerradasPorArea
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/SolicitudesCerradasPorArea/5
        public IEnumerable<solicitud> Get(string id)
        {
            GestorSolicitud gSolicitud = new GestorSolicitud();
            return gSolicitud.GetSolicitudsCerradasPorArea(id);

        }

        // POST: api/SolicitudesCerradasPorArea
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/SolicitudesCerradasPorArea/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/SolicitudesCerradasPorArea/5
        public void Delete(int id)
        {
        }
    }
}
