using SIME_UTN.DTOs;
using SIME_UTN.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace SIME_UTN.DAL
{
    class RegistroIngresoProductoDAL
    {
 
        internal static double GuardarIngresoProducto(RegistroIngresoProductoDTO unIngresoProdDTO, string usuarioLogueadop)
        {
           
            double cantidad = 0;
           
            Producto unProducto = new Producto();
            SqlCommand comando = new SqlCommand("sp_INSERT_RegistroIngresoProducto");
            comando.CommandType = CommandType.StoredProcedure;
            unProducto = ProductoDAL.ObtenerProductoPorCodigoAvatar(unIngresoProdDTO.codigoAvatar);
            cantidad = unIngresoProdDTO.cantidadPorEmpaque * unProducto.contendio;
            comando.Parameters.AddWithValue("@idBodega", unIngresoProdDTO.idBodega);
            comando.Parameters.AddWithValue("@idingresoproducto", unIngresoProdDTO.idIngreso);
            comando.Parameters.AddWithValue("@idproducto", unIngresoProdDTO.idProducto);
            comando.Parameters.AddWithValue("@idunidadmedida",unIngresoProdDTO.Idunidad);
            comando.Parameters.AddWithValue("@cantidadxempaque", unIngresoProdDTO.cantidadPorEmpaque);
            comando.Parameters.AddWithValue("@UCantidadIngresada", cantidad);
            comando.Parameters.AddWithValue("@cantidad", unProducto.contendio);
            comando.Parameters.AddWithValue("@costoxempaque", unIngresoProdDTO.costoPorEmpaque);
            comando.Parameters.AddWithValue("@FechaCaducidad", unIngresoProdDTO.fechaCaducidad);
            comando.Parameters.AddWithValue("@estado", unIngresoProdDTO.estado);

           // GuardarLog(unIngresoProdDTO, usuarioLogueadop, accion, null);

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                db.ExecuteNonQuery(comando);
            }
            //if(VerificarBodegaByID(unIngresoProdDTO.idBodega, unIngresoProdDTO.idProducto) == false){

            //    GuardarBodega(unIngresoProdDTO, usuarioLogueadop);
            //}
            return cantidad;
        }
        /// <summary>
        /// Metodo que actualiza el invetario producto, respecto a la cantidad registrada
        /// </summary>
        /// <param name="unIngresoProdDTO"></param>
        internal static void ActualizarInventarioCantidad(int idBodega,int idProductop, double contendiop, double uCantidadp,string estadop, int unidadesp)
        {
            SqlCommand comando1 = null;
            if (estadop == "Insertar")
            {
                comando1 = new SqlCommand("sp_UPDATE_InventarioProducto_CantidadActual");
                comando1.CommandType = CommandType.StoredProcedure;
                comando1.Parameters.AddWithValue("@IDRegistroBodega", idBodega);
                comando1.Parameters.AddWithValue("@idproducto", idProductop);
                comando1.Parameters.AddWithValue("@stockactual", contendiop);
                comando1.Parameters.AddWithValue("@unidades", unidadesp);
            }
            if (estadop == "Modificar")
            {
                comando1 = new SqlCommand("sp_UPDATE_InventarioProducto_UpdateCantidadActual");
                comando1.CommandType = CommandType.StoredProcedure;
                comando1.Parameters.AddWithValue("@IDRegistroBodega", idBodega);
                comando1.Parameters.AddWithValue("@idproducto", idProductop);
                comando1.Parameters.AddWithValue("@stockactual", contendiop);
                comando1.Parameters.AddWithValue("@Ucantidad", uCantidadp);
            }

          


            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                db.ExecuteNonQuery(comando1);
            }
        }

        internal static double ActualizarIngresoProducto(RegistroIngresoProductoDTO unIngresoProdDTO, string usuarioLogueadop)
        {

            double cantidad = 0;
            Producto unProducto = new Producto();
            SqlCommand comando = new SqlCommand("sp_UPDATE_RegistroIngresoProducto");
            comando.CommandType = CommandType.StoredProcedure;
            unProducto = ProductoDAL.ObtenerProductoPorCodigoAvatar(unIngresoProdDTO.codigoAvatar);
            cantidad = unIngresoProdDTO.cantidadPorEmpaque * unProducto.contendio;
            comando.Parameters.AddWithValue("@idingresoproducto", unIngresoProdDTO.idIngreso);
            comando.Parameters.AddWithValue("@idproducto", unIngresoProdDTO.idProducto);
            comando.Parameters.AddWithValue("@FechaCaducidad", unIngresoProdDTO.fechaCaducidad);
            comando.Parameters.AddWithValue("@UCantidadIngresada", cantidad);
            comando.Parameters.AddWithValue("@idunidadmedida", unIngresoProdDTO.Idunidad);
            comando.Parameters.AddWithValue("@cantidadxempaque", unIngresoProdDTO.cantidadPorEmpaque);
            comando.Parameters.AddWithValue("@cantidad", unProducto.contendio);
            comando.Parameters.AddWithValue("@costoxempaque", unIngresoProdDTO.costoPorEmpaque);
            comando.Parameters.AddWithValue("@estado", unIngresoProdDTO.estado);

           // GuardarLog(unIngresoProdDTO, usuarioLogueadop, accion, null);

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                db.ExecuteNonQuery(comando);
            }

            return cantidad;
           
        }

        internal static bool ObtenerIngresoProductoByID(int idIngresop, int idProductop)
        {
            bool existe = false;
            string sql = @"sp_SELECT_RegistroIngresoProducto_ByID";

            List<Item> lista = new List<Item>();

            SqlCommand command = new SqlCommand(sql);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@idingresoproducto", idIngresop);
            command.Parameters.AddWithValue("@idproducto", idProductop);

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

        internal static bool VerificarBodegaByID(int idBodega, int idProductop)
        {
            bool existe = false;
            string sql = @"sp_SELECT_Bodega_ByID";

            List<Item> lista = new List<Item>();

            SqlCommand command = new SqlCommand(sql);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@idbodega", idBodega);
            command.Parameters.AddWithValue("@idproducto", idProductop);

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

        internal static void EliminarIngresoDeProducto(int idRegistroBodegap,Producto unProductop, int idIngRegProd, string usuarioLogueadop)
        {
            string accion = "";
            accion = "Eliminar";
          


            SqlCommand comando = new SqlCommand("sp_DISABLE_RegistroIngresoProducto_ByID");
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@idingresoproducto", idIngRegProd);
            comando.Parameters.AddWithValue("@idproducto", unProductop.idProducto);
           // GuardarLog(null, usuarioLogueadop, accion, unProductop.nombreProducto);

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                db.ExecuteNonQuery(comando);
            }

        }

        internal static void DescargarInvetarioRegistroProductoEliminado(int idRegistroBodegap,List<RegistroIngresoProductoDTO> listregistriIngresoProductop)
        {


            foreach (RegistroIngresoProductoDTO registriIngresoProducto in listregistriIngresoProductop)
            {
                SqlCommand comando = new SqlCommand("sp_DescargarInventario");
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idregistrobodega", idRegistroBodegap);
                comando.Parameters.AddWithValue("@idproducto", registriIngresoProducto.idProducto);
                comando.Parameters.AddWithValue("@UCantidadIngresada", registriIngresoProducto.uCantidad);
                comando.Parameters.AddWithValue("@unidades", registriIngresoProducto.cantidadPorEmpaque);


                using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
                {
                    db.ExecuteNonQuery(comando);
                }
            }

        }


        internal static List<RegistroIngresoProductoDTO> ObtenerProductosPorIdRegistro(int idRegistroProductop)
        {
            List<RegistroIngresoProductoDTO> listaProductosDTO = new List<RegistroIngresoProductoDTO>();
            SqlCommand comando = new SqlCommand("sp_SELECT_RegistroIngresoProducto_ByID_DTO");
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@idingresoproducto", idRegistroProductop);

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                DataSet ds = db.ExecuteReader(comando, "consulta");


                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    RegistroIngresoProductoDTO unRegIngreso = new RegistroIngresoProductoDTO();
                    unRegIngreso.idProducto = int.Parse(dr["IDProducto"].ToString());
                    unRegIngreso.codigoAvatar = dr["CodigoAvatar"].ToString();
                    unRegIngreso.nombreProducto = dr["Nombre"].ToString();
                    unRegIngreso.uCantidad = Double.Parse(dr["UCantidadIngresada"].ToString());
                    unRegIngreso.cantidadPorEmpaque = Convert.ToInt16( dr["CantidadEmpaque"].ToString());
                    unRegIngreso.unidadMedida = dr["UnidadMedida"].ToString();
                    unRegIngreso.cantidad = Double.Parse(dr["Cantidad"].ToString());
                    unRegIngreso.costoPorEmpaque = Double.Parse(dr["CostoEmpaque"].ToString());
                    unRegIngreso.fechaCaducidad = dr["FechaCaducidad"].ToString();
                    listaProductosDTO.Add(unRegIngreso);
                }
            }

            return listaProductosDTO;
        }

     /*   public static void GuardarLog(RegistroIngresoProductoDTO unIngresoProdDTO, string usuarioLogueadop, string accion, string ingresoProdEliminado)
        {

            string descripcion = "";
            string estado = "";
            if (unIngresoProdDTO == null)
            {
                descripcion = "Producto eliminado del Registro: " + ingresoProdEliminado;
                estado = "Desactivado";
            }
            else
            {
                estado = "Activo";
                descripcion = "Código Producto: " + unIngresoProdDTO.idProducto + "\r\nCódigoAvatar: "
                  + unIngresoProdDTO.codigoAvatar + "\r\nProducto: " + unIngresoProdDTO.nombreProducto +
                  "\r\nCantidad por Empaque: " + unIngresoProdDTO.cantidadPorEmpaque + "\r\nCantidad Unidad de Medida: "
                  + unIngresoProdDTO.cantidad + "\r\nUnidad Medida: " + unIngresoProdDTO.unidadMedida +
                  "\r\nCosto por Empaque: " + unIngresoProdDTO.costoPorEmpaque + "\r\nEstado: " + estado;
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

        }*/

       
    }
}
