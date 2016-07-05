using SIME_UTN.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace SIME_UTN.DAL
{
    class FormularioDAL
    {
        public static List<Formulario> ObtenerFormularios()
        {
            string sql = @"sp_SELECT_Formulario_All";

            List<Formulario> lista = new List<Formulario>();

            SqlCommand command = new SqlCommand(sql);
            command.CommandType = CommandType.StoredProcedure;

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                DataSet ds = db.ExecuteReader(command, "consulta");

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    try
                    {
                        Formulario unForm = new Formulario();
                        unForm.idFormulario = Convert.ToInt32(dr["IDFormulario"].ToString());
                        unForm.fecha = Convert.ToDateTime(dr["Fecha"].ToString());
                        unForm.observaciones = dr["Observaciones"].ToString();
                        unForm.cliente = dr["Cliente"].ToString();
                        unForm.funcionario = FuncionarioDAL.ObtenerFuncionarioID(Convert.ToInt32(dr["IDFuncionario"].ToString()));
                        unForm.activo = ActivoDAL.ObtenerActivoID(Convert.ToInt32(dr["IDActivo"].ToString()));
                        unForm.listaDF = DetalleFormularioDAL.ObtenerDetalleFormularioID(unForm.idFormulario);

                        lista.Add(unForm);
                    }
                    catch (Exception)
                    {

                    }
                }
            }
            return lista;
        }

        public static int GuardarFormulario(Formulario Formulariop)
        {
            SqlCommand comando = new SqlCommand("sp_INSERT_Formulario");
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@Fecha", Formulariop.fecha);
            comando.Parameters.AddWithValue("@Observaciones", Formulariop.observaciones);
            comando.Parameters.AddWithValue("@Cliente", Formulariop.cliente);
            comando.Parameters.AddWithValue("@IDFuncionario", Formulariop.funcionario.idFuncionario);
            comando.Parameters.AddWithValue("@IDActivo", Formulariop.activo.idActivo);

            int idFormulario = 0;

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                DataSet ds = db.ExecuteReader(comando, "consulta");
                idFormulario = Convert.ToInt32(ds.Tables[0].Rows[0]["ID"].ToString());
            }

            return idFormulario;
        }

        public static Formulario ObtenerFormularioID(int idFormulariop)
        {
            string sql = @"sp_SELECT_Formulario_ByID";

            List<Formulario> lista = new List<Formulario>();

            SqlCommand command = new SqlCommand(sql);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@IDFormulario", idFormulariop);

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                DataSet ds = db.ExecuteReader(command, "consulta");

                if (ds.Tables[0].Rows.Count > 0)
                {
                    Formulario unForm = new Formulario();
                    unForm.idFormulario = Convert.ToInt32(ds.Tables[0].Rows[0]["IDFormulario"].ToString());
                    unForm.fecha = Convert.ToDateTime(ds.Tables[0].Rows[0]["IDFormulario"].ToString());
                    unForm.observaciones = ds.Tables[0].Rows[0]["Observaciones"].ToString();
                    unForm.cliente = ds.Tables[0].Rows[0]["Cliente"].ToString();
                    unForm.funcionario = FuncionarioDAL.ObtenerFuncionarioID(Convert.ToInt32(ds.Tables[0].Rows[0]["IDFuncionario"].ToString()));
                    unForm.activo = ActivoDAL.ObtenerActivoID(Convert.ToInt32(ds.Tables[0].Rows[0]["IDActivo"].ToString()));
                    unForm.listaDF = DetalleFormularioDAL.ObtenerDetalleFormularioID(unForm.idFormulario);

                    return unForm;
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
