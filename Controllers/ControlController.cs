﻿using System;
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
    public class ControlController : ApiController
    {
        // GET: api/Solicitud
        public IEnumerable<control> Get()
        {
            GestorSolicitud gSolicitud = new GestorSolicitud();
            return gSolicitud.GetControls();

        }

       // GET: api/Solicitud/5
        public IEnumerable<control> Get(int id)
        {

            GestorSolicitud gSolicitud = new GestorSolicitud();
            return gSolicitud.GetControlById(id);


        }

        //// POST: api/Solicitud
        //public bool Post([FromBody] solicitud Solicitud)
        //{
        //    GestorSolicitud gSolicitud = new GestorSolicitud();
        //    bool res = gSolicitud.addSolicitud(Solicitud);

        //    return res;
        //}



        //// PUT: api/Solicitud/5
        //public bool Put(int id, [FromBody]solicitud Solicitud)
        //{
        //    GestorSolicitud gSolicitud = new GestorSolicitud();
        //    bool res = gSolicitud.updateSolicitud(id,Solicitud);

        //    return res;
        //}

        //// DELETE: api/Solicitud/5
        //public bool Delete(int id)
        //{
        //    GestorSolicitud gSolicitud = new GestorSolicitud();
        //    bool res = gSolicitud.deleteSolicitud(id);

        //    return res;
        //}
    }
    }
