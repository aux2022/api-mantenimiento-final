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
    public class GestorTiempos

    {
        public List<tiempos> GetTiempos()
        {
            List<tiempos> lista = new List<tiempos>();
            string strConn = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "tiempos_all";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    //solicitud
                    int idSolicitud = dr.GetInt32(0);
                    string fechaSolicitud = dr.GetString(1).Trim();
                    string horaSolicitud = dr.GetString(2).Trim();
                    string fechaFinal = dr.GetString(3).Trim();
                    string horaFinal = dr.GetString(4).Trim();
                    int totalMinutos = dr.GetInt32(5);

                    tiempos Tiempos = new tiempos(idSolicitud,
                    fechaSolicitud,
                    horaSolicitud,
                    fechaFinal,
                    horaFinal,
                    totalMinutos
                                      );

                    lista.Add(Tiempos);
                }
                dr.Close();
                conn.Close();
            }
            return lista;
        }

        /*Empieza*/
        public List<tiempos> GetTiemposById(int id2)
        {

            List<tiempos> lista = new List<tiempos>();

            string strConn = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("DECLARE @Date1  DATETIME DECLARE @Date2   DATETIME select @Date1 = S.fechaSolicitud + ' ' + S.horaSolicitud, @Date2 = C.fechaFinal + ' ' + C.horaFinal from SolicitudPreventiva as S inner join CierreSolicitud as C on S.idSolicitud = C.idCierre where S.idSolicitud=" + id2 + " select S.idSolicitud, S.fechaSolicitud, S.horaSolicitud, C.fechaFinal, C.horaFinal, DATEDIFF(MINUTE, @Date1, @Date2) AS[totalMinutos] from SolicitudPreventiva as S inner join CierreSolicitud as C on S.idSolicitud = C.idCierre where S.idSolicitud =" + id2, conn);

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    //solicitud
                    int idSolicitud = dr.GetInt32(0);
                    string fechaSolicitud = dr.GetString(1).Trim();
                    string horaSolicitud = dr.GetString(2).Trim();
                    string fechaFinal = dr.GetString(3).Trim();
                    string horaFinal = dr.GetString(4).Trim();
                    int totalMinutos = dr.GetInt32(5);

                    tiempos Tiempos = new tiempos(idSolicitud,
                    fechaSolicitud,
                    horaSolicitud,
                    fechaFinal,
                    horaFinal,
                    totalMinutos
                                      );

                    lista.Add(Tiempos);
                }
                dr.Close();
                conn.Close();
            }
            return lista;
        }




    }
}