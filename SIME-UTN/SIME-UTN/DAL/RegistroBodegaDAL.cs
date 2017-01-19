using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIME_UTN.Entities;
using System.Data.SqlClient;
using System.Data;
using SIME_UTN.DTOs;

namespace SIME_UTN.DAL
{
    class RegistroBodegaDAL
    {
        static RegistroBodega viejaBodega = null;
        /// <summary>
        /// Metodo que elimina una Bodega
        /// </summary>
        /// <param name="idBodegap"></param>
        /// <param name="bodegap"></param>
        /// <param name="usuarioLogueadop"></param>
        internal static void DisableBodega(int idBodegap, string bodegap, string usuarioLogueadop)
        {
            string accion = "";
            accion = "Eliminar";
            SqlCommand comando = new SqlCommand("sp_DISABLE_RegistroBodega_ByID");
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@idregistrobodega", idBodegap);
           

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                db.ExecuteNonQuery(comando);
            }
            GuardarLog(null, usuarioLogueadop, accion, bodegap);
            int estado = 0;
           
        }


        /// <summary>
        /// Metodo que verifica si existe una bodega por medio del ID
        /// </summary>
        /// <param name="idRegistroBodega"></param>
        /// <returns></returns>
        internal static bool ObtenerBodegaByID(int idRegistroBodega)
        {
            bool existe = false;
            string sql = @"sp_SELECT_RegistroBodega_ByID";

            SqlCommand command = new SqlCommand(sql);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@idregistrobodega",idRegistroBodega);

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
        /// Metodo que obtiene una bodega por medio del ID
        /// </summary>
        /// <param name="idRegistroBodega"></param>
        /// <returns></returns>
        internal static RegistroBodega ObtenerBodega(int idRegistroBodega)
        {
            RegistroBodega unaBodega = new RegistroBodega();
            bool existe = false;
            string sql = @"sp_SELECT_RegistroBodega_ByID";

            SqlCommand command = new SqlCommand(sql);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@idregistrobodega", idRegistroBodega);

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                DataSet ds = db.ExecuteReader(command, "consulta");


                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    unaBodega.idRegistroBodega = Convert.ToInt32(dr["idregistrobodega"].ToString());
                    unaBodega.nombre = dr["nombre"].ToString();
                    unaBodega.descripcion = dr["descripcion"].ToString();
                    unaBodega.TipoBodega = TipoBodegaDAL.ObtenerTipoBodega(Convert.ToInt32(dr["tipo"].ToString()));
                    unaBodega.estado = Convert.ToInt32(dr["estado"]);
                }

            }
            return unaBodega;
        }

        /// <summary>
        /// Metodo que obtiene una lista de Bodegas
        /// </summary>
        /// <returns></returns>
        internal static List<RegistroBodegaTipoBodegaDTO> ObtenertBodegas()
        {
            List<RegistroBodegaTipoBodegaDTO> listaBodegas = new List<RegistroBodegaTipoBodegaDTO>();
            SqlCommand comando = new SqlCommand("sp_SELECT_RegistroBodega");
            comando.CommandType = CommandType.StoredProcedure;

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                DataSet ds = db.ExecuteReader(comando, "consulta");


                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    RegistroBodegaTipoBodegaDTO unaBodega = new RegistroBodegaTipoBodegaDTO();
                    unaBodega.idregistrobodega = Convert.ToInt32(dr["idregistrobodega"].ToString());
                    unaBodega.nombre = dr["nombre"].ToString();
                    unaBodega.descripcion = dr["descripcion"].ToString();
                    unaBodega.tipobodega = dr["tipobodega"].ToString();
                    unaBodega.estado = Convert.ToInt32(dr["estado"]);
                    listaBodegas.Add(unaBodega);
                }
            }

            return listaBodegas;
        }

        /// <summary>
        /// Metodo que actualiza los campos de una bodega
        /// </summary>
        /// <param name="unaBodegap"></param>
        /// <param name="usuarioLogueadop"></param>
        internal static void ActualizarBodega(RegistroBodega unaBodegap, string usuarioLogueadop)
        {
            viejaBodega = new RegistroBodega();
            List<InventarioProducto> listInventario = new List<InventarioProducto>();
            string accion = "";
            accion = "Modificar";
            SqlCommand comando = new SqlCommand("sp_UPDATE_RegistroBodega");
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idregistrobodega", unaBodegap.idRegistroBodega);
            comando.Parameters.AddWithValue("@nombre", unaBodegap.nombre);
            comando.Parameters.AddWithValue("@descripcion", unaBodegap.descripcion);
            comando.Parameters.AddWithValue("@idubicacion", unaBodegap.Ubicacion.idUbicacion);
            comando.Parameters.AddWithValue("@tipo", unaBodegap.TipoBodega.idTipoBodega);
            comando.Parameters.AddWithValue("@estado", unaBodegap.estado);
            viejaBodega = ObtenerBodega(unaBodegap.idRegistroBodega);
           
            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                db.ExecuteNonQuery(comando);
            }
            GuardarLog(unaBodegap, usuarioLogueadop, accion, null);
        }


        /// <summary>
        /// Metodo que cambia el tipo de bodega y actualiza el campo contenido de los productos asociado a la bodega, segun el tipo de bodega
        /// </summary>
        /// <param name="idRegistroBodegap"></param>
        internal static void CambiarTipodeBodega(int idRegistroBodegap)
        {
            SqlCommand comando = new SqlCommand("sp_UPDATE_Bodega");
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idregistrobodega", idRegistroBodegap);
            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                db.ExecuteNonQuery(comando);
            }
        }



        /// <summary>
        /// Metodo que elimina los productos asociado a la bodega
        /// </summary>
        /// <param name="idRegistroBodegap"></param>
        internal static void EliminaripodeBodega(int idRegistroBodegap)
        {
            SqlCommand comando = new SqlCommand("sp_DeleteBodegaInventario_ByID");
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@IDBodega", idRegistroBodegap);
            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                db.ExecuteNonQuery(comando);
            }
        }



        /// <summary>
        /// Metodo que guarda una nueva Bodega
        /// </summary>
        /// <param name="unaBodegap"></param>
        /// <param name="usuarioLogueadop"></param>
        internal static int GuardarBodega(RegistroBodega unaBodegap, string usuarioLogueadop)
        {
            viejaBodega = new RegistroBodega();
            List<InventarioProducto> listInventario = new List<InventarioProducto>();
            string accion = "";
            accion = "Insertar";
            int idBodega = 0;
            SqlCommand comando = new SqlCommand("sp_INSERT_RegistroBodega");
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@nombre", unaBodegap.nombre);
            comando.Parameters.AddWithValue("@descripcion", unaBodegap.descripcion);
            comando.Parameters.AddWithValue("@idubicacion", unaBodegap.Ubicacion.idUbicacion);
            comando.Parameters.AddWithValue("@tipo", unaBodegap.TipoBodega.idTipoBodega);
            comando.Parameters.AddWithValue("@estado", unaBodegap.estado);
            viejaBodega = ObtenerBodega(unaBodegap.idRegistroBodega);

          

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                DataSet ds = db.ExecuteReader(comando, "consulta");

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    idBodega = Convert.ToInt32(dr["IDRegistroBodega"].ToString());
                }

            }
            GuardarLog(unaBodegap, usuarioLogueadop, accion, null);
            return idBodega;
        }
        internal static void InsertarProductoEnBodega(int idBodegap)
        {
            string accion = "";
            accion = "Insertar";
            double cantidad = 0;

            List<RegistroIngresoProductoDTO> listaProductos = new List<RegistroIngresoProductoDTO>();

            listaProductos = ObtenertProductoInvetario();

            foreach (RegistroIngresoProductoDTO producto in listaProductos)
            {
                if (producto.Idunidad!=10){
                    SqlCommand comando = new SqlCommand("sp_INSERT_Bodega");
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@idregistrobodega", idBodegap);
                    comando.Parameters.AddWithValue("@idproducto", producto.idProducto);
                    comando.Parameters.AddWithValue("@codigoavatar", producto.codigoAvatar);
                    comando.Parameters.AddWithValue("@nombre", producto.nombreProducto);
                    comando.Parameters.AddWithValue("@idunidadmedida", producto.Idunidad);
                    comando.Parameters.AddWithValue("@Unidades", 0);
                    comando.Parameters.AddWithValue("@contenido", 0);
                    comando.Parameters.AddWithValue("@estado", 1);

                    using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
                    {
                        db.ExecuteNonQuery(comando);


                    }
                }
            }

        }

        internal static List<RegistroIngresoProductoDTO> ObtenertProductoInvetario()
        {
            List<RegistroIngresoProductoDTO> listaProductos = new List<RegistroIngresoProductoDTO>();
            SqlCommand comando = new SqlCommand("sp_SELECT_InventarioProducto_All");
            comando.CommandType = CommandType.StoredProcedure;

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                DataSet ds = db.ExecuteReader(comando, "consulta");


                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    RegistroIngresoProductoDTO unProducto = new RegistroIngresoProductoDTO();
                    unProducto.idProducto = Convert.ToInt32(dr["idproducto"].ToString());
                    unProducto.codigoAvatar = dr["codigoavatar"].ToString();
                    unProducto.nombreProducto = dr["descripcion"].ToString();
                    unProducto.Idunidad = Convert.ToInt32(dr["idunidadmedida"].ToString());
                    listaProductos.Add(unProducto);
                }
            }

            return listaProductos;
        }


        /// <summary>
        /// Metodo guarda todo cambio en la tabla log
        /// </summary>
        /// <param name="unaBodegap"></param>
        /// <param name="usuarioLogueadop"></param>
        /// <param name="accion"></param>
        /// <param name="bodegaEliminadap"></param>
        private static void GuardarLog(RegistroBodega unaBodegap, string usuarioLogueadop, string accion, string bodegaEliminadap)
        {
            RegistroBodega nuevaBodega = new RegistroBodega();
            string descripcion = "";
            string estado = "";

            if (accion == "Eliminar")
            {
                descripcion = "Producto eliminado: " + bodegaEliminadap;
                estado = "Desactivado";
            }
            if (accion == "Insertar")
            {
                estado = "Activo";
                descripcion = "\r\nRegistro Bodega";
                descripcion += "\r\n-----------------------------------------------------------------------\r\n";
                descripcion += "Bodega: " + unaBodegap.nombre + "\r\nDescripcion: " + unaBodegap.descripcion + "\r\nTipo de Bodega: " + unaBodegap.TipoBodega.descripcion + "\r\nEstado: " + estado;

            }
            if (accion == "Modificar")
            {
                
                nuevaBodega = ObtenerBodega(unaBodegap.idRegistroBodega);
                estado = "Activo";
                descripcion = "\r\nRegistro Bodega";
                descripcion += "\r\n-----------------------------------------------------------------------\r\n";
                descripcion += "Antes del Cambio" + "\r\nBodega: " + viejaBodega.nombre + "\r\nDescripcion: " + viejaBodega.descripcion + "\r\nTipo de Bodega: " + viejaBodega.TipoBodega.descripcion + "\r\nEstado: " + estado;
                descripcion += "\r\n-----------------------------------------------------------------------\r\n";
                descripcion += "Despues del Cambio" + "\r\nBodega: " + nuevaBodega.nombre + "\r\nDescripcion: " + nuevaBodega.descripcion + "\r\nTipo de Bodega: " + nuevaBodega.TipoBodega.descripcion + "\r\nEstado: " + estado;
            }
            DateTime date = DateTime.Now;
            string fecha = date.ToString("dd/MM/yyyy");
            SqlCommand comando = new SqlCommand("sp_INSERT_log");
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@usuario", usuarioLogueadop);
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
