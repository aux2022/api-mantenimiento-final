using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace back_salidaActivos.Models
{
    public class dispositivos
    {

        //solicitud
       public int idDispositivo { get; set; }
        public string nombre { get; set; }

        public string maquina { get; set; }

        public string codigo { get; set; }

        public string area { get; set; }

        public dispositivos() { }


        public dispositivos(int IdMaquina,
string Nombre, string Maquina, string Codigo, string Area
            )
        {           
            idDispositivo = IdMaquina;
            nombre = Nombre;
            maquina = Maquina;
            codigo = Codigo;
            area = Area;
        }

        public dispositivos(
string Nombre, string Maquina, string Codigo, string Area
            )
        {
           
            nombre = Nombre;
            maquina = Maquina;
            codigo = Codigo;
            area = Area;
        }

    }
}



