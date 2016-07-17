using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIME_UTN.Entities;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace SIME_UTN.DAL
{
    class TrasladoProductoDAL
    {

        /// <summary>
        /// Metodo que desabilita una mezcla
        /// </summary>
        /// <param name="idRegistroMezclap"></param>
        /// <param name="nombrep"></param>
        /// <param name="usuarioLogueadop"></param>
        internal static void EliminarTraslado(int idTrasladop, string usuarioLogueadop)
        {

            string accion = "";
            accion = "Eliminar";
            SqlCommand comando = new SqlCommand("sp_DESABLE_TrasladoProducto_ByID");
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@idtraslado", idTrasladop);
            GuardarLog(null, usuarioLogueadop, accion, idTrasladop.ToString());

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                db.ExecuteNonQuery(comando);
            }
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

            TrasladoProducto viejoTraslado = new TrasladoProducto();
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
                descripcion = "Bodega Origen: " + trasladop.BodegaOrigen.nombre + "\r\nBodega Destino: " + trasladop.BodegaDestino.nombre + "\r\nUsuario: " + trasladop.Usuario.usuario + "\r\nObervaciones: " + trasladop.observaciones + "\r\nFechaTraslado: " + trasladop.fechaTraslado + "\r\nTipo de Traslado: " + trasladop.TipoTraslado.descripcion + "\r\nEstado del Traslado: " + trasladop.EstadoTraslado.descripcion+ "\r\nEstado: " + estado;

            }
            if (accion == "Modificar")
            {
                viejoTraslado = ObtenerTrasladoPorID(trasladop.idTraslado);
                estado = "Activo";
                descripcion = "Antes del Cambio" + "\r\nBodega Origen: " + viejoTraslado.BodegaOrigen.nombre + "\r\nBodega Destino: " + viejoTraslado.BodegaDestino.nombre + "\r\nUsuario: " + viejoTraslado.Usuario.usuario + "\r\nObervaciones: " + viejoTraslado.observaciones + "\r\nFechaTraslado: " + viejoTraslado.fechaTraslado + "\r\nTipo de Traslado: " + viejoTraslado.TipoTraslado.descripcion + "\r\nEstado del Traslado: " + viejoTraslado.EstadoTraslado.descripcion + "\r\nEstado: " + estado;
                descripcion += "\r\n-----------------------------------------------------------------------\r\n";
                descripcion = "Despues del Cambio" + "\r\nBodega Origen: " + trasladop.BodegaOrigen.nombre + "\r\nBodega Destino: " + trasladop.BodegaDestino.nombre + "\r\nUsuario: " + trasladop.Usuario.usuario + "\r\nObervaciones: " + trasladop.observaciones + "\r\nFechaTraslado: " + trasladop.fechaTraslado + "\r\nTipo de Traslado: " + trasladop.TipoTraslado.descripcion + "\r\nEstado del Traslado: " + trasladop.EstadoTraslado.descripcion + "\r\nEstado: " + estado;
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
    }
 }


