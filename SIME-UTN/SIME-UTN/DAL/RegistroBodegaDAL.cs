using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIME_UTN.Entities;
using System.Data.SqlClient;
using System.Data;


namespace SIME_UTN.DAL
{
    class RegistroBodegaDAL
    {
        internal static void EliminarBodega(int idBodegap, string bodegap, string usuarioLogueadop)
        {
            string accion = "";
            accion = "Eliminar";
            SqlCommand comando = new SqlCommand("sp_DISABLE_RegistroBodega_ByID");
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@idregistrobodega", idBodegap);
            GuardarLog(null, usuarioLogueadop, accion, bodegap);

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                db.ExecuteNonQuery(comando);
            }
        }

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

        internal static void ActualizarBodega(RegistroBodega unaBodegap, string usuarioLogueadop)
        {
            string accion = "";
            accion = "Modificar";
            SqlCommand comando = new SqlCommand("sp_UPDATE_RegistroBodega");
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idregistrobodega", unaBodegap.idRegistroBodega);
            comando.Parameters.AddWithValue("@nombre", unaBodegap.nombre);
            comando.Parameters.AddWithValue("@descripcion", unaBodegap.descripcion);
            comando.Parameters.AddWithValue("@tipo", unaBodegap.TipoBodega.idTipoBodega);
            comando.Parameters.AddWithValue("@estado", unaBodegap.estado);
            GuardarLog(unaBodegap, usuarioLogueadop, accion, null);
            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                db.ExecuteNonQuery(comando);
            }
        }

    

        internal static void GuardarBodega(RegistroBodega unaBodegap, string usuarioLogueadop)
        {
            string accion = "";
            accion = "Insertar";
            SqlCommand comando = new SqlCommand("sp_INSERT_RegistroBodega");
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@nombre", unaBodegap.nombre);
            comando.Parameters.AddWithValue("@descripcion", unaBodegap.descripcion);
            comando.Parameters.AddWithValue("@tipo", unaBodegap.TipoBodega.idTipoBodega);
            comando.Parameters.AddWithValue("@estado", unaBodegap.estado);


            GuardarLog(unaBodegap, usuarioLogueadop, accion, null);

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                db.ExecuteNonQuery(comando);
            }
        }

        private static void GuardarLog(RegistroBodega unaBodegap, string usuarioLogueadop, string accion, string bodegaEliminadap)
        {
            string descripcion = "";
            string estado = "";
            if (unaBodegap == null)
            {
                descripcion = "Producto eliminado: " + bodegaEliminadap;
                estado = "Desactivado";
            }
            else
            {
                estado = "Activo";
                descripcion = "Bodega: " + unaBodegap.nombre + "\r\nDescripcion: " + unaBodegap.descripcion + "\r\nTipo de Bodega: " + unaBodegap.TipoBodega.descripcion + "\r\nEstado: " + estado;

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
