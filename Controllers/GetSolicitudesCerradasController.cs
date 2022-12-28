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
    public class GetSolicitudesCerradasController : ApiController
    {
        // GET: api/GetSolicitudesCerradas
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/GetSolicitudesCerradas/5
        public IEnumerable<solicitud> Get(int id)
        {

            GestorSolicitud gSolicitud = new GestorSolicitud();
            return gSolicitud.GetSolicitudsById2Cierre(id);


        }

        // POST: api/GetSolicitudesCerradas
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/GetSolicitudesCerradas/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/GetSolicitudesCerradas/5
        public void Delete(int id)
        {
        }
    }
}
