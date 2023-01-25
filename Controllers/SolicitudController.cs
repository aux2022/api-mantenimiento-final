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
    public class SolicitudController : ApiController
    {
        // GET: api/Solicitud
        public IEnumerable<lote> Get()
        {
            GestorSolicitud gSolicitud = new GestorSolicitud();
            return gSolicitud.GetSolicituds();

        }

        //GET: api/Solicitud/5
        //public IEnumerable<lote> Get(int id)
        //{

        //    GestorSolicitud gSolicitud = new GestorSolicitud();
        //    return gSolicitud.GetVacaciones(id);


        //    }

            // POST: api/Solicitud
            public bool Post([FromBody] lote Lote)
            {
                GestorSolicitud gSolicitud = new GestorSolicitud();
                bool res = gSolicitud.addSolicitud(Lote);

                return res;
            }



        // PUT: api/Solicitud/5
        public bool Put(int id, [FromBody] lote Lote)
        {
            GestorSolicitud gSolicitud = new GestorSolicitud();
            bool res = gSolicitud.updateSolicitud(id, Lote);

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
