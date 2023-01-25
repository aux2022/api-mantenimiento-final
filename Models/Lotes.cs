using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace back_salidaActivos.Models
{
    public class lotes
    {

       public string lote { get; set; }

        public int orden { get; set; }
        public string producto { get; set; }
        public string codigo { get; set; }
      
        public decimal kg { get; set; }
        public decimal mts { get; set; }

        public string almacen { get; set; }
        public string status { get; set; }


        public lotes(string Lote, int Orden, string Producto, string Codigo, 
            decimal Kg, decimal Mts, string Almacen, string Status ) { 
            lote=Lote;
            orden = Orden;
            producto = Producto;
            codigo = Codigo;
            kg = Kg;
            mts= Mts;
            almacen = Almacen;
            status = Status;
        }

        public lotes( int Orden, string Producto, string Codigo,
      decimal Kg, decimal Mts, string Almacen, string Status)
        {
            
            orden = Orden;
            producto = Producto;
            codigo = Codigo;
            kg = Kg;
            mts = Mts;
            almacen = Almacen;
            status = Status;
        }






    }



    }




