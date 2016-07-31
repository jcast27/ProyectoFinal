using SIME_UTN.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using SIME_UTN.DTOs;

namespace SIME_UTN.DAL
{
    class RegistroProductoDAL
    {
        static RegistroProducto viejoRegProducto = null;
        internal static int GuardarRegistroProducto(RegistroProducto unRegProd, string usuarioLogueadop)
        {
            viejoRegProducto = new RegistroProducto();
            string accion = "";
            accion = "Insertar";
            int ultimiIdInsertado = 0;
            SqlCommand comando = new SqlCommand("sp_INSERT_RegistroProducto");
            comando.CommandType = CommandType.StoredProcedure;

           
            comando.Parameters.AddWithValue("@idusuario", unRegProd.Usuario.codigoUsuario);
            comando.Parameters.AddWithValue("@idregistroBodega", unRegProd.Bodega.idRegistroBodega);
            comando.Parameters.AddWithValue("@descripcion", unRegProd.descripcion);
            comando.Parameters.AddWithValue("@solicitudavatar", unRegProd.solicitudAvatar);
            comando.Parameters.AddWithValue("@fechaingreso", unRegProd.fechaIngreso);
            comando.Parameters.AddWithValue("@estado", unRegProd.estado);

            viejoRegProducto = ObtenerRegistroProductoPorID(unRegProd.idIngresoProducto);
           

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                DataSet ds = db.ExecuteReader(comando, "consulta");


                foreach (DataRow dr in ds.Tables[0].Rows)
                {

                    ultimiIdInsertado = Convert.ToInt32(dr["IDIngresoProducto"].ToString());

                }
            }
            GuardarLog(unRegProd, usuarioLogueadop, accion, null);
            return ultimiIdInsertado;
        }

        internal static void EliminarRegistroProducto(int idRegistroBodega,int idRegProd, string regProd, string usuarioLogueadop)
        {
            string accion = "";
            accion = "Eliminar";
          


            SqlCommand comando = new SqlCommand("sp_DISABLE_RegistroProducto_ByID");
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@idingresoproducto", idRegProd);
           

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                db.ExecuteNonQuery(comando);
            }
            GuardarLog(null, usuarioLogueadop, accion, regProd);
         
        }

        internal static void DescargarInvetarioRegistroProductoEliminado(int idRegistroBodega,List<RegistroIngresoProductoDTO> listregistriIngresoProductop)
        {
           

            foreach(RegistroIngresoProductoDTO registriIngresoProducto in listregistriIngresoProductop)
            {
                SqlCommand comando = new SqlCommand("sp_DescargarInventario");
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idregistrobodega", idRegistroBodega);
                comando.Parameters.AddWithValue("@idproducto", registriIngresoProducto.idProducto);
                comando.Parameters.AddWithValue("@UCantidadIngresada", registriIngresoProducto.uCantidad);


                using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
                {
                    db.ExecuteNonQuery(comando);
                }
            }
          
        }

        internal static void ActualizarRegistroProducto(RegistroProducto unRegProd, string usuarioLogueadop)
        {
            viejoRegProducto = new RegistroProducto();
            string accion = "";
            accion = "Modificar";
            SqlCommand comando = new SqlCommand("sp_UPDATE_RegistroProducto");
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idingresoproducto", unRegProd.idIngresoProducto);
            comando.Parameters.AddWithValue("@idusuario", unRegProd.Usuario.codigoUsuario);
            comando.Parameters.AddWithValue("@descripcion", unRegProd.descripcion);
            comando.Parameters.AddWithValue("@solicitudavatar", unRegProd.solicitudAvatar);
            comando.Parameters.AddWithValue("@fechaingreso", unRegProd.fechaIngreso);
            comando.Parameters.AddWithValue("@estado", unRegProd.estado);
            viejoRegProducto = ObtenerRegistroProductoPorID(unRegProd.idIngresoProducto);
            
            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                db.ExecuteNonQuery(comando);
            }
            GuardarLog(unRegProd, usuarioLogueadop, accion, null);
        }
        internal static RegistroProducto ObtenerRegistroProductoPorID(int idIngresoProducto)
        {
            RegistroProducto registroProducto = new RegistroProducto();
            SqlCommand comando = new SqlCommand("sp_SELECT_RegistroProducto_ByID");
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@idingresoproducto", idIngresoProducto);

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                DataSet ds = db.ExecuteReader(comando, "consulta");


                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    UsuarioTable usuario = new UsuarioTable();
                    registroProducto.idIngresoProducto = Convert.ToInt32(dr["idingresoproducto"].ToString());
                    usuario = UsuarioDAL.ObtenerUsuarioID(Convert.ToInt32(dr["idusuario"].ToString()));
                    registroProducto.Usuario = usuario;
                    registroProducto.descripcion = dr["descripcion"].ToString();
                    registroProducto.solicitudAvatar = dr["solicitudavatar"].ToString();
                    registroProducto.fechaIngreso = dr["fechaingreso"].ToString();

                }
            }

            return registroProducto;
        }

        public static void GuardarLog(RegistroProducto unRegProd, string usuarioLogueado, string accion, string registroEliminado)
        {

            string descripcion = "";
            string estado = "";
            RegistroProducto nuevoRegProducto = new RegistroProducto();

            if (accion == "Eliminar")
            {
                descripcion = "Registro Producto eliminado: " + registroEliminado;
                estado = "Desactivado";
            }
            if (accion == "Insertar")
            {
                estado = "Activo";
                descripcion = "\r\nRegistro de Producto";
                descripcion += "\r\n-----------------------------------------------------------------------\r\n";
                descripcion += "Registro Producto: " + unRegProd.descripcion + "\r\nSolicitud Avatar: " +
                unRegProd.solicitudAvatar + "\r\nUsuario: " + unRegProd.Usuario.nombre
                + "\r\nFecha de Ingreso: " + unRegProd.fechaIngreso + "\r\nEstado: " + estado;

            }
            if (accion == "Modificar")
            {
                nuevoRegProducto = ObtenerRegistroProductoPorID(unRegProd.idIngresoProducto);
                
                estado = "Activo";
                descripcion = "\r\nRegistro de Producto";
                descripcion += "\r\n-----------------------------------------------------------------------\r\n";
                descripcion += "Antes del Cambio" + "\r\nRegistro Producto: " + viejoRegProducto.descripcion + "\r\nSolicitud Avatar: " +
                viejoRegProducto.solicitudAvatar + "\r\nUsuario: " + viejoRegProducto.Usuario.nombre
                + "\r\nFecha de Ingreso: " + viejoRegProducto.fechaIngreso + "\r\nEstado: " + estado;

                descripcion += "\r\n-----------------------------------------------------------------------\r\n";

                descripcion += "Despues del Cambio" + "\r\nRegistro Producto: " + nuevoRegProducto.descripcion + "\r\nSolicitud Avatar: " +
                nuevoRegProducto.solicitudAvatar + "\r\nUsuario: " + nuevoRegProducto.Usuario.nombre
                + "\r\nFecha de Ingreso: " + nuevoRegProducto.fechaIngreso + "\r\nEstado: " + estado;
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
