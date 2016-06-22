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

        public static int GuardarCategoria(Categoria Categoriap)
        {
            SqlCommand comando = new SqlCommand("sp_INSERT_Categoria");
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@Descripcion", Categoriap.descripcion);
            comando.Parameters.AddWithValue("@Pertenencia", Categoriap.pertenencia);
            comando.Parameters.AddWithValue("@Estado", Categoriap.estado);

            int idCategoria = 0;

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                DataSet ds = db.ExecuteReader(comando, "consulta");
                idCategoria = Convert.ToInt32(ds.Tables[0].Rows[0]["ID"].ToString());
            }

            return idCategoria;
        }

        public static Categoria ObtenerCategoriaID(int idCategoriap)
        {
            string sql = @"sp_SELECT_Categoria_ByID";

            List<Categoria> lista = new List<Categoria>();

            SqlCommand command = new SqlCommand(sql);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@IDCategoria", idCategoriap);

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                DataSet ds = db.ExecuteReader(command, "consulta");

                if (ds.Tables[0].Rows.Count > 0)
                {
                    Categoria unCategoria = new Categoria();
                    unCategoria.idCategoria = Convert.ToInt32(ds.Tables[0].Rows[0]["IDCategoria"].ToString());
                    unCategoria.descripcion = ds.Tables[0].Rows[0]["Descripcion"].ToString();
                    unCategoria.pertenencia = ds.Tables[0].Rows[0]["Pertenencia"].ToString();
                    unCategoria.estado = ds.Tables[0].Rows[0]["Estado"].ToString().Equals("True") ? 1 : 0;

                    List<CategoriaItem> listaCI = CategoriaItemDAL.ObtenerCategoriaItemID(unCategoria.idCategoria);
                    List<Item> listaItems = new List<Item>();
                    foreach (CategoriaItem ci in listaCI)
                    {
                        listaItems.Add(ItemDAL.ObtenerItemID(ci.idItem));
                    }

                    unCategoria.listaItems = listaItems;

                    return unCategoria;
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
