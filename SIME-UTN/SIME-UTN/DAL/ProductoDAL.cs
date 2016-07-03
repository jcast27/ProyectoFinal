using System;
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
                        unProducto.codigoAvatar = dr["codigoavatar"].ToString();
                        unProducto.nombreProducto = dr["nombre"].ToString();
                        unProducto.descripcion = dr["descripcion"].ToString();
                        unProducto.categoria = dr["idcategoria"].ToString();
                        unProducto.ubicacion = dr["idubicacion"].ToString();
                        unProducto.unidadMedida = dr["idunidadmedida"].ToString();
                        unProducto.estado = dr["estado"].ToString().Equals("True") ? 1 : 0;
                        listaProductos.Add(unProducto);
                    }
            }

            return listaProductos;
        }

        internal static void EliminarUsuario(int productoIDp)
        {
            SqlCommand comando = new SqlCommand("sp_DISABLE_Producto_ByID");
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@idproducto", productoIDp);


            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                db.ExecuteNonQuery(comando);
            }
        }

        internal static bool ObtenerProductoByID(int idProducto)
        {
            bool existe = false;
            string sql = @"sp_SELECT_Producto_ByID";

            List<Item> lista = new List<Item>();

            SqlCommand command = new SqlCommand(sql);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@idproducto",idProducto);

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

        internal static void ActualizarProducto(Producto unProductop)
        {
            SqlCommand comando = new SqlCommand("sp_UPDATE_Producto");
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idproducto", unProductop.idProducto);
            comando.Parameters.AddWithValue("@codigoavatar", unProductop.codigoAvatar);
            comando.Parameters.AddWithValue("@nombre", unProductop.nombreProducto);
            comando.Parameters.AddWithValue("@descripcion", unProductop.descripcion);
            comando.Parameters.AddWithValue("@idcategoria", unProductop.Categoria.idCategoria);
            comando.Parameters.AddWithValue("@idubicacion", unProductop.Ubicacion.idUbicacion);
            comando.Parameters.AddWithValue("@idunidadmedida", unProductop.UnidadMedida.idUnidadMedida);
            comando.Parameters.AddWithValue("@estado", unProductop.estado);

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                db.ExecuteNonQuery(comando);
            }
        }

        internal static void GuardarProducto(Producto unProductop)
        {
            SqlCommand comando = new SqlCommand("sp_INSERT_Producto");
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@codigoavatar", unProductop.codigoAvatar);
            comando.Parameters.AddWithValue("@nombre", unProductop.nombreProducto);
            comando.Parameters.AddWithValue("@descripcion", unProductop.descripcion);
            comando.Parameters.AddWithValue("@idcategoria", unProductop.Categoria.idCategoria);
            comando.Parameters.AddWithValue("@idubicacion", unProductop.Ubicacion.idUbicacion);
            comando.Parameters.AddWithValue("@idunidadmedida", unProductop.UnidadMedida.idUnidadMedida);
            comando.Parameters.AddWithValue("@estado", unProductop.estado);

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                db.ExecuteNonQuery(comando);
            }
        }

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
                    Ubicacion unaUbicacion = new Ubicacion();
                    unProducto.idProducto = Convert.ToInt32(dr["idproducto"].ToString());
                    unProducto.codigoAvatar = dr["codigoavatar"].ToString();
                    unProducto.nombreProducto = dr["nombre"].ToString();
                    unProducto.descripcion = dr["descripcion"].ToString();
                    unaCategoria.idCategoria = int.Parse(dr["idcategoria"].ToString());
                    unaUbicacion.idUbicacion = int.Parse(dr["idubicacion"].ToString());
                    unaUnidadMedida.idUnidadMedida = int.Parse(dr["idunidadmedida"].ToString());
                    unProducto.estado = dr["estado"].ToString().Equals("True") ? 1 : 0;
                    unProducto.Categoria = unaCategoria;
                    unProducto.Ubicacion = unaUbicacion;
                    unProducto.UnidadMedida = unaUnidadMedida;
                    listaProductos.Add(unProducto);
                }
            }

            return listaProductos;
        }
    }
}
