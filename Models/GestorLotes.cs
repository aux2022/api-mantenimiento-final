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
    public class GestorLotes
    {
        public List<lote> GetSolicituds()
        {
            List<lote> lista = new List<lote>();
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

                    int id = dr.GetInt32(0);

                    string lote2 = dr.GetString(1).Trim();
                    int orden = dr.GetInt32(2);
                    string producto = dr.GetString(3);
                    string codigo = dr.GetString(4);
                    double kg = dr.GetDouble(5);
                    double mts = dr.GetDouble(6);
                    string almacen = dr.GetString(7).Trim();
                    string status = dr.GetString(8).Trim();
                    

                    lote Lotes = new lote(
                        id,
                   lote2,
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


        public bool updateLotes(int id2, lote Lotes)
        {
            bool res = false;
            string strConn = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                SqlCommand cmd = conn.CreateCommand();


                //


                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                //


                cmd.CommandText = "Update_Lotes";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id2);
                cmd.Parameters.AddWithValue("@lote2", Lotes.lote2);
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


        public bool addLotes(lote Lotes)
        {
            bool res = false;
            string strConn = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            using (SqlConnection conn = new SqlConnection(strConn))
            {


                SqlCommand cmd = conn.CreateCommand();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                cmd.CommandText = "Add_Lotes";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@lote2", Lotes.lote2);
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