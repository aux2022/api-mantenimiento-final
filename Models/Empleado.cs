using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace back_salidaActivos.Models
{
    public class empleado
    {

        //empleado
     
        public int noNomina { get; set; }

        public string nombre { get; set; }

        public string puesto { get; set; }

        public string area { get; set; }

        public string jefe { get; set; }

        public string correoJefe { get; set; }



        public empleado() { }


        public empleado(int NoNomina, string Nombre, string Puesto, string Area, string Jefe, string CorreoJefe)
        {

            noNomina = NoNomina;
            nombre = Nombre;
            puesto = Puesto;
            area= Area;
            jefe = Jefe;
            correoJefe = CorreoJefe;



        }
        public empleado( string Nombre, string Puesto, string Area, string Jefe, string CorreoJefe)
        {
            nombre = Nombre;
            puesto = Puesto;
            area = Area;
            jefe = Jefe;
            correoJefe = CorreoJefe;
        }


    }
}



