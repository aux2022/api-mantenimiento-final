using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace back_salidaActivos.Models
{
    public class tiempos
    {

        //solicitud
        public int idSolicitud { get; set; }
        public string fechaSolicitud { get; set; }

        public string horaSolicitud { get; set; }

        public string fechaFinal { get; set; }

        public string horaFinal { get; set; }

        public int totalMinutos { get; set; }


        public tiempos() { }



        public tiempos(
//solicitud
int IdSolicitud, string FechaSolicitud, string HoraSolicitud, string FechaFinal, string HoraFinal, int TotalMinutos)
        {
            idSolicitud = IdSolicitud;
            fechaSolicitud = FechaSolicitud;
            horaSolicitud = HoraSolicitud;
            fechaFinal = FechaFinal;
            horaFinal = HoraFinal;
            totalMinutos = TotalMinutos;
        }




    }




}
