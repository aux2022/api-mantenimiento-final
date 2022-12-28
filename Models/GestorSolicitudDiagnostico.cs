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
    public class GestorSolicitudDiagnostico

    {

        public bool updateSolicitud3(int id, solicitudDiagnostico SolicitudDiagnostico)
        {
            bool res = false;
            string strConn = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                SqlCommand cmd = conn.CreateCommand();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                cmd.CommandText = "diagnosticoUpdate";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@idSolicitud", id);

                cmd.Parameters.AddWithValue("@nomina", SolicitudDiagnostico.nomina);

                cmd.Parameters.AddWithValue("@fechaInicio", SolicitudDiagnostico.fechaInicio);

                cmd.Parameters.AddWithValue("@horaInicio", SolicitudDiagnostico.horaInicio);

                cmd.Parameters.AddWithValue("@diagnostico", SolicitudDiagnostico.diagnostico);

                cmd.Parameters.AddWithValue("@tipoFalla", SolicitudDiagnostico.tipoFalla);

                cmd.Parameters.AddWithValue("@emailSent", SolicitudDiagnostico.emailSent);

                cmd.Parameters.AddWithValue("@nomina2", SolicitudDiagnostico.nomina2);

                cmd.Parameters.AddWithValue("@asignacion", SolicitudDiagnostico.asignacion);


                //

                //
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