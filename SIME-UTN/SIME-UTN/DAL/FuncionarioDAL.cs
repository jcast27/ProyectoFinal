using SIME_UTN.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace SIME_UTN.DAL
{
    class FuncionarioDAL
    {
        public static List<Funcionario> ObtenerFuncionarios()
        {
            string sql = @"sp_SELECT_Funcionario_All";

            List<Funcionario> lista = new List<Funcionario>();

            SqlCommand command = new SqlCommand(sql);
            command.CommandType = CommandType.StoredProcedure;

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                DataSet ds = db.ExecuteReader(command, "consulta");

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    try
                    {
                        Funcionario unFuncionario = new Funcionario();
                        unFuncionario.idFuncionario = Convert.ToInt32(dr["IDFuncionario"].ToString());
                        unFuncionario.nombre = dr["Nombre"].ToString();
                        unFuncionario.cedula = dr["Cedula"].ToString();
                        unFuncionario.telefono = dr["Telefono"].ToString();
                        unFuncionario.correo = dr["Correo"].ToString();
                        unFuncionario.idDepartamento = Convert.ToInt32(dr["IDDepartamento"].ToString());
                        unFuncionario.estado = dr["Estado"].ToString().Equals("True") ? 1 : 0;

                        lista.Add(unFuncionario);
                    }
                    catch (Exception)
                    {

                    }
                }
            }
            return lista;
        }

        public static void GuardarFuncionario(Funcionario Funcionariop)
        {
            SqlCommand comando = new SqlCommand("sp_INSERT_Funcionario");
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@IDFuncionario", Funcionariop.idFuncionario);
            comando.Parameters.AddWithValue("@Nombre", Funcionariop.nombre);
            comando.Parameters.AddWithValue("@Cedula", Funcionariop.cedula);
            comando.Parameters.AddWithValue("@Telefono", Funcionariop.telefono);
            comando.Parameters.AddWithValue("@Correo", Funcionariop.correo);
            comando.Parameters.AddWithValue("@IDDepartamento", Funcionariop.idDepartamento);
            comando.Parameters.AddWithValue("@Estado", Funcionariop.estado);

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                db.ExecuteNonQuery(comando);
            }
        }

        public static Funcionario ObtenerFuncionarioID(int idFuncionariop)
        {
            string sql = @"sp_SELECT_Funcionario_ByID";

            List<Funcionario> lista = new List<Funcionario>();

            SqlCommand command = new SqlCommand(sql);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@IDFuncionario", idFuncionariop);

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                DataSet ds = db.ExecuteReader(command, "consulta");

                if (ds.Tables[0].Rows.Count > 0)
                {
                    Funcionario unFuncionario = new Funcionario();
                    unFuncionario.idFuncionario = Convert.ToInt32(ds.Tables[0].Rows[0]["IDFuncionario"].ToString());
                    unFuncionario.nombre = ds.Tables[0].Rows[0]["Nombre"].ToString();
                    unFuncionario.cedula = ds.Tables[0].Rows[0]["Cedula"].ToString();
                    unFuncionario.telefono = ds.Tables[0].Rows[0]["Telefono"].ToString();
                    unFuncionario.correo = ds.Tables[0].Rows[0]["Correo"].ToString();
                    unFuncionario.idDepartamento = Convert.ToInt32(ds.Tables[0].Rows[0]["IDDepartamento"].ToString());
                    unFuncionario.estado = ds.Tables[0].Rows[0]["Estado"].ToString().Equals("True") ? 1 : 0;

                    return unFuncionario;
                }
                else
                {
                    return null;
                }
            }
        }


        internal static void DesactivarFuncionario(string FuncionarioIdp, string accion)
        {
            accion = accion.Equals("Habilitar") ? "1" : "0";

            SqlCommand comando = new SqlCommand("sp_DISABLE_Funcionario_ByID");
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@IDFuncionario", FuncionarioIdp);
            comando.Parameters.AddWithValue("@estado", accion);


            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                db.ExecuteNonQuery(comando);
            }
        }

        internal static void ActualizarFuncionario(Funcionario Funcionariop)
        {
            SqlCommand comando = new SqlCommand("sp_UPDATE_Funcionario");
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@IDFuncionario", Funcionariop.idFuncionario);
            comando.Parameters.AddWithValue("@Nombre", Funcionariop.nombre);
            comando.Parameters.AddWithValue("@Cedula", Funcionariop.cedula);
            comando.Parameters.AddWithValue("@Telefono", Funcionariop.telefono);
            comando.Parameters.AddWithValue("@Correo", Funcionariop.correo);
            comando.Parameters.AddWithValue("@IDDepartamento", Funcionariop.idDepartamento);
            comando.Parameters.AddWithValue("@Estado", Funcionariop.estado);

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                db.ExecuteNonQuery(comando);
            }
        }
    }
}
