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
    public class LotesController : ApiController
    {
        // GET: api/Solicitud
        public IEnumerable<lotes> Get()
        {
            GestorSolicitud gSolicitud = new GestorSolicitud();
            return gSolicitud.GetSolicituds();

        }



            // POST: api/Solicitud
            public bool Post([FromBody] lotes Solicitud)
            {
                GestorSolicitud gSolicitud = new GestorSolicitud();
                bool res = gSolicitud.addSolicitud(Solicitud);

                return res;
            }



        // PUT: api/Solicitud/5
        public bool Put(string id, [FromBody] lotes Solicitud)
        {
            GestorSolicitud gSolicitud = new GestorSolicitud();
            bool res = gSolicitud.updateSolicitud(id, Solicitud);

            return res;
        }

        //// DELETE: api/Solicitud/5
        //public bool Delete(int id)
        //{
        //    GestorSolicitud gSolicitud = new GestorSolicitud();
        //    bool res = gSolicitud.deleteSolicitud(id);

        //    return res;
        //}
    }
    }
