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
    public class GestorSolicitudCierre

    {
     




        public bool updateSolicitud5(int id, solicitudCierre SolicitudCierre)
        {
            bool res = false;
            string strConn = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                SqlCommand cmd = conn.CreateCommand();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                cmd.CommandText = "cierreUpdate";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@idSolicitud", id);

                cmd.Parameters.AddWithValue("@fechaFinal", SolicitudCierre.fechaFinal);

                cmd.Parameters.AddWithValue("@horaFinal", SolicitudCierre.horaFinal);

                cmd.Parameters.AddWithValue("@trabajoSanitizado", SolicitudCierre.trabajoSanitizado);

                cmd.Parameters.AddWithValue("@estatusActividad", SolicitudCierre.estatusActividad);

                cmd.Parameters.AddWithValue("@firmaSolicitante", SolicitudCierre.firmaSolicitante);

                cmd.Parameters.AddWithValue("@emailSent2", SolicitudCierre.emailSent2);

                cmd.Parameters.AddWithValue("@fechaFirma", SolicitudCierre.fechaFirma);

                cmd.Parameters.AddWithValue("@horaFirma", SolicitudCierre.horaFirma);

                cmd.Parameters.AddWithValue("@comentariosSolicitante", SolicitudCierre.horaFirma);

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