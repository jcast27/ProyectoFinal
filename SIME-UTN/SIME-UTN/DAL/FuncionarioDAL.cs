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
                        Departamento unDepto = new Departamento();
                        unFuncionario.idFuncionario = Convert.ToInt32(dr["idfuncionario"].ToString());
                        unFuncionario.nombre = dr["nombre"].ToString();
                        unFuncionario.cedula = dr["cedula"].ToString();
                        unFuncionario.telefono = dr["telefono"].ToString();
                        unFuncionario.correo = dr["correo"].ToString();
                        unDepto.idDepartamento = int.Parse(dr["iddepartamento"].ToString());
                        unFuncionario.Departamento = unDepto;
                        unFuncionario.estado = dr["estado"].ToString().Equals("True") ? 1 : 0;

                        lista.Add(unFuncionario);
                    }
                    catch (Exception)
                    {

                    }
                }
            }
            return lista;
        }

        /// <summary>
        /// Metodo que guarda un nuevo funcionario
        /// </summary>
        /// <param name="unFuncionariop"></param>
        /// <param name="usuarioLogueadop"></param>
        public static void GuardarFuncionario(Funcionario unFuncionariop, string usuarioLogueadop)
        {
            string accion = "";
            accion = "Insertar";
            SqlCommand comando = new SqlCommand("sp_INSERT_Funcionario");
            comando.CommandType = CommandType.StoredProcedure;

           // comando.Parameters.AddWithValue("@idfuncionario", unFuncionariop.idFuncionario);
            comando.Parameters.AddWithValue("@nombre", unFuncionariop.nombre);
            comando.Parameters.AddWithValue("@cedula", unFuncionariop.cedula);
            comando.Parameters.AddWithValue("@telefono", unFuncionariop.telefono);
            comando.Parameters.AddWithValue("@correo", unFuncionariop.correo);
            comando.Parameters.AddWithValue("@iddepartamento", unFuncionariop.Departamento.idDepartamento);
            comando.Parameters.AddWithValue("@estado", unFuncionariop.estado);

            GuardarLog(unFuncionariop, usuarioLogueadop, accion, null);

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                db.ExecuteNonQuery(comando);
            }
        }

     /*   internal static bool ObtenerFuncionarioID(int idFuncionario)
        {
            bool existe = false;
            string sql = @"sp_SELECT_Funcionario_ByID";

            List<Funcionario> lista = new List<Funcionario>();

            SqlCommand command = new SqlCommand(sql);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@IDFuncionario", idFuncionario);

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                DataSet ds = db.ExecuteReader(command, "consulta");

                if (ds.Tables[0].Rows.Count > 0)
                {
                    existe = true;
                }

            }
            return existe;
        }*/

          public static Funcionario ObtenerFuncionarioID(int idFuncionariop)
          {
              string sql = @"sp_SELECT_Funcionario_ByID";

              List<Funcionario> lista = new List<Funcionario>();

              SqlCommand command = new SqlCommand(sql);
              command.CommandType = CommandType.StoredProcedure;

              command.Parameters.AddWithValue("@idfuncionario", idFuncionariop);

              using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
              {
                  DataSet ds = db.ExecuteReader(command, "consulta");

                  if (ds.Tables[0].Rows.Count > 0)
                  {
                      Funcionario unFuncionario = new Funcionario();
                      Departamento unDepto = new Departamento();
                      unFuncionario.idFuncionario = Convert.ToInt32(ds.Tables[0].Rows[0]["idfuncionario"].ToString());
                      unFuncionario.nombre = ds.Tables[0].Rows[0]["nombre"].ToString();
                      unFuncionario.cedula = ds.Tables[0].Rows[0]["cedula"].ToString();
                      unFuncionario.telefono = ds.Tables[0].Rows[0]["telefono"].ToString();
                      unFuncionario.correo = ds.Tables[0].Rows[0]["correo"].ToString();
                      unDepto.idDepartamento = int.Parse(ds.Tables[0].Rows[0]["iddepartamento"].ToString());
                      unFuncionario.Departamento = unDepto;
                   // unFuncionario.idDepartamento = Convert.ToInt32(ds.Tables[0].Rows[0]["IDDepartamento"].ToString());
                      unFuncionario.estado = ds.Tables[0].Rows[0]["estado"].ToString().Equals("True") ? 1 : 0;

                      return unFuncionario;
                  }
                  else
                  {
                      return null;
                  }
              }
          }

        internal static void EliminarFuncionario(int funcionarioIDp, string funcionariop, string usuarioLoguadop)
        {
            string accion = "";
            accion = "Eliminar";
            SqlCommand comando = new SqlCommand("sp_DISABLE_Funcionario_ByID");
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@idfuncionario", funcionarioIDp);
            GuardarLog(null, usuarioLoguadop, accion, funcionariop);

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                db.ExecuteNonQuery(comando);
            }
        }


        /*  internal static void DesactivarFuncionario(string FuncionarioIdp, string accion)
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
          }*/




        internal static void ActualizarFuncionario(Funcionario Funcionariop, string usuarioLogueadop)
        {
            string accion = "";
            accion = "Modificar";

            SqlCommand comando = new SqlCommand("sp_UPDATE_Funcionario");
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@idfuncionario", Funcionariop.idFuncionario);
            comando.Parameters.AddWithValue("@nombre", Funcionariop.nombre);
            comando.Parameters.AddWithValue("@cedula", Funcionariop.cedula);
            comando.Parameters.AddWithValue("@telefono", Funcionariop.telefono);
            comando.Parameters.AddWithValue("@correo", Funcionariop.correo);
            comando.Parameters.AddWithValue("@iddepartamento", Funcionariop.Departamento.idDepartamento);
            comando.Parameters.AddWithValue("@estado", Funcionariop.estado);
            GuardarLog(Funcionariop, usuarioLogueadop, accion, null);
            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                db.ExecuteNonQuery(comando);
            }
        }

        public static void GuardarLog(Funcionario unFuncionario, string usuarioLogueado, string accion, string funcionarioEliminado)
        {

            string descripcion = "";
            string estado = "";
            if (unFuncionario == null)
            {
                descripcion = "Funcionario eliminado: " + funcionarioEliminado;
                estado = "Desactivado";
            }
            else
            {
                estado = "Activo";
                descripcion = "Cédula: " + unFuncionario.cedula + "\r\nFuncionario: " + unFuncionario.nombre +
                    "\r\nCorreo: " + unFuncionario.correo + "\r\nTeléfono: " + unFuncionario.telefono +
                    "\r\nDepartamento: " + unFuncionario.Departamento.descripcion + "\r\nEstado: " + estado;

            }
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
