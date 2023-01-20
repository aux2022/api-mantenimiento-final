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
                    string puesto = dr.GetString(3);
                    string area = dr.GetString(4);
                    string jefe = dr.GetString(5);
                    string fechaSolicitud = dr.GetString(6).Trim();
                    string fechaInicio = dr.GetString(7).Trim();
                    string fechaRegreso = dr.GetString(8).Trim();
                    int diasTotales = dr.GetInt32(9);
                    string descripcion = dr.GetString(10).Trim();
                    string estatusJefe = dr.GetString(11).Trim();
                    string estatusRH = dr.GetString(12).Trim();
                    string estatusFinal = dr.GetString(13).Trim();
                    string comentariosRH = dr.GetString(14).Trim();
                    string comentariosJefe = dr.GetString(15).Trim();
                    string tipo = dr.GetString(16).Trim();

                    solicitud Solicitud = new solicitud(
                   noSolicitud,
                   noNomina,
                   nombre,
                   puesto,
                   area,
                   jefe,
                   fechaSolicitud,
                   fechaInicio,
                   fechaRegreso,
                   diasTotales,
                   descripcion,
                   estatusJefe,
                   estatusRH,
                   estatusFinal,
                   comentariosRH,
                   comentariosJefe,
                   tipo
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

                SqlCommand cmd = new SqlCommand("select s.noSolicitud, s.noNomina, e.nombre, e.puesto, e.area, e.jefe, CONVERT(VARCHAR, CAST(s.fechaSolicitud as date), 101) AS fechaSolicitud, CONVERT(VARCHAR, CAST(s.fechaInicio as date), 101) AS fechaInicio, CONVERT(VARCHAR, CAST(s.fechaRegreso as date), 101) AS fechaRegreso, s.diasTotales, s.descripcion, s.estatusJefe, s.estatusRH, s.estatusFinal, s.comentariosRH, s.comentariosJefe, s.tipo from Solicitud as s inner join Empleado as e on s.noNomina =e.noNomina where noSolicitud="+id2+"\r\n\r\norder by s.noSolicitud", conn);

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    //solicitud
                    int noSolicitud = dr.GetInt32(0);
                    int noNomina = dr.GetInt32(1);
                    string nombre = dr.GetString(2);
                    string puesto = dr.GetString(3);
                    string area = dr.GetString(4);
                    string jefe = dr.GetString(5);
                    string fechaSolicitud = dr.GetString(6).Trim();
                    string fechaInicio = dr.GetString(7).Trim();
                    string fechaRegreso = dr.GetString(8).Trim();
                    int diasTotales = dr.GetInt32(9);
                    string descripcion = dr.GetString(10).Trim();
                    string estatusJefe = dr.GetString(11).Trim();
                    string estatusRH = dr.GetString(12).Trim();
                    string estatusFinal = dr.GetString(13).Trim();
                    string comentariosRH = dr.GetString(14).Trim();
                    string comentariosJefe = dr.GetString(15).Trim(); 
                    string tipo = dr.GetString(16).Trim();

                    solicitud Solicitud = new solicitud(
                   noSolicitud,
                   noNomina,
                   nombre,
                   puesto,
                   area,
                   jefe,
                   fechaSolicitud,
                   fechaInicio,
                   fechaRegreso,
                   diasTotales,
                   descripcion,
                   estatusJefe,
                   estatusRH,
                   estatusFinal,
                   comentariosRH,
                   comentariosJefe,
                   tipo
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

                SqlCommand cmd = new SqlCommand("select  e.noNomina, e.contrasena, e.nombre, e.puesto, e.area, e.jefe, e.correoJefe from Empleado as e where e.noNomina=" + id2 + "\r\n\r\n order by e.noNomina desc", conn);

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    //control
                    int noNomina = dr.GetInt32(0);
                    string contrasena = dr.GetString(1).Trim();
                    string nombre = dr.GetString(2).Trim();
                    string puesto = dr.GetString(3).Trim();
                    string area = dr.GetString(4).Trim();
                    string jefe = dr.GetString(5).Trim();
                    string correoJefe = dr.GetString(6).Trim();

                    empleado Solicitud = new empleado(
                   noNomina,
                   contrasena,
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

                SqlCommand cmd = new SqlCommand("select c.noNomina, c.ingreso, c.antiguedad, c.diasDerecho, c.diasDisfrutados, c.diasPendientes, c.ingresoExterno from Control as c where c.noNomina=" + id2 + "\r\n\r\n order by c.noNomina desc", conn);

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    //control
                    int noNomina = dr.GetInt32(0);
                    string ingreso = dr.GetString(1).Trim();
                    int antiguedad = dr.GetInt32(2);
                    int diasDerecho = dr.GetInt32(3);
                    int diasDisfrutados = dr.GetInt32(4);
                    int diasPendientes = dr.GetInt32(5);
                    string ingresoExterno = dr.GetString(6).Trim();

                    control Solicitud = new control(
                   noNomina,
                   ingreso,
                   antiguedad,
                   diasDerecho,
                   diasDisfrutados,
                   diasPendientes, 
                   ingresoExterno
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
                    string ingreso = dr.GetString(1).Trim();
                    int antiguedad = dr.GetInt32(2);
                    int diasDerecho = dr.GetInt32(3);
                    int diasDisfrutados = dr.GetInt32(4);
                    int diasPendientes = dr.GetInt32(5);
                    string ingresoExterno = dr.GetString(6).Trim();

                    control Solicitud = new control(
                   noNomina,
                   ingreso, 
                   antiguedad, 
                   diasDerecho,
                   diasDisfrutados,
                   diasPendientes,
                   ingresoExterno
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
                    string contrasena = dr.GetString(1).Trim();
                    string nombre = dr.GetString(2).Trim();
                    string puesto = dr.GetString(3).Trim();
                    string area = dr.GetString(4).Trim();
                    string jefe = dr.GetString(5).Trim();
                    string correoJefe = dr.GetString(6).Trim();

                    empleado Solicitud = new empleado(
                   noNomina,
                   contrasena,
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
                cmd.Parameters.AddWithValue("@tipo", Solicitud.tipo);

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
                cmd.Parameters.AddWithValue("@contrasena", Empleado.contrasena);
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
                cmd.Parameters.AddWithValue("@ingresoExterno", Control.ingresoExterno);

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
                cmd.Parameters.AddWithValue("@tipo", Solicitud.tipo);

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

        public bool addEmpleado(empleado Empleado)
        {
            bool res = false;
            string strConn = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                SqlCommand cmd = conn.CreateCommand();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                cmd.CommandText = "add_Empleado";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@noNomina", Empleado.noNomina);
                cmd.Parameters.AddWithValue("@contrasena", Empleado.contrasena);
                cmd.Parameters.AddWithValue("@nombre", Empleado.nombre);
                cmd.Parameters.AddWithValue("@puesto", Empleado.puesto);
                cmd.Parameters.AddWithValue("@area", Empleado.area);
                cmd.Parameters.AddWithValue("@jefe",Empleado.jefe);
                cmd.Parameters.AddWithValue("@correoJefe", Empleado.correoJefe);
             

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

        public bool addControl(control Control)
        {
            bool res = false;
            string strConn = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                SqlCommand cmd = conn.CreateCommand();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                cmd.CommandText = "add_Control";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@noNomina", Control.noNomina);
                cmd.Parameters.AddWithValue("@ingreso", Control.ingreso);
                cmd.Parameters.AddWithValue("@antiguedad", Control.antiguedad);
                cmd.Parameters.AddWithValue("@diasDerecho", Control.diasDerecho);
                cmd.Parameters.AddWithValue("@diasDisfrutados", Control.diasDisfrutados);
                cmd.Parameters.AddWithValue("@diasPendientes", Control.diasPendientes);

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