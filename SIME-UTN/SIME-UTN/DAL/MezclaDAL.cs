using SIME_UTN.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace SIME_UTN.DAL
{
    class MezclaDAL
    {
        public static void agregarMezcla(int idBodega, Producto mezcla, int contenido)
        {
            SqlCommand comando = new SqlCommand("sp_INSERT_MezclaBodega");
            comando.CommandType = CommandType.StoredProcedure;

            //(@idBodega int, @idMezcla int, @CodigoAvatar varchar(30), @Nombre varchar(30), @IDUnidadMedida int, @Unidades int, @contenido float)

            comando.Parameters.AddWithValue("@idBodega", idBodega);
            comando.Parameters.AddWithValue("@idMezcla", mezcla.idProducto);
            comando.Parameters.AddWithValue("@CodigoAvatar", mezcla.codigoAvatar);
            comando.Parameters.AddWithValue("@Nombre", mezcla.nombreProducto);
            comando.Parameters.AddWithValue("@IDUnidadMedida", 10);
            comando.Parameters.AddWithValue("@contenido", contenido);

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                db.ExecuteNonQuery(comando);
            }
        }

        public static void removerComponentes(int idBodega, int idProducto, int contenido, int unidades)
        {
            SqlCommand comando = new SqlCommand("sp_REDUCIR_Componentes");
            comando.CommandType = CommandType.StoredProcedure;

            //(@idBodega int, @idProducto int, @Unidades int, @contenido float)

            comando.Parameters.AddWithValue("@idBodega", idBodega);
            comando.Parameters.AddWithValue("@idProducto", idProducto);
            comando.Parameters.AddWithValue("@Unidades", unidades);
            comando.Parameters.AddWithValue("@contenido", contenido);

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                db.ExecuteNonQuery(comando);
            }
        }
    }
}
