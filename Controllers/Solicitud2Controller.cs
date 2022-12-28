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
    public class Solicitud2Controller : ApiController
    {
        // GET: api/Solicitud2
        public IEnumerable<solicitudPreventiva> Get()
        {
            GestorSolicitudPreventiva gSolicitud = new GestorSolicitudPreventiva();
            return gSolicitud.GetSolicituds();

        }
       
        // GET: api/Solicitud2/5
        public IEnumerable<solicitudPreventiva> Get(int id)
        {

            GestorSolicitudPreventiva gSolicitud = new GestorSolicitudPreventiva();
            return gSolicitud.GetSolicitudsById(id);


        }

        // POST: api/Solicitud2
        public bool Post([FromBody] solicitudPreventiva SolicitudPreventiva)
        {
            GestorSolicitudPreventiva gSolicitud = new GestorSolicitudPreventiva();
            bool res = gSolicitud.addSolicitud2(SolicitudPreventiva);

            return res;
        }



        // PUT: api/Solicitud/5
        public bool Put(int id, [FromBody]solicitudPreventiva SolicitudPreventiva)
        {
            GestorSolicitudPreventiva gSolicitud = new GestorSolicitudPreventiva();
            bool res = gSolicitud.updateSolicitud2(id,SolicitudPreventiva);

            return res;
        }

        // DELETE: api/Solicitud/5
        public bool Delete(int id)
        {
            GestorSolicitud gSolicitud = new GestorSolicitud();
            bool res = gSolicitud.deleteSolicitud(id);

            return res;
        }
    }
}
