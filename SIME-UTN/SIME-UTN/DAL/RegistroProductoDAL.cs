using SIME_UTN.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace SIME_UTN.DAL
{
    class RegistroProductoDAL
    {
        internal static int GuardarRegistroProducto(RegistroProducto unRegProd, string usuarioLogueadop)
        {
            string accion = "";
            accion = "Insertar";
            int ultimiIdInsertado = 0;
            SqlCommand comando = new SqlCommand("sp_INSERT_RegistroProducto");
            comando.CommandType = CommandType.StoredProcedure;

           
            comando.Parameters.AddWithValue("@idusuario", unRegProd.Usuario.codigoUsuario);
            comando.Parameters.AddWithValue("@descripcion", unRegProd.descripcion);
            comando.Parameters.AddWithValue("@solicitudavatar", unRegProd.solicitudAvatar);
            comando.Parameters.AddWithValue("@fechaingreso", unRegProd.fechaIngreso);
            comando.Parameters.AddWithValue("@fechacaducidad", unRegProd.fechaCaducidad);
            comando.Parameters.AddWithValue("@estado", unRegProd.estado);


            GuardarLog(unRegProd, usuarioLogueadop, accion, null);

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                DataSet ds = db.ExecuteReader(comando, "consulta");


                foreach (DataRow dr in ds.Tables[0].Rows)
                {

                    ultimiIdInsertado = Convert.ToInt32(dr["IDIngresoProducto"].ToString());

                }
            }

            return ultimiIdInsertado;
        }

        internal static void EliminarRegistroProducto(int idRegProd, string regProd, string usuarioLogueadop)
        {
            string accion = "";
            accion = "Eliminar";
            SqlCommand comando = new SqlCommand("sp_DISABLE_RegistroProducto_ByID");
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@idingresoproducto", idRegProd);
            GuardarLog(null, usuarioLogueadop, accion, regProd);

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                db.ExecuteNonQuery(comando);
            }
        }

        internal static void ActualizarRegistroProducto(RegistroProducto unRegProd, string usuarioLogueadop)
        {
            string accion = "";
            accion = "Modificar";
            SqlCommand comando = new SqlCommand("sp_UPDATE_RegistroProducto");
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idingresoproducto", unRegProd.idIngresoProducto);
            comando.Parameters.AddWithValue("@idusuario", unRegProd.Usuario.codigoUsuario);
            comando.Parameters.AddWithValue("@descripcion", unRegProd.descripcion);
            comando.Parameters.AddWithValue("@solicitudavatar", unRegProd.solicitudAvatar);
            comando.Parameters.AddWithValue("@fechaingreso", unRegProd.fechaIngreso);
            comando.Parameters.AddWithValue("@fechacaducidad", unRegProd.fechaCaducidad);
            comando.Parameters.AddWithValue("@estado", unRegProd.estado);

            GuardarLog(unRegProd, usuarioLogueadop, accion, null);
            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                db.ExecuteNonQuery(comando);
            }
        }

        public static void GuardarLog(RegistroProducto unRegProd, string usuarioLogueado, string accion, string registroEliminado)
        {

            string descripcion = "";
            string estado = "";
            if (unRegProd == null)
            {
                descripcion = "Registro Producto eliminado: " + registroEliminado;
                estado = "Desactivado";
            }
            else
            {
                estado = "Activo";
                descripcion = "Registro Producto: " + unRegProd.descripcion + "\r\nSolicitud Avatar: " +
                unRegProd.solicitudAvatar + "\r\nUsuario: " + unRegProd.Usuario.nombre 
                + "\r\nFecha de Ingreso: " + unRegProd.fechaIngreso +"\r\nFecha de Caducidad: " +
                unRegProd.fechaCaducidad + "\r\nEstado: " + estado;

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
