using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace back_salidaActivos.Models
{
    public class solicitud
    {

        //solicitud
        public int noSolicitud { get; set; }
        public int noNomina { get; set; }

        public string nombre { get; set; }

        public string fechaSolicitud { get; set; }

        public string fechaInicio { get; set; }

        public string fechaRegreso { get; set; }

        public int diasTotales { get; set; }

        public string descripcion { get; set; }

        public string estatusJefe { get; set; }

        public string estatusRH { get; set; }

        public string estatusFinal { get; set; }

        public string comentarioRH { get; set; }

        public string comentarioJefe { get; set; }


        public solicitud() { }


        public solicitud(
          int NoNomina, string Nombre, string FechaSolicitud, string FechaInicio, string FechaRegreso,
         int DiasTotales, string Descripcion, string EstatusJefe, string EstatusRH, string EstatusFinal, string ComentarioRH,
         string ComentarioJefe
          )
        {

            noNomina = NoNomina;
            nombre = Nombre;
            fechaSolicitud = FechaSolicitud;
            fechaInicio = FechaInicio;
            fechaRegreso = FechaRegreso;
            diasTotales = DiasTotales;
            descripcion = Descripcion;
            estatusJefe = EstatusJefe;
            estatusRH = EstatusRH;
            estatusFinal = EstatusFinal;
            comentarioRH = ComentarioRH;
            comentarioJefe = ComentarioJefe;

        }
        public solicitud(
           int NoSolicitud, int NoNomina, string Nombre, string FechaSolicitud, string FechaInicio, string FechaRegreso,
           int DiasTotales, string Descripcion,  string EstatusJefe, string EstatusRH, string EstatusFinal,string ComentarioRH,
           string ComentarioJefe
            )
        {
            noSolicitud = NoSolicitud;
            noNomina= NoNomina;
            nombre= Nombre;
            fechaSolicitud= FechaSolicitud;
            fechaInicio= FechaInicio; 
            fechaRegreso= FechaRegreso;
            diasTotales= DiasTotales;
            descripcion = Descripcion;
            estatusJefe= EstatusJefe;
            estatusRH= EstatusRH;   
            estatusFinal= EstatusFinal;
            comentarioRH = ComentarioRH;
            comentarioJefe= ComentarioJefe;

        }


    }
}



