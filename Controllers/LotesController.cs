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
    public class LoteController : ApiController
    {
        // GET: api/Solicitud
        public IEnumerable<lote> Get()
        {
            GestorLotes gSolicitud = new GestorLotes();
            return gSolicitud.GetSolicituds();

        }


            // POST: api/Solicitud
            public bool Post([FromBody] lote Lote)
            {
                GestorLotes gSolicitud = new GestorLotes();
                bool res = gSolicitud.addLotes(Lote);

                return res;
            }


        // PUT: api/Solicitud/5
        public bool Put(int id, [FromBody] lote Lote)
        {
            GestorLotes gSolicitud = new GestorLotes();
            bool res = gSolicitud.updateLotes(id, Lote);

            return res;
        }

    }
    }
