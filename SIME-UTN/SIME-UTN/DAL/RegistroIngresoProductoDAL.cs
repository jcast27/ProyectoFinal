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

        internal static void GuardarIngresoProducto(RegistroIngresoProductoDTO unIngresoProdDTO, string usuarioLogueadop)
        {
            string accion = "";
            accion = "Insertar";
            SqlCommand comando = new SqlCommand("sp_INSERT_RegistroIngresoProducto");
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@idingresoproducto", unIngresoProdDTO.idIngreso);
            comando.Parameters.AddWithValue("@idproducto", unIngresoProdDTO.idProducto);
            comando.Parameters.AddWithValue("@idunidadmedida",unIngresoProdDTO.Idunidad);
            comando.Parameters.AddWithValue("@cantidadxempaque", unIngresoProdDTO.cantidadPorEmpaque);
            comando.Parameters.AddWithValue("@cantidad", unIngresoProdDTO.cantidad);
            comando.Parameters.AddWithValue("@costoxempaque", unIngresoProdDTO.costoPorEmpaque);
            comando.Parameters.AddWithValue("@estado", unIngresoProdDTO.estado);

            GuardarLog(unIngresoProdDTO, usuarioLogueadop, accion, null);

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                db.ExecuteNonQuery(comando);
            }

        }

        internal static void ActualizarIngresoProducto(RegistroIngresoProductoDTO unIngresoProdDTO, string usuarioLogueadop)
        {
            string accion = "";
            accion = "Modificar";

            SqlCommand comando = new SqlCommand("sp_UPDATE_RegistroIngresoProducto");
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@idingresoproducto", unIngresoProdDTO.idIngreso);
            comando.Parameters.AddWithValue("@idproducto", unIngresoProdDTO.idProducto);
            comando.Parameters.AddWithValue("@idunidadmedida", unIngresoProdDTO.Idunidad);
            comando.Parameters.AddWithValue("@cantidadxempaque", unIngresoProdDTO.cantidadPorEmpaque);
            comando.Parameters.AddWithValue("@cantidad", unIngresoProdDTO.cantidad);
            comando.Parameters.AddWithValue("@costoxempaque", unIngresoProdDTO.costoPorEmpaque);
            comando.Parameters.AddWithValue("@estado", unIngresoProdDTO.estado);

            GuardarLog(unIngresoProdDTO, usuarioLogueadop, accion, null);

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                db.ExecuteNonQuery(comando);
            }
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

        internal static void EliminarIngresoDeProducto(Producto unProductop, int idIngRegProd, string usuarioLogueadop)
        {
            string accion = "";
            accion = "Eliminar";
            SqlCommand comando = new SqlCommand("sp_DISABLE_RegistroIngresoProducto_ByID");
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@idingresoproducto", idIngRegProd);
            comando.Parameters.AddWithValue("@idproducto", unProductop.idProducto);
            GuardarLog(null, usuarioLogueadop, accion, unProductop.nombreProducto);

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                db.ExecuteNonQuery(comando);
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
                    unRegIngreso.cantidadPorEmpaque = Convert.ToInt16( dr["CantidadEmpaque"].ToString());
                    unRegIngreso.unidadMedida = dr["UnidadMedida"].ToString();
                    unRegIngreso.cantidad = Double.Parse(dr["Cantidad"].ToString());
                    unRegIngreso.costoPorEmpaque = Double.Parse(dr["CostoEmpaque"].ToString());
                    listaProductosDTO.Add(unRegIngreso);
                }
            }

            return listaProductosDTO;
        }

        public static void GuardarLog(RegistroIngresoProductoDTO unIngresoProdDTO, string usuarioLogueadop, string accion, string ingresoProdEliminado)
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

        }

        /*  public static void GuardarLog(RegistroIngresoProductoDTO unIngresoProdDTO, string usuarioLogueadop, string accion, string ingresoProdEliminado)
          {
              RegistroIngresoProductoDTO viejoRegIngDTO = new RegistroIngresoProductoDTO();
              string descripcion = "";
              string estado = "";

              if (accion == "Eliminar")
              {
                  descripcion = "Producto eliminado del Registro: " + ingresoProdEliminado;
                  estado = "Desactivado";
              }
              if (accion == "Insertar")
              {
                  estado = "Activo";
                  descripcion = "Código Producto: " + unIngresoProdDTO.idProducto + "\r\nCódigoAvatar: "
                  + unIngresoProdDTO.codigoAvatar + "\r\nProducto: " + unIngresoProdDTO.nombreProducto +
                  "\r\nCantidad por Empaque: " + unIngresoProdDTO.cantidadPorEmpaque + "\r\nCantidad Unidad de Medida: "
                  + unIngresoProdDTO.cantidad + "\r\nUnidad Medida: " + unIngresoProdDTO.unidadMedida +
                  "\r\nCosto por Empaque: " + unIngresoProdDTO.costoPorEmpaque + "\r\nEstado: " + estado;

              }
              if (accion == "Modificar")
              {
                  //viejoRegIngDTO = ObtenerIngresoProductoByID(unIngresoProdDTO.idIngreso, unIngresoProdDTO.idProducto)
                  estado = "Activo";
                  descripcion = "Antes del Cambio" + "\r\nCódigo Producto: " + unIngresoProdDTO.idProducto + "\r\nCódigoAvatar: "
                  + unIngresoProdDTO.codigoAvatar + "\r\nProducto: " + unIngresoProdDTO.nombreProducto +
                  "\r\nCantidad por Empaque: " + unIngresoProdDTO.cantidadPorEmpaque + "\r\nCantidad Unidad de Medida: "
                  + unIngresoProdDTO.cantidad + "\r\nUnidad Medida: " + unIngresoProdDTO.unidadMedida +
                  "\r\nCosto por Empaque: " + unIngresoProdDTO.costoPorEmpaque + "\r\nEstado: " + estado;
                  descripcion += "\r\n-----------------------------------------------------------------------\r\n";
                  descripcion += "Después del Cambio" + "\r\nCódigo Producto: " + unIngresoProdDTO.idProducto + "\r\nCódigoAvatar: "
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
              } */
    }
}
