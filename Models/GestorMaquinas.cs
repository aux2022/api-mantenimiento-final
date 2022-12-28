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
    public class GestorMaquinas
    {
        public List<maquinas> GetMaquinas()
        {
            List<maquinas> lista = new List<maquinas>();
            string strConn = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "MaquinasMantenimiento_All";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    //solicitud
                    int idMaquina = dr.GetInt32(0);
                    string nombre = dr.GetString(1).Trim();
                    string area = dr.GetString(2).Trim();
                    string codigo = dr.GetString(3).Trim();
                    string  statusMaquina= dr.GetString(4).Trim();


                    maquinas Maquinas = new maquinas(
                   idMaquina,
                    nombre,
                    area,
                    codigo, 
                    statusMaquina
                        );

                    lista.Add(Maquinas);
                }
                dr.Close();
                conn.Close();
            }
            return lista;
        }

        public List<maquinas> GetMaquinas2(string id2)
        {
            List<maquinas> lista = new List<maquinas>();
            string strConn = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from Maquinas\r\n where area="+id2, conn);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    //solicitud
                    int idMaquina = dr.GetInt32(0);
                    string nombre = dr.GetString(1).Trim();
                    string area = dr.GetString(2).Trim();
                    string codigo = dr.GetString(3).Trim();
                    string statusMaquina = dr.GetString(4).Trim();


                    maquinas Maquinas = new maquinas(
                   idMaquina,
                    nombre,
                    area,
                    codigo,
                    statusMaquina
                    
                        );

                    lista.Add(Maquinas);
                }
                dr.Close();
                conn.Close();
            }
            return lista;
        }

        public bool addMaquinas(maquinas Maquinas)
        {
            bool res = false;
            string strConn = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                SqlCommand cmd = conn.CreateCommand();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                cmd.CommandText = "MaquinasMantenimientoAdd";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", Maquinas.nombre);
                cmd.Parameters.AddWithValue("@area", Maquinas.area);
                cmd.Parameters.AddWithValue("@codigo", Maquinas.codigo);
                cmd.Parameters.AddWithValue("@statusMaquina", Maquinas.statusMaquina);
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



        public bool updateMaquinas(int id, maquinas Maquinas)
        {
            bool res = false;
            string strConn = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                SqlCommand cmd = conn.CreateCommand();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                cmd.CommandText = "MaquinasUpdate";

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@idMaquina", id);

                cmd.Parameters.AddWithValue("@nombre", Maquinas.nombre);

                cmd.Parameters.AddWithValue("@area", Maquinas.area);

                cmd.Parameters.AddWithValue("@codigo", Maquinas.codigo);

                cmd.Parameters.AddWithValue("@statusMaquina", Maquinas.statusMaquina);

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

        public bool deleteMaquina(int id)
        {
            bool res = false;
            string strConn = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                SqlCommand cmd = conn.CreateCommand();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                cmd.CommandText = "MaquinaDelete";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);

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