using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace back_salidaActivos.Models
{
    public class GestorHistorial
    {

        public List<Historial> GetHistorial()
        {
            List<Historial> lista = new List<Historial>();
            string strConn = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "historialMecanicos_All";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    //solicitud
                    int idHistorial = dr.GetInt32(0);
                    int idSolicitud = dr.GetInt32(1);
                    string fechaHistorial = dr.GetString(2).Trim();
                    string horaHistorial = dr.GetString(3).Trim();
                    string historialMecanico = dr.GetString(4).Trim();

                    Historial Historial = new Historial(
                   idHistorial,
                    idSolicitud,
                    fechaHistorial,
                    horaHistorial,
                    historialMecanico
                        );

                    lista.Add(Historial);
                }
                dr.Close();
                conn.Close();
            }
            return lista;
        }

        public List<Historial> GetSolicitudsByIdHistorial(int id2)
        {

            List<Historial> lista = new List<Historial>();
            string strConn = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("select * from HistorialMecanicos where idSolicitud=" + id2, conn);

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    //solicitud
                    int idHistorial = dr.GetInt32(0);
                    int idSolicitud = dr.GetInt32(1);
                    string fechaHistorial = dr.GetString(2).Trim();
                    string horaHistorial = dr.GetString(3).Trim();
                    string historialMecanico = dr.GetString(4).Trim();

                    Historial Historial = new Historial(
                   idHistorial,
                    idSolicitud,
                    fechaHistorial,
                    horaHistorial,
                    historialMecanico
                        );

                    lista.Add(Historial);
                }
                dr.Close();
                conn.Close();
            }
            return lista;
        }





    }
}