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
        static Departamento viejoDepartamento = null;
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
                        unDepartamento.idDepartamento = Convert.ToInt32(dr["iddepartamento"].ToString());
                        unDepartamento.descripcion = dr["descripcion"].ToString();
                        unDepartamento.estado = dr["estado"].ToString().Equals("True") ? 1 : 0;

                        lista.Add(unDepartamento);
                    }
                    catch (Exception)
                    {

                    }
                }
            }
            return lista;
        }

        public static void GuardarDepartamento(Departamento Departamentop, string usuarioLogueadop)
        {
            viejoDepartamento = new Departamento();
            string accion = "";
            accion = "Insertar";
            SqlCommand comando = new SqlCommand("sp_INSERT_Departamento");
            comando.CommandType = CommandType.StoredProcedure;

            //  comando.Parameters.AddWithValue("@IDDepartamento", Departamentop.idDepartamento);
            comando.Parameters.AddWithValue("@descripcion", Departamentop.descripcion);
            comando.Parameters.AddWithValue("@estado", Departamentop.estado);
            viejoDepartamento = ObtenerDepartamentoID(Departamentop.idDepartamento);
            

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                db.ExecuteNonQuery(comando);
            }
            GuardarLog(Departamentop, usuarioLogueadop, accion, null);
        }

        public static Departamento ObtenerDepartamentoID(int idDepartamentop)
        {
            string sql = @"sp_SELECT_Departamento_ByID";

            List<Departamento> lista = new List<Departamento>();

            SqlCommand command = new SqlCommand(sql);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@iddepartamento", idDepartamentop);

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                DataSet ds = db.ExecuteReader(command, "consulta");

                if (ds.Tables[0].Rows.Count > 0)
                {
                    Departamento unDepartamento = new Departamento();
                    unDepartamento.idDepartamento = Convert.ToInt32(ds.Tables[0].Rows[0]["iddepartamento"].ToString());
                    unDepartamento.descripcion = ds.Tables[0].Rows[0]["descripcion"].ToString();
                    unDepartamento.estado = ds.Tables[0].Rows[0]["estado"].ToString().Equals("True") ? 1 : 0;

                    return unDepartamento;
                }
                else
                {
                    return null;
                }
            }
        }

        internal static void EliminarDepartamento(int deptoIdp, string deptop, string usuarioLoguadop)
        {
            string accion = "";
            accion = "Eliminar";
            SqlCommand comando = new SqlCommand("sp_DISABLE_Departamento_ByID");
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@iddepartamento", deptoIdp);
          

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                db.ExecuteNonQuery(comando);
            }
            GuardarLog(null, usuarioLoguadop, accion, deptop);
        }


        internal static void ActualizarDepartamento(Departamento Departamentop, string usuarioLogueadop)
        {
            viejoDepartamento = new Departamento();
            string accion = "";
            accion = "Modificar";

            SqlCommand comando = new SqlCommand("sp_UPDATE_Departamento");
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@iddepartamento", Departamentop.idDepartamento);
            comando.Parameters.AddWithValue("@descripcion", Departamentop.descripcion);
            comando.Parameters.AddWithValue("@estado", Departamentop.estado);
            viejoDepartamento = ObtenerDepartamentoID(Departamentop.idDepartamento);
           

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                db.ExecuteNonQuery(comando);
            }
            GuardarLog(Departamentop, usuarioLogueadop, accion, null);
        }

        public static void GuardarLog(Departamento unDepto, string usuarioLogueado, string accion, string deptoEliminado)
        {

            string descripcion = "";
            string estado = "";
            Departamento nuevoDepartamento = new Departamento();

            if (accion == "Eliminar")
            {
                descripcion = "Departamento eliminado: " + deptoEliminado;
                estado = "Desactivado";
            }
            if (accion == "Insertar")
            {
                estado = "Activo";
                descripcion = "\r\nDepartamento";
                descripcion += "\r\n-----------------------------------------------------------------------\r\n";
                descripcion += "Departamento: " + unDepto.descripcion + "\r\nEstado: " + estado;

            }
            if (accion == "Modificar")
            {
               
                nuevoDepartamento = ObtenerDepartamentoID(unDepto.idDepartamento);
                estado = "Activo";
                descripcion = "\r\nDepartamento";
                descripcion += "\r\n-----------------------------------------------------------------------\r\n";
                descripcion += "Antes del Cambio" + "\r\nDepartamento: " + viejoDepartamento.descripcion + "\r\nEstado: " + estado;
                descripcion += "\r\n-----------------------------------------------------------------------\r\n";
                descripcion += "Despues del Cambio" + "\r\nDepartamento: " + nuevoDepartamento.descripcion + "\r\nEstado: " + estado;
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
