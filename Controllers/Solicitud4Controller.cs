using System;
using back_salidaActivos.Models;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace back_salidaActivos.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "GET,POST,PUT,DELETE,OPTIONS")]
    public class Solicitud4Controller : ApiController
    {
        // GET: api/Solicitud3
        
       
        // GET: api/Solicitud2/5
       
        // POST: api/Solicitud2
       

        // PUT: api/Solicitud/5
        public bool Put(int id, [FromBody]solicitudReparacion SolicitudReparacion)
        {
            GestorSolicitudReparacion gSolicitud = new GestorSolicitudReparacion();
            bool res = gSolicitud.updateSolicitud4(id,SolicitudReparacion);

            return res;
        }

    }
}
