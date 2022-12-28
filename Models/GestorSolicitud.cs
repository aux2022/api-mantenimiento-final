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


                    //diagnostico
                    int nomina = dr.GetInt32(9);
                    string nombre = dr.GetString(10).Trim();
                    string fechaInicio = dr.GetString(11).Trim();
                    string horaInicio = dr.GetString(12).Trim();
                    string diagnostico = dr.GetString(13).Trim();
                    string tipoFalla = dr.GetString(14).Trim();
                    string emailSent = dr.GetString(15).Trim();
                    int nomina2 = dr.GetInt32(16);
                    string nombre2 = dr.GetString(17).Trim();
                    string asignacion = dr.GetString(18).Trim();

                    //reparacion
                    string tareasEjecutadas= dr.GetString(19).Trim();
                    string generoParo = dr.GetString(20).Trim();
                    int paroCorrectivo = dr.GetInt32(21);
                    int paroOperativo = dr.GetInt32(22);
                    int paroRefaccion = dr.GetInt32(23);
                    int tiempoTotal= dr.GetInt32(24);
                    string grasaUtilizada = dr.GetString(25).Trim();
                    string refaMateHerra = dr.GetString(26).Trim();

                    //cierre solicitud
                    string fechaFinal = dr.GetString(27).Trim();
                    string horaFinal = dr.GetString(28).Trim();         
                    string trabajoSanitizado = dr.GetString(29).Trim();
                    string estatusActividad = dr.GetString(30).Trim();
                    string firmaSolicitante= dr.GetString(31).Trim();
                    string nombre3 = dr.GetString(32).Trim();
                    string emailSent2 = dr.GetString(33).Trim();
                    string fechaFirma = dr.GetString(34).Trim();
                    string horaFirma = dr.GetString(35).Trim();
                    string comentariosSolicitante = dr.GetString(36).Trim();

                    solicitud Solicitud = new solicitud(
                    idSolicitud,
                    nombreSolicitante,
                    correo,
                    fechaSolicitud,
                    horaSolicitud,
                    area,
                    maquina,
                    dispositivo,
                    descripcionProblema,
                    //diagnostico
                    nomina,
                    nombre,
                    fechaInicio,
                    horaInicio,
                    diagnostico,
                    tipoFalla,
                    emailSent,
                    nomina2,
                    nombre2,
                    asignacion,
                    

                    //reparacion
                    tareasEjecutadas,
                    generoParo,
                    paroCorrectivo,
                    paroOperativo,
                    paroRefaccion,
                    tiempoTotal,
                    grasaUtilizada,
                    refaMateHerra,

                    //cierreSolicitud
                    fechaFinal,
                    horaFinal,
                    trabajoSanitizado,
                    estatusActividad,
                    firmaSolicitante,
                    nombre3,
                    emailSent2,
                    fechaFirma,
                    horaFirma,
                    comentariosSolicitante
                        
                        );

                    lista.Add(Solicitud);
                }
                dr.Close();
                conn.Close();
            }
            return lista;
        }/*T*/
        public List<solicitud> GetSolicitudsTrabajoTemp()
        {
            List<solicitud> lista = new List<solicitud>();
            string strConn = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "solicutudes_Trabajotemp";
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


                    //diagnostico
                    int nomina = dr.GetInt32(9);
                    string nombre = dr.GetString(10).Trim();
                    string fechaInicio = dr.GetString(11).Trim();
                    string horaInicio = dr.GetString(12).Trim();
                    string diagnostico = dr.GetString(13).Trim();
                    string tipoFalla = dr.GetString(14).Trim();
                    string emailSent = dr.GetString(15).Trim();
                    int nomina2 = dr.GetInt32(16);
                    string nombre2 = dr.GetString(17).Trim();
                    string asignacion = dr.GetString(18).Trim();

                    //reparacion
                    string tareasEjecutadas = dr.GetString(19).Trim();
                    string generoParo = dr.GetString(20).Trim();
                    int paroCorrectivo = dr.GetInt32(21);
                    int paroOperativo = dr.GetInt32(22);
                    int paroRefaccion = dr.GetInt32(23);
                    int tiempoTotal = dr.GetInt32(24);
                    string grasaUtilizada = dr.GetString(25).Trim();
                    string refaMateHerra = dr.GetString(26).Trim();

                    //cierre solicitud
                    string fechaFinal = dr.GetString(27).Trim();
                    string horaFinal = dr.GetString(28).Trim();
                    string trabajoSanitizado = dr.GetString(29).Trim();
                    string estatusActividad = dr.GetString(30).Trim();
                    string firmaSolicitante = dr.GetString(31).Trim();
                    string nombre3 = dr.GetString(32).Trim();
                    string emailSent2 = dr.GetString(33).Trim();
                    string fechaFirma = dr.GetString(34).Trim();
                    string horaFirma = dr.GetString(35).Trim();
                    string comentariosSolicitante = dr.GetString(36).Trim();

                    solicitud Solicitud = new solicitud(
                    idSolicitud,
                    nombreSolicitante,
                    correo,
                    fechaSolicitud,
                    horaSolicitud,
                    area,
                    maquina,
                    dispositivo,
                    descripcionProblema,
                    //diagnostico
                    nomina,
                    nombre,
                    fechaInicio,
                    horaInicio,
                    diagnostico,
                    tipoFalla,
                    emailSent,
                    nomina2,
                    nombre2,
                    asignacion,


                    //reparacion
                    tareasEjecutadas,
                    generoParo,
                    paroCorrectivo,
                    paroOperativo,
                    paroRefaccion,
                    tiempoTotal,
                    grasaUtilizada,
                    refaMateHerra,

                    //cierreSolicitud
                    fechaFinal,
                    horaFinal,
                    trabajoSanitizado,
                    estatusActividad,
                    firmaSolicitante,
                    nombre3,
                    emailSent2,
                    fechaFirma,
                    horaFirma,
                    comentariosSolicitante

                        );

                    lista.Add(Solicitud);
                }
                dr.Close();
                conn.Close();
            }
            return lista;
        }/*T*/
        public List<solicitud> GetSolicitudsProceso()
        {
            List<solicitud> lista = new List<solicitud>();
            string strConn = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "solicutudes_proceso";
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


                    //diagnostico
                    int nomina = dr.GetInt32(9);
                    string nombre = dr.GetString(10).Trim();
                    string fechaInicio = dr.GetString(11).Trim();
                    string horaInicio = dr.GetString(12).Trim();
                    string diagnostico = dr.GetString(13).Trim();
                    string tipoFalla = dr.GetString(14).Trim();
                    string emailSent = dr.GetString(15).Trim();
                    int nomina2 = dr.GetInt32(16);
                    string nombre2 = dr.GetString(17).Trim();
                    string asignacion = dr.GetString(18).Trim();

                    //reparacion
                    string tareasEjecutadas = dr.GetString(19).Trim();
                    string generoParo = dr.GetString(20).Trim();
                    int paroCorrectivo = dr.GetInt32(21);
                    int paroOperativo = dr.GetInt32(22);
                    int paroRefaccion = dr.GetInt32(23);
                    int tiempoTotal = dr.GetInt32(24);
                    string grasaUtilizada = dr.GetString(25).Trim();
                    string refaMateHerra = dr.GetString(26).Trim();

                    //cierre solicitud
                    string fechaFinal = dr.GetString(27).Trim();
                    string horaFinal = dr.GetString(28).Trim();
                    string trabajoSanitizado = dr.GetString(29).Trim();
                    string estatusActividad = dr.GetString(30).Trim();
                    string firmaSolicitante = dr.GetString(31).Trim();
                    string nombre3 = dr.GetString(32).Trim();
                    string emailSent2 = dr.GetString(33).Trim();
                    string fechaFirma = dr.GetString(34).Trim();
                    string horaFirma = dr.GetString(35).Trim();
                    string comentariosSolicitante = dr.GetString(36).Trim();

                    solicitud Solicitud = new solicitud(
                    idSolicitud,
                    nombreSolicitante,
                    correo,
                    fechaSolicitud,
                    horaSolicitud,
                    area,
                    maquina,
                    dispositivo,
                    descripcionProblema,
                    //diagnostico
                    nomina,
                    nombre,
                    fechaInicio,
                    horaInicio,
                    diagnostico,
                    tipoFalla,
                    emailSent,
                    nomina2,
                    nombre2,
                    asignacion,


                    //reparacion
                    tareasEjecutadas,
                    generoParo,
                    paroCorrectivo,
                    paroOperativo,
                    paroRefaccion,
                    tiempoTotal,
                    grasaUtilizada,
                    refaMateHerra,

                    //cierreSolicitud
                    fechaFinal,
                    horaFinal,
                    trabajoSanitizado,
                    estatusActividad,
                    firmaSolicitante,
                    nombre3,
                    emailSent2,
                    fechaFirma,
                    horaFirma,
                    comentariosSolicitante

                        );

                    lista.Add(Solicitud);
                }
                dr.Close();
                conn.Close();
            }
            return lista;
        }/*T*/
        public List<solicitud> GetSolicitudsCerradas()
        {
            List<solicitud> lista = new List<solicitud>();
            string strConn = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "solicutudes_cerradas";
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


                    //diagnostico
                    int nomina = dr.GetInt32(9);
                    string nombre = dr.GetString(10).Trim();
                    string fechaInicio = dr.GetString(11).Trim();
                    string horaInicio = dr.GetString(12).Trim();
                    string diagnostico = dr.GetString(13).Trim();
                    string tipoFalla = dr.GetString(14).Trim();
                    string emailSent = dr.GetString(15).Trim();
                    int nomina2 = dr.GetInt32(16);
                    string nombre2 = dr.GetString(17).Trim();
                    string asignacion = dr.GetString(18).Trim();

                    //reparacion
                    string tareasEjecutadas = dr.GetString(19).Trim();
                    string generoParo = dr.GetString(20).Trim();
                    int paroCorrectivo = dr.GetInt32(21);
                    int paroOperativo = dr.GetInt32(22);
                    int paroRefaccion = dr.GetInt32(23);
                    int tiempoTotal = dr.GetInt32(24);
                    string grasaUtilizada = dr.GetString(25).Trim();
                    string refaMateHerra = dr.GetString(26).Trim();

                    //cierre solicitud
                    string fechaFinal = dr.GetString(27).Trim();
                    string horaFinal = dr.GetString(28).Trim();
                    string trabajoSanitizado = dr.GetString(29).Trim();
                    string estatusActividad = dr.GetString(30).Trim();
                    string firmaSolicitante = dr.GetString(31).Trim();
                    string nombre3 = dr.GetString(32).Trim();
                    string emailSent2 = dr.GetString(33).Trim();
                    string fechaFirma = dr.GetString(34).Trim();
                    string horaFirma = dr.GetString(35).Trim();
                    string comentariosSolicitante = dr.GetString(36).Trim();

                    solicitud Solicitud = new solicitud(
                    idSolicitud,
                    nombreSolicitante,
                    correo,
                    fechaSolicitud,
                    horaSolicitud,
                    area,
                    maquina,
                    dispositivo,
                    descripcionProblema,
                    //diagnostico
                    nomina,
                    nombre,
                    fechaInicio,
                    horaInicio,
                    diagnostico,
                    tipoFalla,
                    emailSent,
                    nomina2,
                    nombre2,
                    asignacion,


                    //reparacion
                    tareasEjecutadas,
                    generoParo,
                    paroCorrectivo,
                    paroOperativo,
                    paroRefaccion,
                    tiempoTotal,
                    grasaUtilizada,
                    refaMateHerra,

                    //cierreSolicitud
                    fechaFinal,
                    horaFinal,
                    trabajoSanitizado,
                    estatusActividad,
                    firmaSolicitante,
                    nombre3,
                    emailSent2,
                    fechaFirma,
                    horaFirma,
                    comentariosSolicitante

                        );

                    lista.Add(Solicitud);
                }
                dr.Close();
                conn.Close();
            }
            return lista;
        }/*T*/
        /*solicitudes cerradas por area*/
        public List<solicitud> GetSolicitudsCerradasPorArea(string id2)
        {

            List<solicitud> lista = new List<solicitud>();
            string strConn = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("select  s.idSolicitud, s.nombreSolicitante, s.correo, s.fechaSolicitud, s.horaSolicitud, s.area, s.maquina, s.dispositivo, s.descripcionProblema, d.nomina, m.nombre, d.fechaInicio, d.horaInicio, d.diagnostico, d.tipoFalla, d.emailSent, d.nomina2, m2.nombre as nombre2, d.asignacion, r.tareasEjecutadas, r.generoParo, r.paroCorrectivo, r.paroOperativo, r.paroRefacccion, r.tiempoTotal, r.grasaUtilizada, r.refaMateHerra, c.fechaFinal, c.horaFinal, c.trabajoSanitizado, c.estatusActividad, c.firmaSolicitante, U.usuario as nombre3, c.emailSent2, c.fechaFirma, c.horaFirma, c.comentariosSolicitante from SolicitudPreventiva as S inner join Diagnostico as D on S.idSolicitud=D.idSolicitud inner join Reparacion as R on D.idSolicitud= R.idSolicitud inner join CierreSolicitud as C on R.idSolicitud= C.idSolicitud inner join Mecanicos M on D.nomina=M.nomina  inner join Mecanicos M2 on D.nomina2=M2.nomina inner join Usuarios U on C.firmaSolicitante=U.nomina3 where (c.estatusActividad = 'Cancelado' or c.firmaSolicitante ='1') and s.area=" + "'" + id2 + "'", conn);

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


                    //diagnostico
                    int nomina = dr.GetInt32(9);
                    string nombre = dr.GetString(10).Trim();
                    string fechaInicio = dr.GetString(11).Trim();
                    string horaInicio = dr.GetString(12).Trim();
                    string diagnostico = dr.GetString(13).Trim();
                    string tipoFalla = dr.GetString(14).Trim();
                    string emailSent = dr.GetString(15).Trim();
                    int nomina2 = dr.GetInt32(16);
                    string nombre2 = dr.GetString(17).Trim();
                    string asignacion = dr.GetString(18).Trim();

                    //reparacion
                    string tareasEjecutadas = dr.GetString(19).Trim();
                    string generoParo = dr.GetString(20).Trim();
                    int paroCorrectivo = dr.GetInt32(21);
                    int paroOperativo = dr.GetInt32(22);
                    int paroRefaccion = dr.GetInt32(23);
                    int tiempoTotal = dr.GetInt32(24);
                    string grasaUtilizada = dr.GetString(25).Trim();
                    string refaMateHerra = dr.GetString(26).Trim();

                    //cierre solicitud
                    string fechaFinal = dr.GetString(27).Trim();
                    string horaFinal = dr.GetString(28).Trim();
                    string trabajoSanitizado = dr.GetString(29).Trim();
                    string estatusActividad = dr.GetString(30).Trim();
                    string firmaSolicitante = dr.GetString(31).Trim();
                    string nombre3 = dr.GetString(32).Trim();
                    string emailSent2 = dr.GetString(33).Trim();
                    string fechaFirma = dr.GetString(34).Trim();
                    string horaFirma = dr.GetString(35).Trim();
                    string comentariosSolicitante = dr.GetString(36).Trim();
                    solicitud Solicitud = new solicitud(idSolicitud,
                    nombreSolicitante,
                    correo,
                    fechaSolicitud,
                    horaSolicitud,
                    area,
                    maquina,
                    dispositivo,
                    descripcionProblema,
                    //diagnostico
                    nomina,
                    nombre,
                    fechaInicio,
                    horaInicio,
                    diagnostico,
                    tipoFalla,
                    emailSent,
                    nomina2,
                    nombre2,
                    asignacion,

                    //reparacion
                    tareasEjecutadas,
                    generoParo,
                    paroCorrectivo,
                    paroOperativo,
                    paroRefaccion,
                    tiempoTotal,
                    grasaUtilizada,
                    refaMateHerra,

                    //cierreSolicitud
                    fechaFinal,
                    horaFinal,
                    trabajoSanitizado,
                    estatusActividad,
                    firmaSolicitante,
                    nombre3,
                    emailSent2,
                    fechaFirma,
                    horaFirma,
                    comentariosSolicitante);

                    lista.Add(Solicitud);
                }
                dr.Close();
                conn.Close();
            }
            return lista;
        }/*T*/
        /*solicitudes cerradas por area*/
        /**/

        /*e*/
        public List<solicitud> GetSolicitudPendientes()
        {
            List<solicitud> lista = new List<solicitud>();
            string strConn = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "solicitudes_pendientes";
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


                    //diagnostico
                    int nomina = dr.GetInt32(9);
                    string nombre = dr.GetString(10).Trim();
                    string fechaInicio = dr.GetString(11).Trim();
                    string horaInicio = dr.GetString(12).Trim();
                    string diagnostico = dr.GetString(13).Trim();
                    string tipoFalla = dr.GetString(14).Trim();
                    string emailSent = dr.GetString(15).Trim();
                    int nomina2 = dr.GetInt32(16);
                    string nombre2 = dr.GetString(17).Trim();
                    string asignacion = dr.GetString(18).Trim();

                    //reparacion
                    string tareasEjecutadas = dr.GetString(19).Trim();
                    string generoParo = dr.GetString(20).Trim();
                    int paroCorrectivo = dr.GetInt32(21);
                    int paroOperativo = dr.GetInt32(22);
                    int paroRefaccion = dr.GetInt32(23);
                    int tiempoTotal = dr.GetInt32(24);
                    string grasaUtilizada = dr.GetString(25).Trim();
                    string refaMateHerra = dr.GetString(26).Trim();

                    //cierre solicitud
                    string fechaFinal = dr.GetString(27).Trim();
                    string horaFinal = dr.GetString(28).Trim();
                    string trabajoSanitizado = dr.GetString(29).Trim();
                    string estatusActividad = dr.GetString(30).Trim();
                    string firmaSolicitante = dr.GetString(31).Trim();
                    string nombre3 = dr.GetString(32).Trim();
                    string emailSent2 = dr.GetString(33).Trim();
                    string fechaFirma = dr.GetString(34).Trim();
                    string horaFirma = dr.GetString(35).Trim();
                    string comentariosSolicitante = dr.GetString(36).Trim();

                    solicitud Solicitud = new solicitud(
                    idSolicitud,
                    nombreSolicitante,
                    correo,
                    fechaSolicitud,
                    horaSolicitud,
                    area,
                    maquina,
                    dispositivo,
                    descripcionProblema,
                    //diagnostico
                    nomina,
                    nombre,
                    fechaInicio,
                    horaInicio,
                    diagnostico,
                    tipoFalla,
                    emailSent,
                    nomina2,
                    nombre2,
                    asignacion,


                    //reparacion
                    tareasEjecutadas,
                    generoParo,
                    paroCorrectivo,
                    paroOperativo,
                    paroRefaccion,
                    tiempoTotal,
                    grasaUtilizada,
                    refaMateHerra,

                    //cierreSolicitud
                    fechaFinal,
                    horaFinal,
                    trabajoSanitizado,
                    estatusActividad,
                    firmaSolicitante,
                    nombre3,
                    emailSent2,
                       fechaFirma,
                       horaFirma, 
                       comentariosSolicitante

                        );

                    lista.Add(Solicitud);
                }
                dr.Close();
                conn.Close();
            }
            return lista;
        }/*T*/
        /**/
        public List<solicitud> GetSolicitudTerminadas()
        {
            List<solicitud> lista = new List<solicitud>();
            string strConn = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "solicitudes_Terminadas";
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


                    //diagnostico
                    int nomina = dr.GetInt32(9);
                    string nombre = dr.GetString(10).Trim();
                    string fechaInicio = dr.GetString(11).Trim();
                    string horaInicio = dr.GetString(12).Trim();
                    string diagnostico = dr.GetString(13).Trim();
                    string tipoFalla = dr.GetString(14).Trim();
                    string emailSent = dr.GetString(15).Trim();
                    int nomina2 = dr.GetInt32(16);
                    string nombre2 = dr.GetString(17).Trim();
                    string asignacion = dr.GetString(18).Trim();

                    //reparacion
                    string tareasEjecutadas = dr.GetString(19).Trim();
                    string generoParo = dr.GetString(20).Trim();
                    int paroCorrectivo = dr.GetInt32(21);
                    int paroOperativo = dr.GetInt32(22);
                    int paroRefaccion = dr.GetInt32(23);
                    int tiempoTotal = dr.GetInt32(24);
                    string grasaUtilizada = dr.GetString(25).Trim();
                    string refaMateHerra = dr.GetString(26).Trim();

                    //cierre solicitud
                    string fechaFinal = dr.GetString(27).Trim();
                    string horaFinal = dr.GetString(28).Trim();
                    string trabajoSanitizado = dr.GetString(29).Trim();
                    string estatusActividad = dr.GetString(30).Trim();
                    string firmaSolicitante = dr.GetString(31).Trim();
                    string nombre3 = dr.GetString(32).Trim();
                    string emailSent2 = dr.GetString(33).Trim();
                    string fechaFirma = dr.GetString(34).Trim();
                    string horaFirma = dr.GetString(35).Trim();
                    string comentariosSolicitante = dr.GetString(36).Trim();


                    solicitud Solicitud = new solicitud(
                    idSolicitud,
                    nombreSolicitante,
                    correo,
                    fechaSolicitud,
                    horaSolicitud,
                    area,
                    maquina,
                    dispositivo,
                    descripcionProblema,
                    //diagnostico
                    nomina,
                    nombre,
                    fechaInicio,
                    horaInicio,
                    diagnostico,
                    tipoFalla,
                    emailSent,
                    nomina2,
                    nombre2,
                    asignacion,


                    //reparacion
                    tareasEjecutadas,
                    generoParo,
                    paroCorrectivo,
                    paroOperativo,
                    paroRefaccion,
                    tiempoTotal,
                    grasaUtilizada,
                    refaMateHerra,

                    //cierreSolicitud
                    fechaFinal,
                    horaFinal,
                    trabajoSanitizado,
                    estatusActividad,
                    firmaSolicitante,
                    nombre3,
                    emailSent2,
                    fechaFirma,
                    horaFirma,
                    comentariosSolicitante

                        );

                    lista.Add(Solicitud);
                }
                dr.Close();
                conn.Close();
            }
            return lista;
        }/*T*/

        public List<solicitud> GetSolicitudTomadas()
        {
            List<solicitud> lista = new List<solicitud>();
            string strConn = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "solicitudes_tomadas";
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


                    //diagnostico
                    int nomina = dr.GetInt32(9);
                    string nombre = dr.GetString(10).Trim();
                    string fechaInicio = dr.GetString(11).Trim();
                    string horaInicio = dr.GetString(12).Trim();
                    string diagnostico = dr.GetString(13).Trim();
                    string tipoFalla = dr.GetString(14).Trim();
                    string emailSent = dr.GetString(15).Trim();
                    int nomina2 = dr.GetInt32(16);
                    string nombre2 = dr.GetString(17).Trim();
                    string asignacion = dr.GetString(18).Trim();

                    //reparacion
                    string tareasEjecutadas = dr.GetString(19).Trim();
                    string generoParo = dr.GetString(20).Trim();
                    int paroCorrectivo = dr.GetInt32(21);
                    int paroOperativo = dr.GetInt32(22);
                    int paroRefaccion = dr.GetInt32(23);
                    int tiempoTotal = dr.GetInt32(24);
                    string grasaUtilizada = dr.GetString(25).Trim();
                    string refaMateHerra = dr.GetString(26).Trim();

                    //cierre solicitud
                    string fechaFinal = dr.GetString(27).Trim();
                    string horaFinal = dr.GetString(28).Trim();
                    string trabajoSanitizado = dr.GetString(29).Trim();
                    string estatusActividad = dr.GetString(30).Trim();
                    string firmaSolicitante = dr.GetString(31).Trim();
                    string nombre3 = dr.GetString(32).Trim();
                    string emailSent2 = dr.GetString(33).Trim();
                    string fechaFirma = dr.GetString(34).Trim();
                    string horaFirma = dr.GetString(35).Trim();
                    string comentariosSolicitante = dr.GetString(36).Trim();

                    solicitud Solicitud = new solicitud(
                    idSolicitud,
                    nombreSolicitante,
                    correo,
                    fechaSolicitud,
                    horaSolicitud,
                    area,
                    maquina,
                    dispositivo,
                    descripcionProblema,
                    //diagnostico
                    nomina,
                    nombre,
                    fechaInicio,
                    horaInicio,
                    diagnostico,
                    tipoFalla,
                    emailSent,
                    nomina2,
                    nombre2,
                    asignacion,


                    //reparacion
                    tareasEjecutadas,
                    generoParo,
                    paroCorrectivo,
                    paroOperativo,
                    paroRefaccion,
                    tiempoTotal,
                    grasaUtilizada,
                    refaMateHerra,

                    //cierreSolicitud
                    fechaFinal,
                    horaFinal,
                    trabajoSanitizado,
                    estatusActividad,
                    firmaSolicitante,
                    nombre3,
                    emailSent2, 
                    fechaFirma,
                    horaFirma,
                    comentariosSolicitante

                        );

                    lista.Add(Solicitud);
                }
                dr.Close();
                conn.Close();
            }
            return lista;
        }

        /**/
        public List<solicitud> GetSolicitudsByIdSACerra(string id2)
        {

            List<solicitud> lista = new List<solicitud>();
            string strConn = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("select  s.idSolicitud, s.nombreSolicitante, s.correo, s.fechaSolicitud, s.horaSolicitud, s.area, s.maquina, s.dispositivo, s.descripcionProblema, d.nomina, m.nombre, d.fechaInicio, d.horaInicio, d.diagnostico, d.tipoFalla, d.emailSent, d.nomina2, m2.nombre as nombre2, d.asignacion, r.tareasEjecutadas, r.generoParo, r.paroCorrectivo, r.paroOperativo, r.paroRefacccion, r.tiempoTotal, r.grasaUtilizada, r.refaMateHerra, c.fechaFinal, c.horaFinal, c.trabajoSanitizado, c.estatusActividad, c.firmaSolicitante, U.usuario as nombre3, c.emailSent2, c.fechaFirma, c.horaFirma, c.comentariosSolicitante from SolicitudPreventiva as S inner join Diagnostico as D on S.idSolicitud=D.idSolicitud inner join Reparacion as R on D.idSolicitud= R.idSolicitud inner join CierreSolicitud as C on R.idSolicitud= C.idSolicitud inner join Mecanicos M on D.nomina=M.nomina  inner join Mecanicos M2 on D.nomina2=M2.nomina inner join Usuarios U on C.firmaSolicitante=U.nomina3 where (c.estatusActividad = 'Cancelado' or c.firmaSolicitante ='1') and s.area=" + "'" + id2 + "'", conn);

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


                    //diagnostico
                    int nomina = dr.GetInt32(9);
                    string nombre = dr.GetString(10).Trim();
                    string fechaInicio = dr.GetString(11).Trim();
                    string horaInicio = dr.GetString(12).Trim();
                    string diagnostico = dr.GetString(13).Trim();
                    string tipoFalla = dr.GetString(14).Trim();
                    string emailSent = dr.GetString(15).Trim();
                    int nomina2 = dr.GetInt32(16);
                    string nombre2 = dr.GetString(17).Trim();
                    string asignacion = dr.GetString(18).Trim();

                    //reparacion
                    string tareasEjecutadas = dr.GetString(19).Trim();
                    string generoParo = dr.GetString(20).Trim();
                    int paroCorrectivo = dr.GetInt32(21);
                    int paroOperativo = dr.GetInt32(22);
                    int paroRefaccion = dr.GetInt32(23);
                    int tiempoTotal = dr.GetInt32(24);
                    string grasaUtilizada = dr.GetString(25).Trim();
                    string refaMateHerra = dr.GetString(26).Trim();

                    //cierre solicitud
                    string fechaFinal = dr.GetString(27).Trim();
                    string horaFinal = dr.GetString(28).Trim();
                    string trabajoSanitizado = dr.GetString(29).Trim();
                    string estatusActividad = dr.GetString(30).Trim();
                    string firmaSolicitante = dr.GetString(31).Trim();
                    string nombre3 = dr.GetString(32).Trim();
                    string emailSent2 = dr.GetString(33).Trim();
                    string fechaFirma = dr.GetString(34).Trim();
                    string horaFirma = dr.GetString(35).Trim();
                    string comentariosSolicitante = dr.GetString(36).Trim();
                    solicitud Solicitud = new solicitud(idSolicitud,
                    nombreSolicitante,
                    correo,
                    fechaSolicitud,
                    horaSolicitud,
                    area,
                    maquina,
                    dispositivo,
                    descripcionProblema,
                    //diagnostico
                    nomina,
                    nombre,
                    fechaInicio,
                    horaInicio,
                    diagnostico,
                    tipoFalla,
                    emailSent,
                    nomina2,
                    nombre2,
                    asignacion,

                    //reparacion
                    tareasEjecutadas,
                    generoParo,
                    paroCorrectivo,
                    paroOperativo,
                    paroRefaccion,
                    tiempoTotal,
                    grasaUtilizada,
                    refaMateHerra,

                    //cierreSolicitud
                    fechaFinal,
                    horaFinal,
                    trabajoSanitizado,
                    estatusActividad,
                    firmaSolicitante,
                    nombre3,
                    emailSent2,
                    fechaFirma,
                    horaFirma,
                    comentariosSolicitante);

                    lista.Add(Solicitud);
                }
                dr.Close();
                conn.Close();
            }
            return lista;
        }
        /**/
        /**/
        public List<solicitud> GetSolicitudsByIdSATt(string id2)
        {

            List<solicitud> lista = new List<solicitud>();
            string strConn = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("select  s.idSolicitud, s.nombreSolicitante, s.correo, s.fechaSolicitud, s.horaSolicitud, s.area, s.maquina, s.dispositivo, s.descripcionProblema, d.nomina, m.nombre, d.fechaInicio, d.horaInicio, d.diagnostico, d.tipoFalla, d.emailSent, d.nomina2, m2.nombre as nombre2, d.asignacion, r.tareasEjecutadas, r.generoParo, r.paroCorrectivo, r.paroOperativo, r.paroRefacccion, r.tiempoTotal, r.grasaUtilizada, r.refaMateHerra, c.fechaFinal, c.horaFinal, c.trabajoSanitizado, c.estatusActividad, c.firmaSolicitante, U.usuario as nombre3, c.emailSent2, c.fechaFirma, c.horaFirma, c.comentariosSolicitante from SolicitudPreventiva as S inner join Diagnostico as D on S.idSolicitud=D.idSolicitud inner join Reparacion as R on D.idSolicitud= R.idSolicitud inner join CierreSolicitud as C on R.idSolicitud= C.idSolicitud inner join Mecanicos M on D.nomina=M.nomina  inner join Mecanicos M2 on D.nomina2=M2.nomina inner join Usuarios U on C.firmaSolicitante=U.nomina3 where (c.estatusActividad = 'Falta de refacción(Trabajo Temporal)') and s.area=" + "'" + id2 + "'", conn);

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


                    //diagnostico
                    int nomina = dr.GetInt32(9);
                    string nombre = dr.GetString(10).Trim();
                    string fechaInicio = dr.GetString(11).Trim();
                    string horaInicio = dr.GetString(12).Trim();
                    string diagnostico = dr.GetString(13).Trim();
                    string tipoFalla = dr.GetString(14).Trim();
                    string emailSent = dr.GetString(15).Trim();
                    int nomina2 = dr.GetInt32(16);
                    string nombre2 = dr.GetString(17).Trim();
                    string asignacion = dr.GetString(18).Trim();

                    //reparacion
                    string tareasEjecutadas = dr.GetString(19).Trim();
                    string generoParo = dr.GetString(20).Trim();
                    int paroCorrectivo = dr.GetInt32(21);
                    int paroOperativo = dr.GetInt32(22);
                    int paroRefaccion = dr.GetInt32(23);
                    int tiempoTotal = dr.GetInt32(24);
                    string grasaUtilizada = dr.GetString(25).Trim();
                    string refaMateHerra = dr.GetString(26).Trim();

                    //cierre solicitud
                    string fechaFinal = dr.GetString(27).Trim();
                    string horaFinal = dr.GetString(28).Trim();
                    string trabajoSanitizado = dr.GetString(29).Trim();
                    string estatusActividad = dr.GetString(30).Trim();
                    string firmaSolicitante = dr.GetString(31).Trim();
                    string nombre3 = dr.GetString(32).Trim();
                    string emailSent2 = dr.GetString(33).Trim();
                    string fechaFirma = dr.GetString(34).Trim();
                    string horaFirma = dr.GetString(35).Trim();
                    string comentariosSolicitante = dr.GetString(36).Trim();
                    solicitud Solicitud = new solicitud(idSolicitud,
                    nombreSolicitante,
                    correo,
                    fechaSolicitud,
                    horaSolicitud,
                    area,
                    maquina,
                    dispositivo,
                    descripcionProblema,
                    //diagnostico
                    nomina,
                    nombre,
                    fechaInicio,
                    horaInicio,
                    diagnostico,
                    tipoFalla,
                    emailSent,
                    nomina2,
                    nombre2,
                    asignacion,

                    //reparacion
                    tareasEjecutadas,
                    generoParo,
                    paroCorrectivo,
                    paroOperativo,
                    paroRefaccion,
                    tiempoTotal,
                    grasaUtilizada,
                    refaMateHerra,

                    //cierreSolicitud
                    fechaFinal,
                    horaFinal,
                    trabajoSanitizado,
                    estatusActividad,
                    firmaSolicitante,
                    nombre3,
                    emailSent2,
                    fechaFirma,
                    horaFirma,
                    comentariosSolicitante);

                    lista.Add(Solicitud);
                }
                dr.Close();
                conn.Close();
            }
            return lista;
        }
        /**/
        public List<solicitud> GetSolicitudsByIdSA(string id2)
        {

            List<solicitud> lista = new List<solicitud>();
            string strConn = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("select  s.idSolicitud, s.nombreSolicitante, s.correo, s.fechaSolicitud, s.horaSolicitud, s.area, s.maquina, s.dispositivo, s.descripcionProblema, d.nomina, m.nombre, d.fechaInicio, d.horaInicio, d.diagnostico, d.tipoFalla, d.emailSent, d.nomina2, m2.nombre as nombre2, d.asignacion, r.tareasEjecutadas, r.generoParo, r.paroCorrectivo, r.paroOperativo, r.paroRefacccion, r.tiempoTotal, r.grasaUtilizada, r.refaMateHerra, c.fechaFinal, c.horaFinal, c.trabajoSanitizado, c.estatusActividad, c.firmaSolicitante, U.usuario as nombre3, c.emailSent2, c.fechaFirma, c.horaFirma, c.comentariosSolicitante from SolicitudPreventiva as S inner join Diagnostico as D on S.idSolicitud=D.idSolicitud inner join Reparacion as R on D.idSolicitud= R.idSolicitud inner join CierreSolicitud as C on R.idSolicitud= C.idSolicitud inner join Mecanicos M on D.nomina=M.nomina  inner join Mecanicos M2 on D.nomina2=M2.nomina inner join Usuarios U on C.firmaSolicitante=U.nomina3 where (c.estatusActividad = 'Recoger herramientas y refacciones' or c.estatusActividad='' or c.firmaSolicitante='0') and s.area=" + "'"+id2+"'", conn);

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


                    //diagnostico
                    int nomina = dr.GetInt32(9);
                    string nombre = dr.GetString(10).Trim();
                    string fechaInicio = dr.GetString(11).Trim();
                    string horaInicio = dr.GetString(12).Trim();
                    string diagnostico = dr.GetString(13).Trim();
                    string tipoFalla = dr.GetString(14).Trim();
                    string emailSent = dr.GetString(15).Trim();
                    int nomina2 = dr.GetInt32(16);
                    string nombre2 = dr.GetString(17).Trim();
                    string asignacion = dr.GetString(18).Trim();

                    //reparacion
                    string tareasEjecutadas = dr.GetString(19).Trim();
                    string generoParo = dr.GetString(20).Trim();
                    int paroCorrectivo = dr.GetInt32(21);
                    int paroOperativo = dr.GetInt32(22);
                    int paroRefaccion = dr.GetInt32(23);
                    int tiempoTotal = dr.GetInt32(24);
                    string grasaUtilizada = dr.GetString(25).Trim();
                    string refaMateHerra = dr.GetString(26).Trim();

                    //cierre solicitud
                    string fechaFinal = dr.GetString(27).Trim();
                    string horaFinal = dr.GetString(28).Trim();
                    string trabajoSanitizado = dr.GetString(29).Trim();
                    string estatusActividad = dr.GetString(30).Trim();
                    string firmaSolicitante = dr.GetString(31).Trim();
                    string nombre3 = dr.GetString(32).Trim();
                    string emailSent2 = dr.GetString(33).Trim();
                    string fechaFirma = dr.GetString(34).Trim();
                    string horaFirma = dr.GetString(35).Trim();
                    string comentariosSolicitante = dr.GetString(36).Trim();
                    solicitud Solicitud = new solicitud(idSolicitud,
                    nombreSolicitante,
                    correo,
                    fechaSolicitud,
                    horaSolicitud,
                    area,
                    maquina,
                    dispositivo,
                    descripcionProblema,
                    //diagnostico
                    nomina,
                    nombre,
                    fechaInicio,
                    horaInicio,
                    diagnostico,
                    tipoFalla,
                    emailSent,
                    nomina2,
                    nombre2,
                    asignacion,

                    //reparacion
                    tareasEjecutadas,
                    generoParo,
                    paroCorrectivo,
                    paroOperativo,
                    paroRefaccion,
                    tiempoTotal,
                    grasaUtilizada,
                    refaMateHerra,

                    //cierreSolicitud
                    fechaFinal,
                    horaFinal,
                    trabajoSanitizado,
                    estatusActividad,
                    firmaSolicitante,
                    nombre3,
                    emailSent2,
                    fechaFirma,
                    horaFirma,
                    comentariosSolicitante);

                    lista.Add(Solicitud);
                }
                dr.Close();
                conn.Close();
            }
            return lista;
        }

        /*T*/
        public List<solicitud> GetSolicitudsById(int id2)
        {

            List<solicitud> lista = new List<solicitud>();
            string strConn = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("select s.idSolicitud,  s.nombreSolicitante,  s.correo,  s.fechaSolicitud,  s.horaSolicitud, s.area,  s.maquina,  s.dispositivo,  s.descripcionProblema,  d.nomina, m.nombre, d.fechaInicio, d.horaInicio, d.diagnostico, d.tipoFalla, d.emailSent, d.nomina2, m2.nombre as nombre2, d.asignacion,  r.tareasEjecutadas, r.generoParo, r.paroCorrectivo, r.paroOperativo, r.paroRefacccion, r.tiempoTotal, r.grasaUtilizada, r.refaMateHerra,   c.fechaFinal, c.horaFinal, c.trabajoSanitizado, c.estatusActividad, c.firmaSolicitante, U.usuario as nombre3, c.emailSent2, c.fechaFirma, c.horaFirma, c.comentariosSolicitante  from SolicitudPreventiva as S inner join Diagnostico as D on S.idSolicitud=D.idSolicitud inner join Reparacion as R on D.idSolicitud= R.idSolicitud inner join CierreSolicitud as C on R.idSolicitud= C.idSolicitud inner join Mecanicos M on D.nomina=M.nomina  inner join Mecanicos M2 on D.nomina2=M2.nomina inner join Usuarios U on C.firmaSolicitante=U.nomina3 where s.idSolicitud=" + id2, conn);

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


                    //diagnostico
                    int nomina = dr.GetInt32(9);
                    string nombre = dr.GetString(10).Trim();
                    string fechaInicio = dr.GetString(11).Trim();
                    string horaInicio = dr.GetString(12).Trim();
                    string diagnostico = dr.GetString(13).Trim();
                    string tipoFalla = dr.GetString(14).Trim();
                    string emailSent = dr.GetString(15).Trim();
                    int nomina2 = dr.GetInt32(16);
                    string nombre2 = dr.GetString(17).Trim();
                    string asignacion = dr.GetString(18).Trim();

                    //reparacion
                    string tareasEjecutadas = dr.GetString(19).Trim();
                    string generoParo = dr.GetString(20).Trim();
                    int paroCorrectivo = dr.GetInt32(21);
                    int paroOperativo = dr.GetInt32(22);
                    int paroRefaccion = dr.GetInt32(23);
                    int tiempoTotal = dr.GetInt32(24);
                    string grasaUtilizada = dr.GetString(25).Trim();
                    string refaMateHerra = dr.GetString(26).Trim();

                    //cierre solicitud
                    string fechaFinal = dr.GetString(27).Trim();
                    string horaFinal = dr.GetString(28).Trim();
                    string trabajoSanitizado = dr.GetString(29).Trim();
                    string estatusActividad = dr.GetString(30).Trim();
                    string firmaSolicitante = dr.GetString(31).Trim();
                    string nombre3=dr.GetString(32).Trim();
                    string emailSent2 = dr.GetString(33).Trim();
                    string fechaFirma = dr.GetString(34).Trim();
                    string horaFirma = dr.GetString(35).Trim();
                    string comentariosSolicitante = dr.GetString(36).Trim();
                    solicitud Solicitud = new solicitud( idSolicitud,
                    nombreSolicitante,
                    correo,
                    fechaSolicitud,
                    horaSolicitud,
                    area,
                    maquina,
                    dispositivo,
                    descripcionProblema,
                    //diagnostico
                    nomina,
                    nombre,
                    fechaInicio,
                    horaInicio,
                    diagnostico,
                    tipoFalla,
                    emailSent,
                    nomina2,
                    nombre2,
                    asignacion,

                    //reparacion
                    tareasEjecutadas,
                    generoParo,
                    paroCorrectivo,
                    paroOperativo,
                    paroRefaccion,
                    tiempoTotal,
                    grasaUtilizada,
                    refaMateHerra,

                    //cierreSolicitud
                    fechaFinal,
                    horaFinal,
                    trabajoSanitizado,
                    estatusActividad,
                    firmaSolicitante,
                    nombre3,
                    emailSent2, 
                    fechaFirma,
                    horaFirma, 
                    comentariosSolicitante);

                    lista.Add(Solicitud);
                }
                dr.Close();
                conn.Close();
            }
            return lista;
        }



        /*esta*/
       public List<solicitud> GetSolicitudsById2(int id2)
       {

           List<solicitud> lista = new List<solicitud>();
           string strConn = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
           using (SqlConnection conn = new SqlConnection(strConn))
           {
               conn.Open();
               String temp = id2 + "";

               SqlCommand cmd = new SqlCommand($"select s.idSolicitud, s.nombreSolicitante, s.correo, s.fechaSolicitud, s.horaSolicitud, s.area, s.maquina, s.dispositivo, s.descripcionProblema, d.nomina, m.nombre, d.fechaInicio, d.horaInicio, d.diagnostico, d.tipoFalla, d.emailSent, d.nomina2, m2.nombre as nombre2, d.asignacion, r.tareasEjecutadas, r.generoParo, r.paroCorrectivo, r.paroOperativo, r.paroRefacccion, r.tiempoTotal, r.grasaUtilizada, r.refaMateHerra, c.fechaFinal, c.horaFinal, c.trabajoSanitizado, c.estatusActividad, c.firmaSolicitante, U.usuario as nombre3, c.emailSent2, c.fechaFirma, c.horaFirma, c.comentariosSolicitante from SolicitudPreventiva as S inner join Diagnostico as D on S.idSolicitud=D.idSolicitud inner join Reparacion as R on D.idSolicitud= R.idSolicitud inner join CierreSolicitud as C on R.idSolicitud= C.idSolicitud inner join Mecanicos M on D.nomina=M.nomina  inner join Mecanicos M2 on D.nomina2=M2.nomina inner join Usuarios U on C.firmaSolicitante=U.nomina3 where ((d.nomina={temp} or d.nomina2 = {temp}) and (c.estatusActividad = 'Recoger herramientas y refacciones' or c.estatusActividad=''))", conn);

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


                    //diagnostico
                    int nomina = dr.GetInt32(9);
                    string nombre = dr.GetString(10).Trim();
                    string fechaInicio = dr.GetString(11).Trim();
                    string horaInicio = dr.GetString(12).Trim();
                    string diagnostico = dr.GetString(13).Trim();
                    string tipoFalla = dr.GetString(14).Trim();
                    string emailSent = dr.GetString(15).Trim();
                    int nomina2 = dr.GetInt32(16);
                    string nombre2 = dr.GetString(17).Trim();
                    string asignacion = dr.GetString(18).Trim();

                    //reparacion
                    string tareasEjecutadas = dr.GetString(19).Trim();
                    string generoParo = dr.GetString(20).Trim();
                    int paroCorrectivo = dr.GetInt32(21);
                    int paroOperativo = dr.GetInt32(22);
                    int paroRefaccion = dr.GetInt32(23);
                    int tiempoTotal = dr.GetInt32(24);
                    string grasaUtilizada = dr.GetString(25).Trim();
                    string refaMateHerra = dr.GetString(26).Trim();

                    //cierre solicitud
                    string fechaFinal = dr.GetString(27).Trim();
                    string horaFinal = dr.GetString(28).Trim();
                    string trabajoSanitizado = dr.GetString(29).Trim();
                    string estatusActividad = dr.GetString(30).Trim();
                    string firmaSolicitante = dr.GetString(31).Trim();
                    string nombre3 = dr.GetString(32).Trim();
                    string emailSent2 = dr.GetString(33).Trim();
                    string fechaFirma = dr.GetString(34).Trim();
                    string horaFirma = dr.GetString(35).Trim();
                    string comentariosSolicitante = dr.GetString(36).Trim();

                    solicitud Solicitud = new solicitud(idSolicitud,
                   nombreSolicitante,
                   correo,
                   fechaSolicitud,
                   horaSolicitud,
                   area,
                   maquina,
                   dispositivo,
                   descripcionProblema,
                    //diagnostico
                    nomina,
                    nombre,
                    fechaInicio,
                    horaInicio,
                    diagnostico,
                    tipoFalla,
                    emailSent,
                    nomina2,
                    nombre2,
                    asignacion,

                    //reparacion
                    tareasEjecutadas,
                    generoParo,
                    paroCorrectivo,
                    paroOperativo,
                    paroRefaccion,
                    tiempoTotal,
                    grasaUtilizada,
                    refaMateHerra,

                    //cierreSolicitud
                    fechaFinal,
                    horaFinal,
                    trabajoSanitizado,
                    estatusActividad,
                    firmaSolicitante,
                    nombre3,
                    emailSent2,
                    fechaFirma,
                    horaFirma, 
                    comentariosSolicitante
                    );

                   lista.Add(Solicitud);
               }
               dr.Close();
               conn.Close();
           }
           return lista;
       }
        /*esta*/
        public List<solicitud> GetSolicitudsById2Cierre(int id2)
        {

            List<solicitud> lista = new List<solicitud>();
            string strConn = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                String temp = id2 + "";

                SqlCommand cmd = new SqlCommand($"select s.idSolicitud, s.nombreSolicitante, s.correo, s.fechaSolicitud, s.horaSolicitud, s.area, s.maquina, s.dispositivo, s.descripcionProblema, d.nomina, m.nombre, d.fechaInicio, d.horaInicio, d.diagnostico, d.tipoFalla, d.emailSent, d.nomina2, m2.nombre as nombre2, d.asignacion, r.tareasEjecutadas, r.generoParo, r.paroCorrectivo, r.paroOperativo, r.paroRefacccion, r.tiempoTotal, r.grasaUtilizada, r.refaMateHerra, c.fechaFinal, c.horaFinal, c.trabajoSanitizado, c.estatusActividad, c.firmaSolicitante, U.usuario as nombre3, c.emailSent2, c.fechaFirma, c.horaFirma, c.comentariosSolicitante from SolicitudPreventiva as S inner join Diagnostico as D on S.idSolicitud=D.idSolicitud inner join Reparacion as R on D.idSolicitud= R.idSolicitud inner join CierreSolicitud as C on R.idSolicitud= C.idSolicitud inner join Mecanicos M on D.nomina=M.nomina  inner join Mecanicos M2 on D.nomina2=M2.nomina inner join Usuarios U on C.firmaSolicitante=U.nomina3 where ((d.nomina={temp} or d.nomina2 = {temp}) and (c.estatusActividad = 'Cancelado' or c.estatusActividad ='Terminado'))", conn);

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


                    //diagnostico
                    int nomina = dr.GetInt32(9);
                    string nombre = dr.GetString(10).Trim();
                    string fechaInicio = dr.GetString(11).Trim();
                    string horaInicio = dr.GetString(12).Trim();
                    string diagnostico = dr.GetString(13).Trim();
                    string tipoFalla = dr.GetString(14).Trim();
                    string emailSent = dr.GetString(15).Trim();
                    int nomina2 = dr.GetInt32(16);
                    string nombre2 = dr.GetString(17).Trim();
                    string asignacion = dr.GetString(18).Trim();

                    //reparacion
                    string tareasEjecutadas = dr.GetString(19).Trim();
                    string generoParo = dr.GetString(20).Trim();
                    int paroCorrectivo = dr.GetInt32(21);
                    int paroOperativo = dr.GetInt32(22);
                    int paroRefaccion = dr.GetInt32(23);
                    int tiempoTotal = dr.GetInt32(24);
                    string grasaUtilizada = dr.GetString(25).Trim();
                    string refaMateHerra = dr.GetString(26).Trim();

                    //cierre solicitud
                    string fechaFinal = dr.GetString(27).Trim();
                    string horaFinal = dr.GetString(28).Trim();
                    string trabajoSanitizado = dr.GetString(29).Trim();
                    string estatusActividad = dr.GetString(30).Trim();
                    string firmaSolicitante = dr.GetString(31).Trim();
                    string nombre3 = dr.GetString(32).Trim();
                    string emailSent2 = dr.GetString(33).Trim();
                    string fechaFirma = dr.GetString(34).Trim();
                    string horaFirma = dr.GetString(35).Trim();
                    string comentariosSolicitante = dr.GetString(36).Trim();

                    solicitud Solicitud = new solicitud(idSolicitud,
                   nombreSolicitante,
                   correo,
                   fechaSolicitud,
                   horaSolicitud,
                   area,
                   maquina,
                   dispositivo,
                   descripcionProblema,
                    //diagnostico
                    nomina,
                    nombre,
                    fechaInicio,
                    horaInicio,
                    diagnostico,
                    tipoFalla,
                    emailSent,
                    nomina2,
                    nombre2,
                    asignacion,

                    //reparacion
                    tareasEjecutadas,
                    generoParo,
                    paroCorrectivo,
                    paroOperativo,
                    paroRefaccion,
                    tiempoTotal,
                    grasaUtilizada,
                    refaMateHerra,

                    //cierreSolicitud
                    fechaFinal,
                    horaFinal,
                    trabajoSanitizado,
                    estatusActividad,
                    firmaSolicitante,
                    nombre3,
                    emailSent2,
                    fechaFirma,
                    horaFirma,
                    comentariosSolicitante
                    );

                    lista.Add(Solicitud);
                }
                dr.Close();
                conn.Close();
            }
            return lista;
        }
        public List<solicitud> GetSolicitudsById2CierreTemporales(int id2)
        {

            List<solicitud> lista = new List<solicitud>();
            string strConn = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                String temp = id2 + "";

                SqlCommand cmd = new SqlCommand($"select s.idSolicitud, s.nombreSolicitante, s.correo, s.fechaSolicitud, s.horaSolicitud, s.area, s.maquina, s.dispositivo, s.descripcionProblema, d.nomina, m.nombre, d.fechaInicio, d.horaInicio, d.diagnostico, d.tipoFalla, d.emailSent, d.nomina2, m2.nombre as nombre2, d.asignacion, r.tareasEjecutadas, r.generoParo, r.paroCorrectivo, r.paroOperativo, r.paroRefacccion, r.tiempoTotal, r.grasaUtilizada, r.refaMateHerra, c.fechaFinal, c.horaFinal, c.trabajoSanitizado, c.estatusActividad, c.firmaSolicitante, U.usuario as nombre3, c.emailSent2, c.fechaFirma, c.horaFirma, c.comentariosSolicitante from SolicitudPreventiva as S inner join Diagnostico as D on S.idSolicitud=D.idSolicitud inner join Reparacion as R on D.idSolicitud= R.idSolicitud inner join CierreSolicitud as C on R.idSolicitud= C.idSolicitud inner join Mecanicos M on D.nomina=M.nomina  inner join Mecanicos M2 on D.nomina2=M2.nomina inner join Usuarios U on C.firmaSolicitante=U.nomina3 where ((d.nomina={temp} or d.nomina2 = {temp}) and (c.estatusActividad ='Falta de refacción(Trabajo Temporal)'))", conn);

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


                    //diagnostico
                    int nomina = dr.GetInt32(9);
                    string nombre = dr.GetString(10).Trim();
                    string fechaInicio = dr.GetString(11).Trim();
                    string horaInicio = dr.GetString(12).Trim();
                    string diagnostico = dr.GetString(13).Trim();
                    string tipoFalla = dr.GetString(14).Trim();
                    string emailSent = dr.GetString(15).Trim();
                    int nomina2 = dr.GetInt32(16);
                    string nombre2 = dr.GetString(17).Trim();
                    string asignacion = dr.GetString(18).Trim();

                    //reparacion
                    string tareasEjecutadas = dr.GetString(19).Trim();
                    string generoParo = dr.GetString(20).Trim();
                    int paroCorrectivo = dr.GetInt32(21);
                    int paroOperativo = dr.GetInt32(22);
                    int paroRefaccion = dr.GetInt32(23);
                    int tiempoTotal = dr.GetInt32(24);
                    string grasaUtilizada = dr.GetString(25).Trim();
                    string refaMateHerra = dr.GetString(26).Trim();

                    //cierre solicitud
                    string fechaFinal = dr.GetString(27).Trim();
                    string horaFinal = dr.GetString(28).Trim();
                    string trabajoSanitizado = dr.GetString(29).Trim();
                    string estatusActividad = dr.GetString(30).Trim();
                    string firmaSolicitante = dr.GetString(31).Trim();
                    string nombre3 = dr.GetString(32).Trim();
                    string emailSent2 = dr.GetString(33).Trim();
                    string fechaFirma = dr.GetString(34).Trim();
                    string horaFirma = dr.GetString(35).Trim();
                    string comentariosSolicitante = dr.GetString(36).Trim();

                    solicitud Solicitud = new solicitud(idSolicitud,
                   nombreSolicitante,
                   correo,
                   fechaSolicitud,
                   horaSolicitud,
                   area,
                   maquina,
                   dispositivo,
                   descripcionProblema,
                    //diagnostico
                    nomina,
                    nombre,
                    fechaInicio,
                    horaInicio,
                    diagnostico,
                    tipoFalla,
                    emailSent,
                    nomina2,
                    nombre2,
                    asignacion,

                    //reparacion
                    tareasEjecutadas,
                    generoParo,
                    paroCorrectivo,
                    paroOperativo,
                    paroRefaccion,
                    tiempoTotal,
                    grasaUtilizada,
                    refaMateHerra,

                    //cierreSolicitud
                    fechaFinal,
                    horaFinal,
                    trabajoSanitizado,
                    estatusActividad,
                    firmaSolicitante,
                    nombre3,
                    emailSent2,
                    fechaFirma,
                    horaFirma,
                    comentariosSolicitante
                    );

                    lista.Add(Solicitud);
                }
                dr.Close();
                conn.Close();
            }
            return lista;
        }
        public List<solicitud> GetSolicitudsById3(int id2)
        {

            List<solicitud> lista = new List<solicitud>();
            string strConn = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                String temp = id2 + "";

                SqlCommand cmd = new SqlCommand("select s.idSolicitud, s.nombreSolicitante, s.correo, s.fechaSolicitud, s.horaSolicitud, s.area, s.maquina, s.dispositivo, s.descripcionProblema, d.nomina, m.nombre, d.fechaInicio, d.horaInicio, d.diagnostico, d.tipoFalla, d.emailSent, d.nomina2, m2.nombre as nombre2, d.asignacion, r.tareasEjecutadas, r.generoParo, r.paroCorrectivo, r.paroOperativo, r.paroRefacccion, r.tiempoTotal, r.grasaUtilizada, r.refaMateHerra, c.fechaFinal, c.horaFinal, c.trabajoSanitizado, c.estatusActividad, c.firmaSolicitante, U.usuario as nombre3, c.emailSent2, c.fechaFirma, c.horaFirma, c.comentariosSolicitante from SolicitudPreventiva as S inner join Diagnostico as D on S.idSolicitud=D.idSolicitud inner join Reparacion as R on D.idSolicitud= R.idSolicitud inner join CierreSolicitud as C on R.idSolicitud= C.idSolicitud inner join Mecanicos M on D.nomina=M.nomina  inner join Mecanicos M2 on D.nomina2=M2.nomina inner join Usuarios U on C.firmaSolicitante=U.nomina3 where c.estatusActividad!='Terminado' and d.nomina2=" + temp, conn);

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


                    //diagnostico
                    int nomina = dr.GetInt32(9);
                    string nombre = dr.GetString(10).Trim();
                    string fechaInicio = dr.GetString(11).Trim();
                    string horaInicio = dr.GetString(12).Trim();
                    string diagnostico = dr.GetString(13).Trim();
                    string tipoFalla = dr.GetString(14).Trim();
                    string emailSent = dr.GetString(15).Trim();
                    int nomina2 = dr.GetInt32(16);
                    string nombre2 = dr.GetString(17).Trim();
                    string asignacion = dr.GetString(18).Trim();

                    //reparacion
                    string tareasEjecutadas = dr.GetString(19).Trim();
                    string generoParo = dr.GetString(20).Trim();
                    int paroCorrectivo = dr.GetInt32(21);
                    int paroOperativo = dr.GetInt32(22);
                    int paroRefaccion = dr.GetInt32(23);
                    int tiempoTotal = dr.GetInt32(24);
                    string grasaUtilizada = dr.GetString(25).Trim();
                    string refaMateHerra = dr.GetString(26).Trim();

                    //cierre solicitud
                    string fechaFinal = dr.GetString(27).Trim();
                    string horaFinal = dr.GetString(28).Trim();
                    string trabajoSanitizado = dr.GetString(29).Trim();
                    string estatusActividad = dr.GetString(30).Trim();
                    string firmaSolicitante = dr.GetString(31).Trim();
                    string nombre3 = dr.GetString(32).Trim();
                    string emailSent2 = dr.GetString(33).Trim();
                    string fechaFirma = dr.GetString(34).Trim();
                    string horaFirma = dr.GetString(35).Trim();
                    string comentariosSolicitante = dr.GetString(36).Trim();

                    solicitud Solicitud = new solicitud(idSolicitud,
                   nombreSolicitante,
                   correo,
                   fechaSolicitud,
                   horaSolicitud,
                   area,
                   maquina,
                   dispositivo,
                   descripcionProblema,
                    //diagnostico
                    nomina,
                    nombre,
                    fechaInicio,
                    horaInicio,
                    diagnostico,
                    tipoFalla,
                    emailSent,
                    nomina2,
                    nombre2,
                    asignacion,

                    //reparacion
                    tareasEjecutadas,
                    generoParo,
                    paroCorrectivo,
                    paroOperativo,
                    paroRefaccion,
                    tiempoTotal,
                    grasaUtilizada,
                    refaMateHerra,

                    //cierreSolicitud
                    fechaFinal,
                    horaFinal,
                    trabajoSanitizado,
                    estatusActividad,
                    firmaSolicitante,
                    nombre3,
                    emailSent2,
                    fechaFirma,
                    horaFirma, 
                    comentariosSolicitante);

                    lista.Add(Solicitud);
                }
                dr.Close();
                conn.Close();
            }
            return lista;
        }







        public bool addSolicitud(solicitud Solicitud)
        {
            bool res = false;
            string strConn = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                SqlCommand cmd = conn.CreateCommand();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                cmd.CommandText = "solicitud_Add";
                cmd.CommandType = CommandType.StoredProcedure;
                
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


        public bool updateSolicitud(int id, solicitud Solicitud)
        {
            bool res = false;
            string strConn = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                SqlCommand cmd = conn.CreateCommand();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
               
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

        internal IEnumerable<solicitud> GetSolicitudsById(string id2)
        {
            throw new NotImplementedException();
        }
    }
}