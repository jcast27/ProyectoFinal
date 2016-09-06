using SIME_UTN.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace SIME_UTN.DAL
{
    class DespachoDAL
    {
        public static void guardarDespachoDetalle(int idDespacho, PBodega Bodegap)
        {
            SqlCommand comando = new SqlCommand("sp_INSERT_DespachoDetalle");
            comando.CommandType = CommandType.StoredProcedure;

            //(@idDespacho int, @idBodega int, @idProducto int, @CantidadDespachada float, @Estado bit)

            comando.Parameters.AddWithValue("@idDespacho", idDespacho);
            comando.Parameters.AddWithValue("@idBodega", Bodegap.idBodega);
            comando.Parameters.AddWithValue("@idProducto", Bodegap.Producto.idProducto);
            comando.Parameters.AddWithValue("@CantidadDespachada", Bodegap.unidades);
            comando.Parameters.AddWithValue("@Estado", 1);

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                db.ExecuteNonQuery(comando);
            }
        }

        public static int GuardarDespacho(int idBodega, UsuarioTable user, string descripcion, Funcionario funcionario, Ubicacion ubicacion)
        {
            //(@idBodega int, @IDUsuario int, @IDFuncionario int, @Descripcion nvarchar(300),@FechaDespacho varchar(30))

            SqlCommand comando = new SqlCommand("sp_INSERT_Despacho");
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@idBodega", idBodega);
            comando.Parameters.AddWithValue("@IDUsuario", user.codigoUsuario);
            comando.Parameters.AddWithValue("@IDFuncionario", funcionario.idFuncionario);
            comando.Parameters.AddWithValue("@IDUbicacion", ubicacion.idUbicacion);
            comando.Parameters.AddWithValue("@Descripcion", descripcion);
            comando.Parameters.AddWithValue("@FechaDespacho", DateTime.Now);

            int id = 0;

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                DataSet ds = db.ExecuteReader(comando, "consulta");
                id = Convert.ToInt32(ds.Tables[0].Rows[0]["ID"].ToString());
            }

            GuardarLog(idBodega, funcionario, user.usuario, "Insertar");

            return id;
        }

        public static void GuardarLog(int idBodega, Funcionario funcionario, string usuarioLogueado, string accion)
        {
            string descripcion = "";

            descripcion = "Bodega #: " + idBodega + "\r\nProducto despachado a funcionario: " + funcionario.nombre;

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
