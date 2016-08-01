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
        static Producto viejoProducto = null;

        /// <summary>
        /// Metodo que guarda una nueva mezcla
        /// </summary>
        /// <param name="unaMezclap"></param>
        /// <param name="usuarioLogueadop"></param>
        internal static int GuardarRegistroMezcla(Mezcla unaMezclap,string usuarioLogueadop)
        {
            viejoProducto = new Producto();
            string accion = "";
            accion = "Insertar";
            int ultimiIdInsertado = 0;

            SqlCommand comando = new SqlCommand("sp_INSERT_Producto");
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@codigoavatar", "Mezcla");
            comando.Parameters.AddWithValue("@nombre", unaMezclap.nombre);
            comando.Parameters.AddWithValue("@descripcion", unaMezclap.descripcion);
            comando.Parameters.AddWithValue("@idcategoria", unaMezclap.Categoria.idCategoria);
            comando.Parameters.AddWithValue("@idunidadmedida", 10);
            comando.Parameters.AddWithValue("@contenido", 0);
            comando.Parameters.AddWithValue("@stockminimo", 1);
            comando.Parameters.AddWithValue("@stockmaximo", 1000);
            comando.Parameters.AddWithValue("@estado", unaMezclap.estado);

            viejoProducto = ProductoDAL.ObtenerProductoPorID(unaMezclap.idRegistroMezcla);


            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                DataSet ds = db.ExecuteReader(comando, "consulta");


                foreach (DataRow dr in ds.Tables[0].Rows)
                {

                    ultimiIdInsertado = Convert.ToInt32(dr["IDRegistroMezcla"].ToString());

                }
            }
            GuardarLog(unaMezclap, usuarioLogueadop, accion, null);
            return ultimiIdInsertado;
        }


        /// <summary>
        /// Metodo que desabilita una mezcla
        /// </summary>
        /// <param name="idRegistroMezclap"></param>
        /// <param name="nombrep"></param>
        /// <param name="usuarioLogueadop"></param>
        internal static void EliminarMezcla(int idRegistroMezclap, string nombrep, string usuarioLogueadop)
        {
            string accion = "";
            accion = "Eliminar";
            SqlCommand comando = new SqlCommand("sp_DISABLE_Producto_ByID");
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@idproducto", idRegistroMezclap);
           

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                db.ExecuteNonQuery(comando);
            }
            GuardarLog(null, usuarioLogueadop, accion, nombrep);
        }


        /// <summary>
        /// Metodo que actualiza una mezcla
        /// </summary>
        /// <param name="unaMezclap"></param>
        /// <param name="usuarioLogueadop"></param>
        internal static void ActualizarMezcla(Mezcla unaMezclap, string usuarioLogueadop)
        {
            viejoProducto = new Producto();
            string accion = "";
            accion = "Modificar";


            SqlCommand comando = new SqlCommand("sp_UPDATE_Producto");
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idproducto", unaMezclap.idRegistroMezcla);
            comando.Parameters.AddWithValue("@codigoavatar", "Mezcla");
            comando.Parameters.AddWithValue("@nombre", unaMezclap.nombre);
            comando.Parameters.AddWithValue("@descripcion", unaMezclap.descripcion);
            comando.Parameters.AddWithValue("@idcategoria", unaMezclap.Categoria.idCategoria);
            comando.Parameters.AddWithValue("@idunidadmedida", 10);
            comando.Parameters.AddWithValue("@contenido", 0);
            comando.Parameters.AddWithValue("@stockminimo", 1);
            comando.Parameters.AddWithValue("@stockmaximo", 1000);
            comando.Parameters.AddWithValue("@estado", unaMezclap.estado);
            viejoProducto = ProductoDAL.ObtenerProductoPorID(unaMezclap.idRegistroMezcla);
            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                db.ExecuteNonQuery(comando);
            }
            GuardarLog(unaMezclap, usuarioLogueadop, accion, null);
        }



        /// <summary>
        /// Metodo que genera un log para toda transaccion
        /// </summary>
        /// <param name="unaMezclap"></param>
        /// <param name="usuarioLogueadop"></param>
        /// <param name="accion"></param>
        /// <param name="mezclaEliminadap"></param>
        public static void GuardarLog(Mezcla unaMezclap, string usuarioLogueado, string accion, string mezclaEliminadap)
        {
            Producto nuevoProducto = new Producto();
            string descripcion = "";
            string estado = "";
           

            if (accion == "Eliminar")
            {
                descripcion = "Mezcla eliminada: " + mezclaEliminadap;
                estado = "Desactivado";
            }
            if (accion == "Insertar")
            {
                estado = "Activo";
                descripcion = "\r\nRegistro Mezcla";
                descripcion += "\r\n-----------------------------------------------------------------------\r\n";
                descripcion += "Nombre Mezcla: " + unaMezclap.nombre + "\r\nDescripción: " + unaMezclap.descripcion + "\r\nCategoria: "+unaMezclap.Categoria.descripcion+"\r\nEstado: " + estado;

            }
            if (accion == "Modificar")
            {
                
                nuevoProducto = ProductoDAL.ObtenerProductoPorID(unaMezclap.idRegistroMezcla);
                estado = "Activo";
                descripcion = "\r\nRegistro Mezcla";
                descripcion += "\r\n-----------------------------------------------------------------------\r\n";
                descripcion += "Antes del Cambio" + "\r\nNombre Mezcla: " + viejoProducto.nombreProducto + "\r\nDescripción: " + viejoProducto.descripcion + "\r\nCategoria: " + viejoProducto.Categoria.descripcion + "\r\nEstado: " + estado;
                descripcion += "\r\n-----------------------------------------------------------------------\r\n";
                descripcion += "Despues del Cambio" + "\r\nNombre Mezcla: " + nuevoProducto.nombreProducto + "\r\nDescripción: " + nuevoProducto.descripcion + "\r\nCategoria: " + nuevoProducto.Categoria.descripcion + "\r\nEstado: " + estado;
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
