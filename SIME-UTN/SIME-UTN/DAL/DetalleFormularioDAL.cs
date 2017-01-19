using SIME_UTN.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace SIME_UTN.DAL
{
    class DetalleFormularioDAL
    {
        public static void GuardarDetalleFormulario(DetalleFormulario DF, string user)
        {
            SqlCommand comando = new SqlCommand("sp_INSERT_DetalleFormulario");
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@IDFormulario", DF.idFormulario);
            comando.Parameters.AddWithValue("@IDItem", DF.idItem);
            comando.Parameters.AddWithValue("@Valor", DF.valor);

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                db.ExecuteNonQuery(comando);
            }

            GuardarLog(DF, user);

        }

        public static List<DetalleFormulario> ObtenerDetalleFormularioID(int idFormulario)
        {
            string sql = @"sp_SELECT_DetalleFormulario_ByID";

            List<DetalleFormulario> lista = new List<DetalleFormulario>();

            SqlCommand command = new SqlCommand(sql);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@IDFormulario", idFormulario);

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                DataSet ds = db.ExecuteReader(command, "consulta");

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    DetalleFormulario unDF = new DetalleFormulario();
                    unDF.idFormulario = Convert.ToInt32(dr["IDCategoria"].ToString());
                    unDF.idItem = Convert.ToInt32(dr["IDItem"].ToString());
                    unDF.valor = dr["Valor"].ToString();
                    lista.Add(unDF);
                }
            }
            return lista;
        }

        public static void GuardarLog(DetalleFormulario DF, string usuarioLogueado)
        {
            string descripcion = "Form #: " + DF.idFormulario + "\r\nID Item: " + DF.idItem + "\r\nValor: " + DF.valor;

            DateTime date = DateTime.Now;
            string fecha = date.ToString("dd/MM/yyyy");
            SqlCommand comando = new SqlCommand("sp_INSERT_log");
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@usuario", usuarioLogueado);
            comando.Parameters.AddWithValue("@accion", "Insertar");
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
