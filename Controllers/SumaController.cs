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
    public class SumaController : ApiController
    {
        // GET: api/Solicitud esta es la final
        // GET: api/Solicitud2
        public IEnumerable<tiempos> Get()
        {
            GestorTiempos gSolicitud = new GestorTiempos();
            return gSolicitud.GetTiempos();
        }

        // GET: api/Solicitud/5
        public IEnumerable<tiempos> Get(int id)
        {

            GestorTiempos gSolicitud = new GestorTiempos();
            return gSolicitud.GetTiemposById(id);


        }


    }
}