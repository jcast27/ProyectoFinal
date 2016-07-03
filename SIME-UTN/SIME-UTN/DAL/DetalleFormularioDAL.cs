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
        public static void GuardarDetalleFormulario(DetalleFormulario DF)
        {
            SqlCommand comando = new SqlCommand("sp_INSERT_DetalleFormularios");
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@IDFormulario", DF.idFormulario);
            comando.Parameters.AddWithValue("@IDItem", DF.idItem);
            comando.Parameters.AddWithValue("@Valor", DF.valor);

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                db.ExecuteNonQuery(comando);
            }

        }

        public static List<DetalleFormulario> ObtenerDetalleFormularioID(int idFormulario)
        {
            string sql = @"sp_SELECT_DetalleFormularios_ByID";

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

    }
}
