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
    public class GestorMecanicos
    {
        public List<mecanicos> GetMecanicos()
        {
            List<mecanicos> lista = new List<mecanicos>();
            string strConn = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "MecanicosMantenimiento_All";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    //solicitud
                    int idMecanico = dr.GetInt32(0);
                    string nombre = dr.GetString(1).Trim();
                    string area = dr.GetString(2).Trim();


                    mecanicos Mecanicos = new mecanicos(
                   idMecanico,
                    nombre,
                    area
                        );

                    lista.Add(Mecanicos);
                }
                dr.Close();
                conn.Close();
            }
            return lista;
        }

        public bool addMecanicos(mecanicos Mecanicos)
        {
            bool res = false;
            string strConn = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                SqlCommand cmd = conn.CreateCommand();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                cmd.CommandText = "MecanicosMantenimientoAdd";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", Mecanicos.nombre);
                cmd.Parameters.AddWithValue("@nomina", Mecanicos.nomina);
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


        public bool updateMecanicos(int id, mecanicos Mecanicos)
        {
            bool res = false;
            string strConn = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                SqlCommand cmd = conn.CreateCommand();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                cmd.CommandText = "MecanicosUpdate";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id", id);

                cmd.Parameters.AddWithValue("@nombre", Mecanicos.nombre);

                cmd.Parameters.AddWithValue("@nomina", Mecanicos.nomina);

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