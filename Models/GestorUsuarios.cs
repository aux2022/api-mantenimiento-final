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
    public class GestorUsuarios
    {
        public List<usuarios> GetUsuarios()
        {
            List<usuarios> lista = new List<usuarios>();
            string strConn = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "UsuariosMantenimiento_All";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    //solicitud
                    int idUsuario = dr.GetInt32(0);
                    string usuario = dr.GetString(1).Trim();
                    string contrasena = dr.GetString(2).Trim();
                    string rol = dr.GetString(3).Trim();
                    string nomina3=dr.GetString(4).Trim();

                    usuarios Usuarios = new usuarios(
                   idUsuario,
                    usuario,
                    contrasena,
                    rol, 
                    nomina3
                        );

                    lista.Add(Usuarios);
                }
                dr.Close();
                conn.Close();
            }
            return lista;
        }

        public List<usuarios> GetSolicitudsByIdUser(int id2)
        {

            List<usuarios> lista = new List<usuarios>();
            string strConn = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("select * from Usuarios where idUsuario=" + id2, conn);

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    //solicitud
                    int idUsuario = dr.GetInt32(0);
                    string usuario = dr.GetString(1).Trim();
                    string contrasena = dr.GetString(2).Trim();
                    string rol = dr.GetString(3).Trim();
                    string nomina3 = dr.GetString(4).Trim();


                    usuarios Usuarios = new usuarios(
                        idUsuario, usuario, contrasena, rol, nomina3);

                    lista.Add(Usuarios);
                }
                dr.Close();
                conn.Close();
            }
            return lista;
        } 

        public bool addUsuarios(usuarios Usuarios)
        {
            bool res = false;
            string strConn = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                SqlCommand cmd = conn.CreateCommand();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                cmd.CommandText = "UsuariosMantenimientoAdd";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@usuario", Usuarios.usuario);
                cmd.Parameters.AddWithValue("@contrasena", Usuarios.contrasena);
                cmd.Parameters.AddWithValue("@rol", Usuarios.rol);
                cmd.Parameters.AddWithValue("@nomina3", Usuarios.nombre3);
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