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
    public class GestorDispositivos
    {
        public List<dispositivos> GetDispositivos()
        {
            List<dispositivos> lista = new List<dispositivos>();
            string strConn = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "DispositivosMantenimiento_All";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    //solicitud
                    int idDispositivo = dr.GetInt32(0);
                    string nombre = dr.GetString(1).Trim();
                    string maquina = dr.GetString(2).Trim();
                    string codigo = dr.GetString(3).Trim();
                    string area = dr.GetString(4).Trim();


                    dispositivos Dispositivos = new dispositivos(
                   idDispositivo,
                    nombre,
                    maquina, 
                    codigo,
                    area
                        );

                    lista.Add(Dispositivos);
                }
                dr.Close();
                conn.Close();
            }
            return lista;
        }

        public bool addDispositivos(dispositivos Dispositivos)
        {
            bool res = false;
            string strConn = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                SqlCommand cmd = conn.CreateCommand();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                cmd.CommandText = "DispositivosMantenimientoAdd";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", Dispositivos.nombre);
                cmd.Parameters.AddWithValue("@maquina", Dispositivos.maquina);
                cmd.Parameters.AddWithValue("@codigo", Dispositivos.codigo);
                cmd.Parameters.AddWithValue("@area", Dispositivos.area);
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