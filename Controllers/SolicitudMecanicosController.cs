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
    public class SolicitudMecanicosController : ApiController
    {
        // GET: api/SolicitudArea
        public IEnumerable<mecanicos> Get()
        {
            GestorMecanicos gMecanicos = new GestorMecanicos();
            return gMecanicos.GetMecanicos();

        }
       
        // GET: api/Solicitud/5
        public IEnumerable<solicitud> Get(int id)
        {

            GestorSolicitud gSolicitud = new GestorSolicitud();
            return gSolicitud.GetSolicitudsById(id);


        }



        // POST: api/Solicitud2
     //   public bool Post([FromBody] solicitudPreventiva SolicitudPreventiva)
       // {
         //   GestorSolicitudPreventiva gSolicitud = new GestorSolicitudPreventiva();
           // bool res = gSolicitud.addSolicitud2(SolicitudPreventiva);

            //return res;
        //}
        // POST: api/SolicitudArea
        public bool Post([FromBody] mecanicos Mecanicos)
        {
            GestorMecanicos gMaquinas = new GestorMecanicos();
            bool res = gMaquinas.addMecanicos(Mecanicos);

            return res;
        }



        // PUT: api/Solicitud/5
        public bool Put(int id, [FromBody]mecanicos Mecanicos)
        {
            GestorMecanicos gMecanicos = new GestorMecanicos();
            bool res = gMecanicos.updateMecanicos(id,Mecanicos);

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
