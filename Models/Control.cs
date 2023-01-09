using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace back_salidaActivos.Models
{
    public class control
    {

        //control
     
        public int noNomina { get; set; }

        public string ingreso { get; set; }

        public int antiguedad { get; set; }

        public int diasDerecho { get; set; }

        public int diasDisfrutados { get; set; }

        public int diasPendientes { get; set; }



        public control() { }


        public control(int NoNomina, string Ingreso, int Antiguedad, int DiasDerecho, int DiasDisfrutados, int DiasPendientes)
        {

            noNomina = NoNomina;
            ingreso = Ingreso;
            antiguedad = Antiguedad;
            diasDerecho = DiasDerecho;
            diasDisfrutados = DiasDisfrutados;
            diasPendientes = DiasPendientes;



        }
        public control(
            string Ingreso, int Antiguedad, int DiasDerecho, int DiasDisfrutados, int DiasPendientes
            )
        {
           
            ingreso = Ingreso;
            antiguedad = Antiguedad;
            diasDerecho = DiasDerecho;
            diasDisfrutados = DiasDisfrutados;
            diasPendientes = DiasPendientes;

        }


    }
}



