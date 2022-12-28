using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using EASendMail;


namespace back_salidaActivos.Models
{
    public class GestorSolicitudReparacion

    {
     




        public bool updateSolicitud4(int id, solicitudReparacion SolicitudReparacion)
        {
            bool res = false;
            string strConn = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                SqlCommand cmd = conn.CreateCommand();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                cmd.CommandText = "reparacionUpdate";
                cmd.CommandType = CommandType.StoredProcedure;




                cmd.Parameters.AddWithValue("@idSolicitud", id);

                cmd.Parameters.AddWithValue("@generoParo", SolicitudReparacion.generoParo);

                cmd.Parameters.AddWithValue("@paroCorrectivo", SolicitudReparacion.paroCorrectivo);

                cmd.Parameters.AddWithValue("@paroOperativo", SolicitudReparacion.paroOperativo);

                cmd.Parameters.AddWithValue("@paroRefaccion", SolicitudReparacion.paroRefaccion);

                cmd.Parameters.AddWithValue("@tiempoTotal", SolicitudReparacion.tiempoTotal);

                cmd.Parameters.AddWithValue("@grasaUtilizada", SolicitudReparacion.grasaUtilizada);

                cmd.Parameters.AddWithValue("@refaMateHerra", SolicitudReparacion.refaMateHerra);

                cmd.Parameters.AddWithValue("@tareasEjecutadas", SolicitudReparacion.tareasEjecutadas);


                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    res = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    res = false;
                    throw;
                }
                finally
                {
                    cmd.Parameters.Clear();
                    conn.Close();
                }
                return res;
            }


        }


    }



}