using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace back_salidaActivos.Models
{
    public class solicitudReparacion
    {

        public int idSolicitud { get; set; }
       
        //reparacion

        public string tareasEjecutadas { get; set; }

        public string generoParo { get; set; }

        public int paroCorrectivo { get; set; }

        public int paroOperativo { get; set; }

        public int paroRefaccion { get; set; }

        public int tiempoTotal { get; set; }

        public string grasaUtilizada { get; set; }

        public string refaMateHerra { get; set; }

        
        public solicitudReparacion() { }



        public solicitudReparacion(

int IdSolicitud, 

        //reparacion
        string TareasEjecutadas,
string GeneroParo, int ParoCorrectivo, int ParoOperativo, int ParoRefaccion,
int TiempoTotal, string GrasaUtilizada, string RefaMateHerra


            )
        {
            idSolicitud = IdSolicitud;



            //reparacion
            tareasEjecutadas = TareasEjecutadas;
            generoParo = GeneroParo;
            paroCorrectivo = ParoCorrectivo;
            paroOperativo = ParoOperativo;
            paroRefaccion = ParoRefaccion;
            tiempoTotal = TiempoTotal;
            grasaUtilizada = GrasaUtilizada;
            refaMateHerra = RefaMateHerra;

            
        }



        public solicitudReparacion(


        //reparacion
string GeneroParo, int ParoCorrectivo, int ParoOperativo, int ParoRefaccion,
int TiempoTotal, string GrasaUtilizada, string RefaMateHerra, string TareasEjecutadas


            )
        {



            //reparacion
            tareasEjecutadas = TareasEjecutadas;
            generoParo = GeneroParo;
            paroCorrectivo = ParoCorrectivo;
            paroOperativo = ParoOperativo;
            paroRefaccion = ParoRefaccion;
            tiempoTotal = TiempoTotal;
            grasaUtilizada = GrasaUtilizada;
            refaMateHerra = RefaMateHerra;

           

        }




    }
}



