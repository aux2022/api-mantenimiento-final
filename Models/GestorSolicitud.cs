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
        public List<lotes> GetSolicituds()
        {
            List<lotes> lista = new List<lotes>();
            string strConn = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "All_Lotes";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    //solicitud

                    string lote = dr.GetString(0).Trim();
                    int orden = dr.GetInt32(1);
                    string producto = dr.GetString(2);
                    string codigo = dr.GetString(3);
                    decimal kg = dr.GetDecimal(4);
                    decimal mts = dr.GetDecimal(5);
                    string almacen = dr.GetString(6).Trim();
                    string status = dr.GetString(7).Trim();
                    

                    lotes Lotes = new lotes(
                   lote,
                   orden,
                   producto,
                   codigo,
                   kg,
                   mts,
                   almacen,
                   status
                        );

                    lista.Add(Lotes);
                }
                dr.Close();
                conn.Close();
            }
            return lista;
        }


        public bool updateSolicitud(string lotes, lotes Lotes)
        {
            bool res = false;
            string strConn = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                SqlCommand cmd = conn.CreateCommand();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                cmd.CommandText = "Update_Lotes";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@lote", lotes);
                cmd.Parameters.AddWithValue("@orden", Lotes.orden);
                cmd.Parameters.AddWithValue("@producto", Lotes.producto);
                cmd.Parameters.AddWithValue("@codigo", Lotes.codigo);
                cmd.Parameters.AddWithValue("@kg", Lotes.kg);
                cmd.Parameters.AddWithValue("@mts", Lotes.mts);
                cmd.Parameters.AddWithValue("@almacen", Lotes.almacen);
                cmd.Parameters.AddWithValue("@status", Lotes.status);
  

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

        public bool addSolicitud(lotes Lotes)
        {
            bool res = false;
            string strConn = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                SqlCommand cmd = conn.CreateCommand();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                cmd.CommandText = "Add_Lotes";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@lote", Lotes.lote);
                cmd.Parameters.AddWithValue("@orden", Lotes.orden);
                cmd.Parameters.AddWithValue("@producto", Lotes.producto);
                cmd.Parameters.AddWithValue("@codigo", Lotes.codigo);
                cmd.Parameters.AddWithValue("@kg", Lotes.kg);
                cmd.Parameters.AddWithValue("@mts", Lotes.mts);
                cmd.Parameters.AddWithValue("@almacen", Lotes.almacen);
                cmd.Parameters.AddWithValue("@status", Lotes.status);

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