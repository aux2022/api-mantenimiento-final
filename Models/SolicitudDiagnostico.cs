using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace back_salidaActivos.Models
{
    public class solicitudDiagnostico
    {


        //diagnostico

        public int idSolicitud { get; set; }
        public string nomina { get; set; }
        public string nombre { get; set; }

        public string fechaInicio { get; set; }

        public string horaInicio { get; set; }

        public string diagnostico { get; set; }

        public string tipoFalla { get; set; }

        public string emailSent { get; set; }

        public int nomina2 { get; set; }

        public string asignacion { get; set; }




      
        public solicitudDiagnostico() { }



        public solicitudDiagnostico(

        //diagnostico
int IdSolicitud, string Nomina, string Nombre, string FechaInicio, string HoraInicio,
string Diagnostico, string TipoFalla, string EmailSent, int Nomina2, string Asignacion

      
            )
        {
            idSolicitud = IdSolicitud;
            //diagnostico
            nomina = Nomina;
            nombre = Nombre;
            fechaInicio = FechaInicio;
            horaInicio = HoraInicio;
            diagnostico = Diagnostico;
            tipoFalla = TipoFalla;
            emailSent = EmailSent;
            nomina2 = Nomina2;
            asignacion= Asignacion;


        }



        public solicitudDiagnostico(

        //diagnostico
string Nomina, string Nombre, string FechaInicio, string HoraInicio,
string Diagnostico, string TipoFalla, string EmailSent, int Nomina2, string Asignacion


            )
        {
           
            //diagnostico
            nomina = Nomina;
            nombre = Nombre;
            fechaInicio = FechaInicio;
            horaInicio = HoraInicio;
            diagnostico = Diagnostico;
            tipoFalla = TipoFalla;
            emailSent = EmailSent;
            nomina2= Nomina2;
            asignacion = Asignacion;
         

           

        }




    }
}



