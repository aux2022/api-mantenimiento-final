using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace back_salidaActivos.Models
{
    public class lote
    {

        public int id { get; set; }
        public string lote2 { get; set; }

        public int orden { get; set; }
        public string producto { get; set; }
        public string codigo { get; set; }

        public double kg { get; set; }
        public double mts { get; set; }

        public string almacen { get; set; }
        public string status { get; set; }


        public lote() { }


        public lote(
          int Id, string Lote2, int Orden, string Producto, string Codigo,
            double Kg, double Mts, string Almacen, string Status
          )
        {

            id = Id;
            lote2 = Lote2;
            orden = Orden;
            producto = Producto;
            codigo = Codigo;
            kg = Kg;
            mts = Mts;
            almacen = Almacen;
            status = Status;

        }
        public lote( string Lote2, int Orden, string Producto, string Codigo,
            double Kg, double Mts, string Almacen, string Status
            )
        {
            lote2 = Lote2;
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



