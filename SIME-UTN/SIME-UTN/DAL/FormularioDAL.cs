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
                        unForm.funcionario = UsuarioDAL.ObtenerUsuarioID(Convert.ToInt32(dr["IDFuncionario"].ToString()));
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

        public static int GuardarFormulario(Formulario Formulariop, string user)
        {
            SqlCommand comando = new SqlCommand("sp_INSERT_Formulario");
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@Fecha", Formulariop.fecha);
            comando.Parameters.AddWithValue("@Observaciones", Formulariop.observaciones);
            comando.Parameters.AddWithValue("@Cliente", Formulariop.cliente);
            comando.Parameters.AddWithValue("@IDFuncionario", Formulariop.funcionario.codigoUsuario);
            comando.Parameters.AddWithValue("@idempresa", Formulariop.empresa.idEmpresa);
            comando.Parameters.AddWithValue("@IDActivo", Formulariop.activo.idActivo);

            int idFormulario = 0;

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                DataSet ds = db.ExecuteReader(comando, "consulta");
                idFormulario = Convert.ToInt32(ds.Tables[0].Rows[0]["ID"].ToString());
            }

            GuardarLog(Formulariop, user,"Insertar");

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
                    unForm.fecha = Convert.ToDateTime(ds.Tables[0].Rows[0]["Fecha"].ToString());
                    unForm.observaciones = ds.Tables[0].Rows[0]["Observaciones"].ToString();
                    unForm.cliente = ds.Tables[0].Rows[0]["Cliente"].ToString();
                    unForm.funcionario = UsuarioDAL.ObtenerUsuarioID(Convert.ToInt32(ds.Tables[0].Rows[0]["IDFuncionario"].ToString()));
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

        public static void GuardarLog(Formulario form, string usuarioLogueado, string accion)
        {

            string descripcion = "Form #: " + form.idFormulario + "\r\nFecha: " + form.fecha +
                "\r\nObservaciones: " + form.observaciones + "\r\nCliente: " + form.cliente +
                "\r\nFuncionario: " + form.funcionario.nombre + " - " + form.funcionario.apellido1 + "\r\nPatrimonio Activo: " + form.activo.patrimonio;

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
