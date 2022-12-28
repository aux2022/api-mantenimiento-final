using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace back_salidaActivos.Models
{
    public class areas
    {
        public int idArea { get; set; }
        public string nombre { get; set; }

        public areas() { }

        public areas(int IdArea,
string Nombre
            )
        {
            idArea = IdArea; 
            nombre = Nombre;
        }

        public areas(
string Nombre
           )
        {
   
            nombre = Nombre;
        }

    }
}



