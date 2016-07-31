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
        static Funcionario viejoFuncionario = null;
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
            viejoFuncionario = new Funcionario();
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
            viejoFuncionario = ObtenerFuncionarioID(unFuncionariop.idFuncionario);
            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                db.ExecuteNonQuery(comando);
            }

            GuardarLog(unFuncionariop, usuarioLogueadop, accion, null);
        }


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
            
            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                db.ExecuteNonQuery(comando);
            }
            GuardarLog(null, usuarioLoguadop, accion, funcionariop);
        }


        internal static void ActualizarFuncionario(Funcionario Funcionariop, string usuarioLogueadop)
        {
            viejoFuncionario = new Funcionario();
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
            viejoFuncionario = ObtenerFuncionarioID(Funcionariop.idFuncionario);
            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                db.ExecuteNonQuery(comando);
            }

            GuardarLog(Funcionariop, usuarioLogueadop, accion, null);
        }

        public static void GuardarLog(Funcionario unFuncionario, string usuarioLogueado, string accion, string funcionarioEliminado)
        {

            string descripcion = "";
            string estado = "";
            Funcionario nuevoFuncionario = new Funcionario();

            if (accion == "Eliminar")
            {
                descripcion = "Funcionario eliminado: " + funcionarioEliminado;
                estado = "Desactivado";
            }
            if (accion == "Insertar")
            {
                estado = "Activo";
                descripcion = "\r\nFuncionario";
                descripcion += "\r\n-----------------------------------------------------------------------\r\n";
                descripcion += "Cédula: " + unFuncionario.cedula + "\r\nFuncionario: " + unFuncionario.nombre +"\r\nCorreo: " + unFuncionario.correo + "\r\nTeléfono: " + unFuncionario.telefono +
                "\r\nDepartamento: " + unFuncionario.Departamento.descripcion + "\r\nEstado: " + estado;

            }
            if (accion == "Modificar")
            {
                
                nuevoFuncionario = ObtenerFuncionarioID(unFuncionario.idFuncionario);
                estado = "Activo";
                descripcion = "\r\nFuncionario";
                descripcion += "\r\n-----------------------------------------------------------------------\r\n";
                descripcion += "Antes del Cambio" + "\r\nCédula: " + viejoFuncionario.cedula + "\r\nFuncionario: " + viejoFuncionario.nombre + "\r\nCorreo: " + viejoFuncionario.correo + "\r\nTeléfono: " + viejoFuncionario.telefono +
                "\r\nDepartamento: " + viejoFuncionario.Departamento.descripcion + "\r\nEstado: " + estado;
                descripcion += "\r\n-----------------------------------------------------------------------\r\n";
                descripcion += "Despues del Cambio" + "\r\nCédula: " + nuevoFuncionario.cedula + "\r\nFuncionario: " + nuevoFuncionario.nombre + "\r\nCorreo: " + nuevoFuncionario.correo + "\r\nTeléfono: " + nuevoFuncionario.telefono +
                "\r\nDepartamento: " + nuevoFuncionario.Departamento.descripcion + "\r\nEstado: " + estado;
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
