using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace back_salidaActivos.Models
{
    public class  solicitudPreventiva
    {

        //solicitud
        public int idSolicitud { get; set; }
        public string nombreSolicitante { get; set; }

        public string correo { get; set; }

        public string fechaSolicitud { get; set; }

        public string horaSolicitud { get; set; }

        public string area { get; set; }

        public string maquina { get; set; }

        public string dispositivo { get; set; }

        public string descripcionProblema { get; set; }





       
        public solicitudPreventiva() { }



        public solicitudPreventiva(
//solicitud
int IdSolicitud, string NombreSolicitante, string Correo, string FechaSolicitud,
string HoraSolicitud, string Area, string Maquina, string Dispositivo, string DescripcionProblema
            )
        {
            idSolicitud = IdSolicitud;
            nombreSolicitante = NombreSolicitante;
            correo = Correo;
            fechaSolicitud = FechaSolicitud;
            horaSolicitud = HoraSolicitud;
            area = Area;
            maquina = Maquina;
            dispositivo = Dispositivo;
            descripcionProblema = DescripcionProblema;

        }



        public solicitudPreventiva(
string NombreSolicitante, string Correo, string FechaSolicitud,
string HoraSolicitud, string Area, string Maquina, string Dispositivo, string DescripcionProblema
      
            )
        {
            nombreSolicitante = NombreSolicitante;
            correo = Correo;
            fechaSolicitud = FechaSolicitud;
            horaSolicitud = HoraSolicitud;
            area = Area;
            maquina = Maquina;
            dispositivo = Dispositivo;
            descripcionProblema = DescripcionProblema;


        }




    }
}