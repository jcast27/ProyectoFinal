using SIME_UTN.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
namespace SIME_UTN.DAL
{
    class EmpresaDAL
    {
        internal static bool ObtenerEmpresaByID(int idEmpresa)
        {
            Empresa unEmpresa = new Empresa();
            SqlCommand comando = new SqlCommand("sp_SELECT_Empresa_ByID");
            comando.CommandType = CommandType.StoredProcedure;
            bool existe = false;
            comando.Parameters.AddWithValue("@idempresa", idEmpresa);

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                DataSet ds = db.ExecuteReader(comando, "consulta");


                if (ds.Tables[0].Rows.Count > 0)
                {
                    existe = true;
                }
            }

            //foreach (DataRow dr in ds.Tables[0].Rows)
            //{


            //    unEmpresa.idEmpresa = Convert.ToInt32(dr["idempresa"].ToString());
            //    unEmpresa.nombre = dr["nombre"].ToString();
            //    unEmpresa.cedulaJuridica = dr["cedula"].ToString();
            //    unEmpresa.telefono = dr["telefono"].ToString();
            //    unEmpresa.estado = dr["estado"].ToString().Equals("True") ? 1 : 0;


            //}

            return existe;
        }

        internal static void EliminarEmpresa(Empresa empresaEstaticap, string usuarioLogueadop)
        {
            string accion = "";
            accion = "Eliminar";
            SqlCommand comando = new SqlCommand("sp_DISABLE_Empresa_ByID");
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idempresa", empresaEstaticap.idEmpresa);



            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                db.ExecuteNonQuery(comando);
            }
        }

        internal static void GuardarEmpresa(Empresa unaEmpresap, string usuarioLogueadop)
        {
            string accion = "";
            accion = "Insertar";
            SqlCommand comando = new SqlCommand("sp_INSERT_Empresa");
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre", unaEmpresap.nombre);
            comando.Parameters.AddWithValue("@cedula", unaEmpresap.cedulaJuridica);
            comando.Parameters.AddWithValue("@telefono", unaEmpresap.telefono);
            comando.Parameters.AddWithValue("@estado", unaEmpresap.estado);

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                db.ExecuteNonQuery(comando);
            }
        }

        internal static void ActualizarEmpresa(Empresa unaEmpresap, string usuarioLogueadop)
        {
            string accion = "";
            accion = "Modificar";
            SqlCommand comando = new SqlCommand("sp_UPDATE_Empresa");
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idempresa", unaEmpresap.idEmpresa);
            comando.Parameters.AddWithValue("@nombre", unaEmpresap.nombre);
            comando.Parameters.AddWithValue("@cedula", unaEmpresap.cedulaJuridica);
            comando.Parameters.AddWithValue("@telefono", unaEmpresap.telefono);
            comando.Parameters.AddWithValue("@estado", unaEmpresap.estado);

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                db.ExecuteNonQuery(comando);
            }
        }
    }
}
