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
    public class GestorSolicitud
    {
        public List<solicitud> GetSolicituds()
        {
            List<solicitud> lista = new List<solicitud>();
            string strConn = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "vacaciones_All";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    //solicitud
                    int noSolicitud = dr.GetInt32(0);
                    int noNomina = dr.GetInt32(1);
                    string nombre = dr.GetString(2);
                    string fechaSolicitud = dr.GetString(3).Trim();
                    string fechaInicio = dr.GetString(4).Trim();
                    string fechaRegreso = dr.GetString(5).Trim();
                    int diasTotales = dr.GetInt32(6);
                    string descripcion = dr.GetString(7).Trim();
                    string estatusJefe = dr.GetString(8).Trim();
                    string estatusRH = dr.GetString(9).Trim();
                    string estatusFinal = dr.GetString(10).Trim();
                    string comentariosRH = dr.GetString(11).Trim();
                    string comentariosJefe = dr.GetString(12).Trim();

                    solicitud Solicitud = new solicitud(
                   noSolicitud,
                   noNomina,
                   nombre,
                   fechaSolicitud,
                   fechaInicio,
                   fechaRegreso,
                   diasTotales,
                   descripcion,
                   estatusJefe,
                   estatusRH,
                   estatusFinal,
                   comentariosRH,
                   comentariosJefe  
                        );

                    lista.Add(Solicitud);
                }
                dr.Close();
                conn.Close();
            }
            return lista;
        }


        public List<solicitud> GetVacacionesById(int id2)
        {

            List<solicitud> lista = new List<solicitud>();
            string strConn = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("select s.noSolicitud, s.noNomina, e.nombre, CONVERT(VARCHAR, CAST(s.fechaSolicitud as date), 101) AS fechaSolicitud, CONVERT(VARCHAR, CAST(s.fechaInicio as date), 101) AS fechaInicio, CONVERT(VARCHAR, CAST(s.fechaRegreso as date), 101) AS fechaRegreso, s.diasTotales, s.descripcion, s.estatusJefe, s.estatusRH, s.estatusFinal, s.comentariosRH, s.comentariosJefe from Solicitud as s inner join Empleado as e on s.noNomina =e.noNomina where noSolicitud="+id2+"\r\n\r\norder by s.noSolicitud", conn);

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    //solicitud
                    int noSolicitud = dr.GetInt32(0);
                    int noNomina = dr.GetInt32(1);
                    string nombre = dr.GetString(2);
                    string fechaSolicitud = dr.GetString(3).Trim();
                    string fechaInicio = dr.GetString(4).Trim();
                    string fechaRegreso = dr.GetString(5).Trim();
                    int diasTotales = dr.GetInt32(6);
                    string descripcion = dr.GetString(7).Trim();
                    string estatusJefe = dr.GetString(8).Trim();
                    string estatusRH = dr.GetString(9).Trim();
                    string estatusFinal = dr.GetString(10).Trim();
                    string comentariosRH = dr.GetString(11).Trim();
                    string comentariosJefe = dr.GetString(12).Trim();

                    solicitud Solicitud = new solicitud(
                   noSolicitud,
                   noNomina,
                   nombre,
                   fechaSolicitud,
                   fechaInicio,
                   fechaRegreso,
                   diasTotales,
                   descripcion,
                   estatusJefe,
                   estatusRH,
                   estatusFinal,
                   comentariosRH,
                   comentariosJefe
                        );


                    lista.Add(Solicitud);
                }
                dr.Close();
                conn.Close();
            }
            return lista;
        }
        //
        public List<empleado> GetEmpleadoById(int id2)
        {

            List<empleado> lista = new List<empleado>();
            string strConn = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("select e.noNomina, e.nombre, e.puesto, e.area, e.jefe, e.correoJefe from Empleado as e where e.noNomina=" + id2 + "\r\n\r\n order by e.noNomina desc", conn);

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    //control
                    int noNomina = dr.GetInt32(0);
                    string nombre = dr.GetString(1).Trim();
                    string puesto = dr.GetString(2).Trim();
                    string area = dr.GetString(3).Trim();
                    string jefe = dr.GetString(4).Trim();
                    string correoJefe = dr.GetString(5).Trim();

                    empleado Solicitud = new empleado(
                   noNomina,
                 nombre,
                 puesto,
                 area,
                 jefe,
                 correoJefe
                        );

                    lista.Add(Solicitud);
                }
                dr.Close();
                conn.Close();
            }
            return lista;
        }
        //
        public List<control> GetControlById(int id2)
        {

            List<control> lista = new List<control>();
            string strConn = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("select c.noNomina, CONVERT(VARCHAR, CAST(c.ingreso as date), 101) AS ingreso, c.antiguedad, c.diasDerecho, c.diasDisfrutados, c.diasPendientes from Control as c where c.noNomina=" + id2 + "\r\n\r\n order by c.noNomina desc", conn);

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    //control
                    int noNomina = dr.GetInt32(0);
                    string ingreso = dr.GetString(1);
                    int antiguedad = dr.GetInt32(2);
                    int diasDerecho = dr.GetInt32(3);
                    int diasDisfrutados = dr.GetInt32(4);
                    int diasPendientes = dr.GetInt32(5);

                    control Solicitud = new control(
                   noNomina,
                   ingreso,
                   antiguedad,
                   diasDerecho,
                   diasDisfrutados,
                   diasPendientes
                        );

                    lista.Add(Solicitud);
                }
                dr.Close();
                conn.Close();
            }
            return lista;
        }
        //

        public List<control> GetControls()
        {
            List<control> lista = new List<control>();
            string strConn = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "control_All";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    //control
                    int noNomina = dr.GetInt32(0);
                    string ingreso = dr.GetString(1);
                    int antiguedad = dr.GetInt32(2);
                    int diasDerecho = dr.GetInt32(3);
                    int diasDisfrutados = dr.GetInt32(4);
                    int diasPendientes = dr.GetInt32(5);

                    control Solicitud = new control(
                   noNomina,
                   ingreso, 
                   antiguedad, 
                   diasDerecho,
                   diasDisfrutados,
                   diasPendientes
                        );

                    lista.Add(Solicitud);
                }
                dr.Close();
                conn.Close();
            }
            return lista;
        }

        public List<empleado> GetEmpleados()
        {
            List<empleado> lista = new List<empleado>();
            string strConn = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "empleado_All";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    //control
                    int noNomina = dr.GetInt32(0);
                    string nombre = dr.GetString(1).Trim();
                    string puesto = dr.GetString(2).Trim();
                    string area = dr.GetString(3).Trim();
                    string jefe = dr.GetString(4).Trim();
                    string correoJefe = dr.GetString(5).Trim();

                    empleado Solicitud = new empleado(
                   noNomina,
                 nombre,
                 puesto,
                 area,
                 jefe, 
                 correoJefe
                        );

                    lista.Add(Solicitud);
                }
                dr.Close();
                conn.Close();
            }
            return lista;
        }

        //
        public bool updateSolicitud(int id, solicitud Solicitud)
        {
            bool res = false;
            string strConn = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                SqlCommand cmd = conn.CreateCommand();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                cmd.CommandText = "solicitudUpdate";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id", id);

                cmd.Parameters.AddWithValue("@noNomina", Solicitud.noNomina);
                cmd.Parameters.AddWithValue("@fechaSolicitud", Solicitud.fechaSolicitud);
                cmd.Parameters.AddWithValue("@fechaInicio", Solicitud.fechaInicio);
                cmd.Parameters.AddWithValue("@fechaRegreso", Solicitud.fechaRegreso);
                cmd.Parameters.AddWithValue("@diasTotales", Solicitud.diasTotales);
                cmd.Parameters.AddWithValue("@descripcion", Solicitud.descripcion);
                cmd.Parameters.AddWithValue("@estatusJefe", Solicitud.estatusJefe);
                cmd.Parameters.AddWithValue("@estatusRH", Solicitud.estatusRH);
                cmd.Parameters.AddWithValue("@estatusFinal", Solicitud.estatusFinal);
                cmd.Parameters.AddWithValue("@comentarioRH", Solicitud.comentarioRH);
                cmd.Parameters.AddWithValue("@comentarioJefe", Solicitud.comentarioJefe);

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
        //

        public bool updateEmpleado(int id, empleado Empleado)
        {
            bool res = false;
            string strConn = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                SqlCommand cmd = conn.CreateCommand();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                cmd.CommandText = "empleadoUpdate";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@noNomina", id);

                cmd.Parameters.AddWithValue("@nombre", Empleado.nombre);
                cmd.Parameters.AddWithValue("@puesto", Empleado.puesto);
                cmd.Parameters.AddWithValue("@area", Empleado.area);
                cmd.Parameters.AddWithValue("@jefe", Empleado.jefe);
                cmd.Parameters.AddWithValue("@correoJefe", Empleado.correoJefe);

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
        //
        public bool updateControl(int id, control Control)
        {
            bool res = false;
            string strConn = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                SqlCommand cmd = conn.CreateCommand();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                cmd.CommandText = "controlUpdate";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@noNomina", id);
                cmd.Parameters.AddWithValue("@ingreso", Control.ingreso);
                cmd.Parameters.AddWithValue("@antiguedad", Control.antiguedad);
                cmd.Parameters.AddWithValue("@diasDerecho", Control.diasDerecho);
                cmd.Parameters.AddWithValue("@diasDisfrutados", Control.diasDisfrutados);
                cmd.Parameters.AddWithValue("@diasPendientes", Control.diasPendientes);

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
        //

        public bool addSolicitud(solicitud Solicitud)
        {
            bool res = false;
            string strConn = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                SqlCommand cmd = conn.CreateCommand();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                cmd.CommandText = "add_Solicitud";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@noNomina", Solicitud.noNomina);
                cmd.Parameters.AddWithValue("@fechaSolicitud", Solicitud.fechaSolicitud);
                cmd.Parameters.AddWithValue("@fechaInicio", Solicitud.fechaInicio);
                cmd.Parameters.AddWithValue("@fechaRegreso", Solicitud.fechaRegreso);
                cmd.Parameters.AddWithValue("@diasTotales", Solicitud.diasTotales);
                cmd.Parameters.AddWithValue("@descripcion", Solicitud.descripcion);
                cmd.Parameters.AddWithValue("@estatusJefe", Solicitud.estatusJefe);
                cmd.Parameters.AddWithValue("@estatusRH", Solicitud.estatusRH);
                cmd.Parameters.AddWithValue("@estatusFinal", Solicitud.estatusFinal);
                cmd.Parameters.AddWithValue("@comentarioRH", Solicitud.comentarioRH);
                cmd.Parameters.AddWithValue("@comentarioJefe", Solicitud.comentarioJefe);

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