using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIME_UTN.Entities;
using SIME_UTN.DTOs;
using System.Data.SqlClient;
using System.Data;

namespace SIME_UTN.DAL
{
    class RegistroMezclaDAL
    {
        internal static int GuardarRegistroMezcla(Mezcla unaMezclap,string usuarioLogueadop)
        {
            string accion = "";
            accion = "Insertar";
            int ultimiIdInsertado = 0;
            SqlCommand comando = new SqlCommand("sp_INSERT_RegistroMezcla");
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@nombre", unaMezclap.nombre);
            comando.Parameters.AddWithValue("@descripcion", unaMezclap.descripcion);
            comando.Parameters.AddWithValue("@estado", unaMezclap.estado);

            GuardarLog(unaMezclap, usuarioLogueadop, accion, null);

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                DataSet ds = db.ExecuteReader(comando, "consulta");


                foreach (DataRow dr in ds.Tables[0].Rows)
                {

                    ultimiIdInsertado = Convert.ToInt32(dr["IDRegistroMezcla"].ToString());

                }
            }

            return ultimiIdInsertado;
        }

        internal static void ActualizarMezcla(Mezcla unaMezclap, string usuarioLogueadop)
        {
            string accion = "";
            accion = "Modificar";
            SqlCommand comando = new SqlCommand("sp_UPDATE_RegistroMezcla");
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idregistromezcla", unaMezclap.idRegistroMezcla);
            comando.Parameters.AddWithValue("@nombre", unaMezclap.nombre);
            comando.Parameters.AddWithValue("@descripcion", unaMezclap.descripcion);
            comando.Parameters.AddWithValue("@estado", unaMezclap.estado);
            GuardarLog(unaMezclap, usuarioLogueadop, accion, null);
            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                db.ExecuteNonQuery(comando);
            }
        }

        public static void GuardarLog(Mezcla unaMezclap, string usuarioLogueado, string accion, string mezclaEliminadap)
        {

            string descripcion = "";
            string estado = "";
            if (unaMezclap == null)
            {
                descripcion = "Mezcla eliminada: " + mezclaEliminadap;
                estado = "Desactivado";
            }
            else
            {
                estado = "Activo";
                descripcion = "Mombre Mezcla: " + unaMezclap.nombre + "\r\nDescripcion: " + unaMezclap.descripcion + "\r\nEstado: " + estado;

            }
            DateTime date = DateTime.Now;
            string fecha = date.ToString("dd/MM/yyyy");
            SqlCommand comando = new SqlCommand("sp_INSERT_log");
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@usuario", usuarioLogueado);
            comando.Parameters.AddWithValue("@accion", accion);
            comando.Parameters.AddWithValue("@descripcion", descripcion);
            comando.Parameters.AddWithValue("@fechamodificacion", fecha);
            comando.Parameters.AddWithValue("@estado", 1);


            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                db.ExecuteNonQuery(comando);
            }

        }
    }
}
