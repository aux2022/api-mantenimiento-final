using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace back_salidaActivos.Models
{
    public class mecanicos
    {

        //solicitud
       public int idMecanico { get; set; }
        public string nombre { get; set; }

        public string nomina { get; set; }

        

        public mecanicos() { }



        //public areas(
//solicitud
//int IdArea,  string Nombre
        //    )
       // {
         //   idArea = IdArea;
            
          //  nombre = Nombre;
            
      //  }


        public mecanicos(int IdMecanico,
string Nombre, string Nomina
            )
        {           
            idMecanico = IdMecanico;
            nombre = Nombre;
            nomina = Nomina;
        }

        public mecanicos(
string Nombre, string Nomina
            )
        {
           
            nombre = Nombre;
            nomina = Nomina;
        }




    }
}



