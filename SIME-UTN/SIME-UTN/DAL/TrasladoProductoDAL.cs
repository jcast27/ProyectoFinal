using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIME_UTN.Entities;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using SIME_UTN.DTOs;

namespace SIME_UTN.DAL
{
    class TrasladoProductoDAL
    {
        static TrasladoProducto viejoTraslado = null;

        /// <summary>
        /// Metodo que declina un traslado
        /// </summary>
        /// <param name="trasladoEstatico"></param>
        /// <param name="usuarioLogueadop"></param>
        internal static void DeclinarTraslado(TrasladoProducto trasladoEstatico, string usuarioLogueadop)
        {
            viejoTraslado = new TrasladoProducto();
            string accion = "";
            accion = "Modificar";
         
            SqlCommand comando = new SqlCommand("sp_DECLINE_TrasladoProducto_ByID");
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@idtraslado", trasladoEstatico.idTraslado);
            viejoTraslado = ObtenerTrasladoPorID(trasladoEstatico.idTraslado);
            

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                db.ExecuteNonQuery(comando);
            }
            GuardarLog(trasladoEstatico, usuarioLogueadop, accion, null);
           
        }


        /// <summary>
        /// Metodo que acepta un traslado
        /// </summary>
        /// <param name="trasladoEstatico"></param>
        /// <param name="usuarioLogueadop"></param>
        internal static void AceptarTraslado(TrasladoProducto trasladoEstatico, string usuarioLogueadop)
        {
            viejoTraslado = new TrasladoProducto();
            string accion = "";
            accion = "Modificar";
            SqlCommand comando = new SqlCommand("sp_ACCEPT_TrasladoProducto_ByID");
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@idtraslado", trasladoEstatico.idTraslado);
            viejoTraslado = ObtenerTrasladoPorID(trasladoEstatico.idTraslado);
            
            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                db.ExecuteNonQuery(comando);
            }
            GuardarLog(trasladoEstatico, usuarioLogueadop, accion, null);
          
        }


        /// <summary>
        /// Metodo que traslada los productos a la bodega destino
        /// </summary>
        /// <param name="trasladoEstatico"></param>
        /// <param name="listaProductosDTO"></param>
        internal static void TrasladarProductosABodegaDestino(TrasladoProducto trasladoEstatico, List<TrasladoProductoInterDTO> listaProductosDTO)
        {
            foreach (TrasladoProductoInterDTO producto in listaProductosDTO)
            {
                SqlCommand comando = new SqlCommand("sp_TrasladarProductoABodegaDestino");
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idregistrobodega", trasladoEstatico.BodegaDestino.idRegistroBodega);
                comando.Parameters.AddWithValue("@idproducto", producto.idProducto);
                comando.Parameters.AddWithValue("@CantidadIngresada", producto.cantidad);


                using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
                {
                    db.ExecuteNonQuery(comando);
                }
            }
        }


        /// <summary>
        /// Metodo que devuelve los producto a la bodega origen
        /// </summary>
        /// <param name="trasladoEstatico"></param>
        /// <param name="listaProductosDTO"></param>
        internal static void VolverProductoEliminadoABodega(TrasladoProducto trasladoEstatico, List<TrasladoProductoInterDTO> listaProductosDTO)
        {


            foreach (TrasladoProductoInterDTO producto in listaProductosDTO)
            {
                SqlCommand comando = new SqlCommand("sp_VolverProductoABodega");
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idregistrobodega", trasladoEstatico.BodegaOrigen.idRegistroBodega);
                comando.Parameters.AddWithValue("@idproducto", producto.idProducto);
                comando.Parameters.AddWithValue("@CantidadIngresada", producto.cantidad);


                using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
                {
                    db.ExecuteNonQuery(comando);
                }
            }

        }


        /// <summary>
        /// Metodo que guarda un nuevo traslado
        /// </summary>
        /// <param name="trasladop"></param>
        /// <param name="usuarioLogueadop"></param>
        internal static void GuardarTraslado(TrasladoProducto trasladop, string usuarioLogueadop)
        {
            viejoTraslado = new TrasladoProducto();
            string accion = "";
            accion = "Insertar";

            SqlCommand comando = new SqlCommand("sp_INSERT_TrasladoProducto");
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@idregistrobodegaorigen", trasladop.BodegaOrigen.idRegistroBodega);
            comando.Parameters.AddWithValue("@idregistrobodegadestino", trasladop.BodegaDestino.idRegistroBodega);
            comando.Parameters.AddWithValue("@idusuario", trasladop.Usuario.codigoUsuario);
            comando.Parameters.AddWithValue("@observaciones", trasladop.observaciones);
            comando.Parameters.AddWithValue("@fechatraslado", trasladop.fechaTraslado);
            comando.Parameters.AddWithValue("@tipotraslado", trasladop.TipoTraslado.idTipoTraslado);
            comando.Parameters.AddWithValue("@estadotraslado", trasladop.EstadoTraslado.idEstadoTraslado);
            comando.Parameters.AddWithValue("@estado", trasladop.estado);
            viejoTraslado = ObtenerTrasladoPorID(trasladop.idTraslado);
          

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                db.ExecuteNonQuery(comando);
            }
            GuardarLog(trasladop, usuarioLogueadop, accion, null);
        }


        /// <summary>
        /// Metodo que actualiza un traslado existente
        /// </summary>
        /// <param name="trasladop"></param>
        /// <param name="usuarioLogueadop"></param>
        internal static void ActualizarTraslado(TrasladoProducto trasladop, string usuarioLogueadop)
        {
            viejoTraslado = new TrasladoProducto();
            string accion = "";
            accion = "Modificar";

            SqlCommand comando = new SqlCommand("sp_UPDATE_TrasladoProducto");
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@idtraslado", trasladop.idTraslado);
            comando.Parameters.AddWithValue("@idregistrobodegaorigen", trasladop.BodegaOrigen.idRegistroBodega);
            comando.Parameters.AddWithValue("@idregistrobodegadestino", trasladop.BodegaDestino.idRegistroBodega);
            comando.Parameters.AddWithValue("@idusuario", trasladop.Usuario.codigoUsuario);
            comando.Parameters.AddWithValue("@observaciones", trasladop.observaciones);
            comando.Parameters.AddWithValue("@fechatraslado", trasladop.fechaTraslado);
            comando.Parameters.AddWithValue("@tipotraslado", trasladop.TipoTraslado.idTipoTraslado);
            comando.Parameters.AddWithValue("@estadotraslado", trasladop.EstadoTraslado.idEstadoTraslado);
            comando.Parameters.AddWithValue("@estado", trasladop.estado);
            viejoTraslado = ObtenerTrasladoPorID(trasladop.idTraslado);
           

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                db.ExecuteNonQuery(comando);
            }
            GuardarLog(trasladop, usuarioLogueadop, accion, null);
        }

        /// <summary>
        /// Metodo que valida si el traslado ya existe
        /// </summary>
        /// <param name="idTraslado"></param>
        /// <returns></returns>
        internal static bool ObtenerTrasladoByID(int idTraslado)
        {
            bool existe = false;
            string sql = @"sp_SELECT_TrasladoProducto_ByID";

            List<Item> lista = new List<Item>();

            SqlCommand command = new SqlCommand(sql);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@idtraslado", idTraslado);

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                DataSet ds = db.ExecuteReader(command, "consulta");

                if (ds.Tables[0].Rows.Count > 0)
                {
                    existe = true;
                }

            }
            return existe;
        }

        /// <summary>
        /// Metodo que genera un log para toda transaccion
        /// </summary>
        /// <param name="unaMezclap"></param>
        /// <param name="usuarioLogueadop"></param>
        /// <param name="accion"></param>
        /// <param name="mezclaEliminadap"></param>
        public static void GuardarLog(TrasladoProducto trasladop, string usuarioLogueado, string accion, string trasladoEliminadop)
        {

            TrasladoProducto nuevoTraslado = new TrasladoProducto();
            string descripcion = "";
            string estado = "";

            if (accion == "Eliminar")
            {
                descripcion = "Producto eliminada: " + trasladoEliminadop;
                estado = "Desactivado";
            }
            if (accion == "Insertar")
            {
                estado = "Activo";
                descripcion = "\r\nTraslados de Productos:";
                descripcion += "\r\n-----------------------------------------------------------------------\r\n";
                descripcion += "Bodega Origen: " + trasladop.BodegaOrigen.nombre + "\r\nBodega Destino: " + trasladop.BodegaDestino.nombre + "\r\nUsuario: " + trasladop.Usuario.usuario + "\r\nObervaciones: " + trasladop.observaciones + "\r\nFechaTraslado: " + trasladop.fechaTraslado + "\r\nTipo de Traslado: " + trasladop.TipoTraslado.descripcion + "\r\nEstado del Traslado: " + trasladop.EstadoTraslado.descripcion+ "\r\nEstado: " + estado;

            }
            if (accion == "Modificar")
            {
                nuevoTraslado = ObtenerTrasladoPorID(trasladop.idTraslado);
                estado = "Activo";
                descripcion = "\r\nTraslados de Productos:";
                descripcion += "\r\n-----------------------------------------------------------------------\r\n";
                descripcion += "Antes del Cambio" + "\r\nBodega Origen: " + viejoTraslado.BodegaOrigen.nombre + "\r\nBodega Destino: " + viejoTraslado.BodegaDestino.nombre + "\r\nUsuario: " + viejoTraslado.Usuario.usuario + "\r\nObervaciones: " + viejoTraslado.observaciones + "\r\nFechaTraslado: " + viejoTraslado.fechaTraslado + "\r\nTipo de Traslado: " + viejoTraslado.TipoTraslado.descripcion + "\r\nEstado del Traslado: " + viejoTraslado.EstadoTraslado.descripcion + "\r\nEstado: " + estado;
                descripcion += "\r\n-----------------------------------------------------------------------\r\n";
                descripcion += "Despues del Cambio" + "\r\nBodega Origen: " + nuevoTraslado.BodegaOrigen.nombre + "\r\nBodega Destino: " + nuevoTraslado.BodegaDestino.nombre + "\r\nUsuario: " + nuevoTraslado.Usuario.usuario + "\r\nObervaciones: " + nuevoTraslado.observaciones + "\r\nFechaTraslado: " + nuevoTraslado.fechaTraslado + "\r\nTipo de Traslado: " + nuevoTraslado.TipoTraslado.descripcion + "\r\nEstado del Traslado: " + nuevoTraslado.EstadoTraslado.descripcion + "\r\nEstado: " + estado;
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

        /// <summary>
        /// Metodo que optiene un traslado por medio del ID
        /// </summary>
        /// <param name="idTrasladop"></param>
        /// <returns></returns>
        private static TrasladoProducto ObtenerTrasladoPorID(int idTrasladop)
        {
            TrasladoProducto traslado = new TrasladoProducto();
            SqlCommand comando = new SqlCommand("sp_SELECT_TrasladoProducto_byID_DTO");
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@idtraslado", idTrasladop);

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                DataSet ds = db.ExecuteReader(comando, "consulta");


                foreach (DataRow dr in ds.Tables[0].Rows)
                {

                    RegistroBodega bodegaOrigen = new RegistroBodega();
                    RegistroBodega bodegaDestino = new RegistroBodega();
                    UsuarioTable unUsuario = new UsuarioTable();
                    TipoTraslado tipoTraslado = new TipoTraslado();
                    EstadoTraslado estadoTraslado = new EstadoTraslado();

                    traslado.idTraslado = Convert.ToInt32(dr["idtraslado"].ToString());
                    bodegaOrigen.idRegistroBodega = Convert.ToInt32(dr["IDRegistroBodegaOrigen"].ToString());
                    bodegaOrigen.nombre = dr["BodegaOrigen"].ToString();
                    traslado.BodegaOrigen = bodegaOrigen;
                    bodegaDestino.idRegistroBodega = Convert.ToInt32(dr["IDRegistroBodegaDestino"].ToString());
                    bodegaDestino.nombre = dr["BodegaDestino"].ToString();
                    traslado.BodegaDestino = bodegaDestino;
                    unUsuario.codigoUsuario = Convert.ToInt32(dr["IDUsuario"].ToString());
                    unUsuario.usuario = dr["Usuario"].ToString();
                    traslado.Usuario = unUsuario;
                    traslado.observaciones = dr["Observaciones"].ToString();
                    traslado.fechaTraslado = dr["fechatraslado"].ToString();
                    tipoTraslado.idTipoTraslado = Convert.ToInt32(dr["IDTipoTraslado"].ToString());
                    tipoTraslado.descripcion = dr["TipoTraslado"].ToString();
                    traslado.TipoTraslado = tipoTraslado;
                    estadoTraslado.idEstadoTraslado = Convert.ToInt32(dr["IDEstadoTraslado"].ToString());
                    estadoTraslado.descripcion = dr["EstadoTraslado"].ToString();
                    traslado.EstadoTraslado = estadoTraslado;
                }
            }

            return traslado;
        }

        internal static string ObtenerSiguienteNumeroTraslado()
        {
            int ultimiIdInsertado = 0;
            SqlCommand comando = new SqlCommand("sp_SELECT_NextTraslado_ID");
            comando.CommandType = CommandType.StoredProcedure;


            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                DataSet ds = db.ExecuteReader(comando, "consulta");


                foreach (DataRow dr in ds.Tables[0].Rows)
                {

                    ultimiIdInsertado = Convert.ToInt32(dr["IDTrasladoProducto"].ToString());
                    ultimiIdInsertado += 1;

                }
            }

            return ultimiIdInsertado.ToString();
        }
    }
 }


