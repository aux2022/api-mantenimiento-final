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
    public class SolicitudMaquinaController : ApiController
    {
      
        // GET: api/SolicitudArea
        public IEnumerable<maquinas> Get()
       {
           GestorMaquinas gMaquinas = new GestorMaquinas();
          return gMaquinas.GetMaquinas();

        }

        // GET: api/Solicitud/5
        //public IEnumerable<maquinas> Get(Guid id2)
        //{
            //var owner = id2;
            //GestorMaquinas gMaquinas = new GestorMaquinas();
           // return gMaquinas.GetMaquinas2(id2);

       // }



        // POST: api/Solicitud2
     //   public bool Post([FromBody] solicitudPreventiva SolicitudPreventiva)
       // {
         //   GestorSolicitudPreventiva gSolicitud = new GestorSolicitudPreventiva();
           // bool res = gSolicitud.addSolicitud2(SolicitudPreventiva);

            //return res;
        //}
        // POST: api/SolicitudArea
        public bool Post([FromBody] maquinas Maquinas)
        {
            GestorMaquinas gMaquinas = new GestorMaquinas();
            bool res = gMaquinas.addMaquinas(Maquinas);

            return res;
        }



        // PUT: api/Solicitud/5
        public bool Put(int id, [FromBody]maquinas Maquinas)
        {
            GestorMaquinas gMaquinas = new GestorMaquinas();
            bool res = gMaquinas.updateMaquinas(id,Maquinas);

            return res;
        }

        // DELETE: api/Solicitud/5
        public bool Delete(int id)
        {
            GestorMaquinas gMaquinas = new GestorMaquinas();
            bool res = gMaquinas.deleteMaquina(id);

            return res;
        }
    }
}
