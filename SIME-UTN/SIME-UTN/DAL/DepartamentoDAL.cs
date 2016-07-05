using SIME_UTN.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace SIME_UTN.DAL
{
    class DepartamentoDAL
    {
        public static List<Departamento> ObtenerDepartamentos()
        {
            string sql = @"sp_SELECT_Departamento_All";

            List<Departamento> lista = new List<Departamento>();

            SqlCommand command = new SqlCommand(sql);
            command.CommandType = CommandType.StoredProcedure;

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                DataSet ds = db.ExecuteReader(command, "consulta");

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    try
                    {
                        Departamento unDepartamento = new Departamento();
                        unDepartamento.idDepartamento = Convert.ToInt32(dr["IDDepartamento"].ToString());
                        unDepartamento.descripcion = dr["Descripcion"].ToString();
                        unDepartamento.estado = dr["Estado"].ToString().Equals("True") ? 1 : 0;
                       
                        lista.Add(unDepartamento);
                    }
                    catch (Exception)
                    {

                    }
                }
            }
            return lista;
        }

        public static void GuardarDepartamento(Departamento Departamentop)
        {
            SqlCommand comando = new SqlCommand("sp_INSERT_Departamento");
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@IDDepartamento", Departamentop.idDepartamento);
            comando.Parameters.AddWithValue("@Descripcion", Departamentop.descripcion);
            comando.Parameters.AddWithValue("@Estado", Departamentop.estado);

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                db.ExecuteNonQuery(comando);
            }
        }

        public static Departamento ObtenerDepartamentoID(int idDepartamentop)
        {
            string sql = @"sp_SELECT_Departamento_ByID";

            List<Departamento> lista = new List<Departamento>();

            SqlCommand command = new SqlCommand(sql);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@IDDepartamento", idDepartamentop);

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                DataSet ds = db.ExecuteReader(command, "consulta");

                if (ds.Tables[0].Rows.Count > 0)
                {
                    Departamento unDepartamento = new Departamento();
                    unDepartamento.idDepartamento = Convert.ToInt32(ds.Tables[0].Rows[0]["IDDepartamento"].ToString());
                    unDepartamento.descripcion = ds.Tables[0].Rows[0]["Descripcion"].ToString();
                    unDepartamento.estado = ds.Tables[0].Rows[0]["Estado"].ToString().Equals("True") ? 1 : 0;

                    return unDepartamento;
                }
                else
                {
                    return null;
                }
            }
        }

        internal static void DesactivarDepartamento(string DepartamentoIdp, string accion)
        {
            accion = accion.Equals("Habilitar") ? "1" : "0";

            SqlCommand comando = new SqlCommand("sp_DISABLE_Departamento_ByID");
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@IDDepartamento", DepartamentoIdp);
            comando.Parameters.AddWithValue("@estado", accion);


            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                db.ExecuteNonQuery(comando);
            }
        }

        internal static void ActualizarDepartamento(Departamento Departamentop)
        {
            SqlCommand comando = new SqlCommand("sp_UPDATE_Departamento");
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@IDDepartamento", Departamentop.idDepartamento);
            comando.Parameters.AddWithValue("@Descripcion", Departamentop.descripcion);
            comando.Parameters.AddWithValue("@Estado", Departamentop.estado);

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                db.ExecuteNonQuery(comando);
            }
        }
    }
}
