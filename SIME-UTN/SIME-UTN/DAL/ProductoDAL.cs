﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIME_UTN.DTOs;
using System.Data.SqlClient;
using System.Data;
using SIME_UTN.Entities;

namespace SIME_UTN.DAL
{
    class ProductoDAL
    {
        static Producto viejoProducto = null;
        /// <summary>
        /// Metodo que optiene una lista de productos
        /// </summary>
        /// <param name="filtroNombreProductop"></param>
        /// <returns></returns>
        internal static List<ProductoCategoriaUnidadMedidaDTO> ObtenertPorNombreDTO(string filtroNombreProductop)
        {
            List<ProductoCategoriaUnidadMedidaDTO> listaProductos = new List<ProductoCategoriaUnidadMedidaDTO>();
            SqlCommand comando = new SqlCommand("sp_SELECT_Producto_By_Filter");
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@filter", filtroNombreProductop);
            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                DataSet ds = db.ExecuteReader(comando, "consulta");


                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    ProductoCategoriaUnidadMedidaDTO unProducto = new ProductoCategoriaUnidadMedidaDTO();
                    unProducto.idProducto = Convert.ToInt32(dr["idproducto"].ToString());
                    unProducto.CodigoAvatar = dr["codigoavatar"].ToString();
                    unProducto.NombreProducto = dr["nombre"].ToString();
                    unProducto.Descripcion = dr["descripcion"].ToString();
                    unProducto.Categoria = dr["categoria"].ToString();
                    unProducto.UnidadMedida = dr["unidadmedida"].ToString();
                    unProducto.presentacion = dr["presentacion"].ToString();
                    listaProductos.Add(unProducto);
                }
            }

            return listaProductos;
        }

        internal static Producto ObtenerProductoPorCodigoAvatar(string codigoAvatarp)
        {
            Producto unProducto = new Producto();
            SqlCommand comando = new SqlCommand("sp_SELECT_Producto_ByCodigoAvatar");
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@codigoavatar", codigoAvatarp);

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                DataSet ds = db.ExecuteReader(comando, "consulta");


                foreach (DataRow dr in ds.Tables[0].Rows)
                {

                    Categoria unaCategoria = new Categoria();
                    UnidadMedida unaUnidadMedida = new UnidadMedida();
                    Ubicacion unaUbicacion = new Ubicacion();
                    unProducto.idProducto = Convert.ToInt32(dr["idproducto"].ToString());
                    unProducto.codigoAvatar = dr["codigoavatar"].ToString();
                    unProducto.nombreProducto = dr["nombre"].ToString();
                    unProducto.descripcion = dr["descripcion"].ToString();
                    unProducto.contendio = Double.Parse(dr["contenido"].ToString());
                    unProducto.estado = dr["estado"].ToString().Equals("True") ? 1 : 0;
                    unProducto.Categoria = CategoriaDAL.ObtenerCategoriaID(Convert.ToInt32(ds.Tables[0].Rows[0]["idcategoria"].ToString()));
                    unProducto.UnidadMedida = UnidadMedidaDAL.ObtenerUnidadMediadById(Convert.ToInt32(ds.Tables[0].Rows[0]["idunidadmedida"].ToString()));

                }
            }

            return unProducto;
        }

        internal static Producto ObtenerProductoPorID(int codigoProducto)
        {
            Producto unProducto = new Producto();
            SqlCommand comando = new SqlCommand("sp_SELECT_Producto_ByID");
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@idproducto", codigoProducto);

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                DataSet ds = db.ExecuteReader(comando, "consulta");


                foreach (DataRow dr in ds.Tables[0].Rows)
                {

                    Categoria unaCategoria = new Categoria();
                    UnidadMedida unaUnidadMedida = new UnidadMedida();
                    Ubicacion unaUbicacion = new Ubicacion();
                    unProducto.idProducto = Convert.ToInt32(dr["idproducto"].ToString());
                    unProducto.codigoAvatar = dr["codigoavatar"].ToString();
                    unProducto.nombreProducto = dr["nombre"].ToString();
                    unProducto.descripcion = dr["descripcion"].ToString();
                    unProducto.contendio = Double.Parse(dr["contenido"].ToString());
                    unProducto.estado = dr["estado"].ToString().Equals("True") ? 1 : 0;
                    unProducto.Categoria = CategoriaDAL.ObtenerCategoriaID(Convert.ToInt32(ds.Tables[0].Rows[0]["idcategoria"].ToString()));
                    unProducto.UnidadMedida = UnidadMedidaDAL.ObtenerUnidadMediadById(Convert.ToInt32(ds.Tables[0].Rows[0]["idunidadmedida"].ToString()));

                }
            }

            return unProducto;
        }
        /// <summary>
        /// Metodo que desabilita un producto por el ID
        /// </summary>
        /// <param name="productoIDp"></param>
        /// <param name="productop"></param>
        /// <param name="usuarioLoguadop"></param>
        internal static void EliminarUsuario(int productoIDp, string productop, string usuarioLoguadop)
        {
            string accion = "";
            accion = "Eliminar";
            SqlCommand comando = new SqlCommand("sp_DISABLE_Producto_ByID");
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idproducto", productoIDp);



            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                db.ExecuteNonQuery(comando);
            }
            GuardarLog(null, usuarioLoguadop, accion, productop);
        }

        /// <summary>
        /// Metodo que obtiene un producto por el ID
        /// </summary>
        /// <param name="idProducto"></param>
        /// /// <returns></returns>
        internal static bool ObtenerProductoByID(int idProducto)
        {
            bool existe = false;
            string sql = @"sp_SELECT_Producto_ByID";

            List<Item> lista = new List<Item>();

            SqlCommand command = new SqlCommand(sql);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@idproducto", idProducto);

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
        /// Metodo que actualiza un producto
        /// </summary>
        /// <param name="unProductop"></param>
        /// <param name="usuarioLogueadop"></param>
        internal static void ActualizarProducto(Producto unProductop, string usuarioLogueadop)
        {
            viejoProducto = new Producto();
            string accion = "";
            accion = "Modificar";
            SqlCommand comando = new SqlCommand("sp_UPDATE_Producto");
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idproducto", unProductop.idProducto);
            comando.Parameters.AddWithValue("@codigoavatar", unProductop.codigoAvatar);
            comando.Parameters.AddWithValue("@nombre", unProductop.nombreProducto);
            comando.Parameters.AddWithValue("@descripcion", unProductop.descripcion);
            comando.Parameters.AddWithValue("@idcategoria", unProductop.Categoria.idCategoria);
            comando.Parameters.AddWithValue("@idunidadmedida", unProductop.UnidadMedida.idUnidadMedida);
            comando.Parameters.AddWithValue("@contenido", unProductop.contendio);
            comando.Parameters.AddWithValue("@stockminimo", unProductop.cantMinima);
            comando.Parameters.AddWithValue("@stockmaximo", unProductop.cantMaxima);
            comando.Parameters.AddWithValue("@estado", unProductop.estado);
            viejoProducto = ObtenerProductoPorCodigoAvatar(unProductop.codigoAvatar);

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                db.ExecuteNonQuery(comando);
            }
            GuardarLog(unProductop, usuarioLogueadop, accion, null);
        }

        /// <summary>
        /// Metodo que guarda un nuevo producto
        /// </summary>
        /// <param name="unProductop"></param>
        /// <param name="usuarioLogueadop"></param>
        internal static int GuardarProducto(Producto unProductop, string usuarioLogueadop)
        {
            viejoProducto = new Producto();
            string accion = "";
            accion = "Insertar";
            int idProducto = 0;
            SqlCommand comando = new SqlCommand("sp_INSERT_Producto");
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@codigoavatar", unProductop.codigoAvatar);
            comando.Parameters.AddWithValue("@nombre", unProductop.nombreProducto);
            comando.Parameters.AddWithValue("@descripcion", unProductop.descripcion);
            comando.Parameters.AddWithValue("@idcategoria", unProductop.Categoria.idCategoria);
            comando.Parameters.AddWithValue("@idunidadmedida", unProductop.UnidadMedida.idUnidadMedida);
            comando.Parameters.AddWithValue("@contenido", unProductop.contendio);
            comando.Parameters.AddWithValue("@stockminimo", unProductop.cantMinima);
            comando.Parameters.AddWithValue("@stockmaximo", unProductop.cantMaxima);
            comando.Parameters.AddWithValue("@estado", unProductop.estado);
            viejoProducto = ObtenerProductoPorCodigoAvatar(unProductop.codigoAvatar);


            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                DataSet ds = db.ExecuteReader(comando, "consulta");

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    idProducto = Convert.ToInt32(dr["IDProducto"].ToString());
                }
            }
            GuardarLog(unProductop, usuarioLogueadop, accion, null);
            return idProducto;


        }

        /// <summary>
        /// Metodo que verifica si el producto esta asociado a una bodega
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        internal static bool VerificarBodegaByID(int idregistrobodega, int idProducto)
        {
            bool existe = false;

            existe = false;
            string sql = @"sp_SELECT_Bodega_ByID";
            SqlCommand command = new SqlCommand(sql);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@idbodega", idregistrobodega);
            command.Parameters.AddWithValue("@idproducto", idProducto);

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

        internal static void InsertarProductoEnBodega(int idBodega, Producto unProductop)
        {
            string accion = "";
            accion = "Insertar";


<<<<<<< HEAD
            SqlCommand comando = new SqlCommand("sp_INSERT_Bodega");
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idregistrobodega", idBodega);
            comando.Parameters.AddWithValue("@idproducto", unProductop.idProducto);
            comando.Parameters.AddWithValue("@codigoavatar", unProductop.codigoAvatar);
            comando.Parameters.AddWithValue("@nombre", unProductop.nombreProducto);
            comando.Parameters.AddWithValue("@idunidadmedida", unProductop.UnidadMedida.idUnidadMedida);
            comando.Parameters.AddWithValue("@contenido", 0);
            comando.Parameters.AddWithValue("@estado", 1);

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                db.ExecuteNonQuery(comando);


            }
        }
=======
                SqlCommand comando = new SqlCommand("sp_INSERT_Bodega");
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idregistrobodega", idBodega);
                comando.Parameters.AddWithValue("@idproducto", unProductop.idProducto);
                comando.Parameters.AddWithValue("@codigoavatar", unProductop.codigoAvatar);
                comando.Parameters.AddWithValue("@nombre", unProductop.nombreProducto);
                comando.Parameters.AddWithValue("@idunidadmedida", unProductop.UnidadMedida.idUnidadMedida);
                comando.Parameters.AddWithValue("@Unidades", 0);
                comando.Parameters.AddWithValue("@contenido", 0);
                comando.Parameters.AddWithValue("@estado", 1);
>>>>>>> origin/development





        /// <summary>
        /// Metodo que obtiene una lista de todos los productos
        /// </summary>
        /// <returns></returns>
        internal static List<Producto> ObtenerProductos()
        {
            List<Producto> listaProductos = new List<Producto>();
            SqlCommand comando = new SqlCommand("sp_SELECT_Producto_All");
            comando.CommandType = CommandType.StoredProcedure;
            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                DataSet ds = db.ExecuteReader(comando, "consulta");


                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Producto unProducto = new Producto();
                    Categoria unaCategoria = new Categoria();
                    UnidadMedida unaUnidadMedida = new UnidadMedida();
                    unProducto.idProducto = Convert.ToInt32(dr["idproducto"].ToString());
                    unProducto.codigoAvatar = dr["codigoavatar"].ToString();
                    unProducto.nombreProducto = dr["nombre"].ToString();
                    unProducto.descripcion = dr["descripcion"].ToString();
                    unaCategoria.idCategoria = int.Parse(dr["idcategoria"].ToString());
                    unaUnidadMedida.idUnidadMedida = int.Parse(dr["idunidadmedida"].ToString());
                    unProducto.estado = dr["estado"].ToString().Equals("True") ? 1 : 0;
                    unProducto.Categoria = unaCategoria;
                    unProducto.UnidadMedida = unaUnidadMedida;
                    listaProductos.Add(unProducto);
                }
            }

            return listaProductos;
        }


        /// <summary>
        /// Metodo que genera un log para toda transaccion
        /// </summary>
        /// <param name="unProductop"></param>
        /// <param name="usuarioLogueadop"></param>
        /// <param name="accion"></param>
        /// <param name="productoEliminadop"></param>
        public static void GuardarLog(Producto unProductop, string usuarioLogueado, string accion, string productoEliminadop)
        {
            Producto nuevoProducto = new Producto();
            string descripcion = "";
            string estado = "";

            if (accion == "Eliminar")
            {
                descripcion = "Producto eliminada: " + productoEliminadop;
                estado = "Desactivado";
            }
            if (accion == "Insertar")
            {
                estado = "Activo";
                descripcion = "\r\nProducto";
                descripcion += "\r\n-----------------------------------------------------------------------\r\n";
                descripcion += "CodigoAvatar: " + unProductop.codigoAvatar + "\r\nProducto: " + unProductop.nombreProducto + "\r\nDescripcion: " + unProductop.descripcion + "\r\nCategoria: " + unProductop.Categoria.descripcion + "\r\nUnidad de Medida: " + unProductop.UnidadMedida.descripcion + "\r\nCantidad Minima: " + unProductop.cantMinima + "\r\nCantidad Maxima: " + unProductop.cantMaxima + "\r\nEstado: " + estado;

            }
            if (accion == "Modificar")
            {
                nuevoProducto = ObtenerProductoPorCodigoAvatar(unProductop.codigoAvatar);

                estado = "Activo";
                descripcion = "\r\nProducto";
                descripcion += "\r\n-----------------------------------------------------------------------\r\n";
                descripcion += "Antes del Cambio" + "\r\nCodigoAvatar: " + viejoProducto.codigoAvatar + "\r\nProducto: " + viejoProducto.nombreProducto + "\r\nDescripcion: " + viejoProducto.descripcion + "\r\nCategoria: " + viejoProducto.Categoria.descripcion + "\r\nUnidad de Medida: " + viejoProducto.UnidadMedida.descripcion + "\r\nCantidad Minima: " + viejoProducto.cantMinima + "\r\nCantidad Maxima: " + viejoProducto.cantMaxima + "\r\nEstado: " + estado;
                descripcion += "\r\n-----------------------------------------------------------------------\r\n";
                descripcion += "Despues del Cambio" + "\r\nCodigoAvatar: " + nuevoProducto.codigoAvatar + "\r\nProducto: " + nuevoProducto.nombreProducto + "\r\nDescripcion: " + nuevoProducto.descripcion + "\r\nCategoria: " + nuevoProducto.Categoria.descripcion + "\r\nUnidad de Medida: " + nuevoProducto.UnidadMedida.descripcion + "\r\nCantidad Minima: " + nuevoProducto.cantMinima + "\r\nCantidad Maxima: " + nuevoProducto.cantMaxima + "\r\nEstado: " + estado;
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
