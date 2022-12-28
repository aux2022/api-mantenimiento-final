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
    public class GestorSolicitudPreventiva

    {
        public List<solicitudPreventiva> GetSolicituds()
        {
            List<solicitudPreventiva> lista = new List<solicitudPreventiva>();
            string strConn = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "solicitudMantenimiento_All";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    //solicitud
                    int idSolicitud = dr.GetInt32(0);
                    string nombreSolicitante = dr.GetString(1).Trim();
                    string correo = dr.GetString(2).Trim();
                    string fechaSolicitud = dr.GetString(3).Trim();
                    string horaSolicitud = dr.GetString(4).Trim();
                    string area = dr.GetString(5).Trim();
                    string maquina = dr.GetString(6).Trim();
                    string dispositivo = dr.GetString(7).Trim();
                    string descripcionProblema = dr.GetString(8).Trim();



                    solicitudPreventiva SolicitudPreventiva = new solicitudPreventiva(
                    idSolicitud,
                    nombreSolicitante,
                    correo,
                    fechaSolicitud,
                    horaSolicitud,
                    area,
                    maquina,
                    dispositivo,
                    descripcionProblema


                        );

                    lista.Add(SolicitudPreventiva);
                }
                dr.Close();
                conn.Close();
            }
            return lista;
        }

        /*Empieza*/
        public List<solicitudPreventiva> GetSolicitudsById(int id2)
        {

            List<solicitudPreventiva> lista = new List<solicitudPreventiva>();

            string strConn = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("select * from SolicitudPreventiva where idSolicitud =" + id2, conn);

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    //solicitud
                    int idSolicitud = dr.GetInt32(0);
                    string nombreSolicitante = dr.GetString(1).Trim();
                    string correo = dr.GetString(2).Trim();
                    string fechaSolicitud = dr.GetString(3).Trim();
                    string horaSolicitud = dr.GetString(4).Trim();
                    string area = dr.GetString(5).Trim();
                    string maquina = dr.GetString(6).Trim();
                    string dispositivo = dr.GetString(7).Trim();
                    string descripcionProblema = dr.GetString(8).Trim();




                    solicitudPreventiva SolicitudPreventiva = new solicitudPreventiva(idSolicitud,
                    nombreSolicitante,
                    correo,
                    fechaSolicitud,
                    horaSolicitud,
                    area,
                    maquina,
                    dispositivo,
                    descripcionProblema
                   );

                    lista.Add(SolicitudPreventiva);
                }
                dr.Close();
                conn.Close();
            }
            return lista;
        }/*Termina*/

       


        public bool addSolicitud2(solicitudPreventiva SolicitudPreventiva)
        {
            bool res = false;
            string strConn = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                SqlCommand cmd = conn.CreateCommand();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                cmd.CommandText = "solicitudMantenimientoAdd";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@idSolicitud", SolicitudPreventiva.idSolicitud);

                cmd.Parameters.AddWithValue("@nombreSolicitante", SolicitudPreventiva.nombreSolicitante);

                cmd.Parameters.AddWithValue("@correoSolicitante", SolicitudPreventiva.correo);

                cmd.Parameters.AddWithValue("@fechaSolicitud", SolicitudPreventiva.fechaSolicitud);

                cmd.Parameters.AddWithValue("@horaSolicitud", SolicitudPreventiva.horaSolicitud);

                cmd.Parameters.AddWithValue("@area", SolicitudPreventiva.area);

                cmd.Parameters.AddWithValue("@maquina", SolicitudPreventiva.maquina);

                cmd.Parameters.AddWithValue("@dispositivo", SolicitudPreventiva.dispositivo);

                cmd.Parameters.AddWithValue("@descripcionProblema", SolicitudPreventiva.descripcionProblema);

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


        public bool updateSolicitud2(int id, solicitudPreventiva SolicitudPreventiva)
        {
            bool res = false;
            string strConn = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                SqlCommand cmd = conn.CreateCommand();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                cmd.CommandText = "solicitudUpdate";

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@idSolicitud", id);

                cmd.Parameters.AddWithValue("@nombreSolicitante", SolicitudPreventiva.nombreSolicitante);

                cmd.Parameters.AddWithValue("@correoSolicitante", SolicitudPreventiva.correo);

                cmd.Parameters.AddWithValue("@fechaSolicitud", SolicitudPreventiva.fechaSolicitud);

                cmd.Parameters.AddWithValue("@horaSolicitud", SolicitudPreventiva.horaSolicitud);

                cmd.Parameters.AddWithValue("@area", SolicitudPreventiva.area);

                cmd.Parameters.AddWithValue("@maquina", SolicitudPreventiva.maquina);

                cmd.Parameters.AddWithValue("@dispositivo", SolicitudPreventiva.dispositivo);

                cmd.Parameters.AddWithValue("@descripcionProblema", SolicitudPreventiva.descripcionProblema);


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

        public bool deleteSolicitud(int id)
        {
            bool res = false;
            string strConn = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                SqlCommand cmd = conn.CreateCommand();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                cmd.CommandText = "solicitudMantenimientoDelete";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_solicitud", id);

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