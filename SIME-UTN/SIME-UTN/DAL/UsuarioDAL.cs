using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIME_UTN.Entities;
using System.Data.SqlClient;
using System.Data;

namespace SIME_UTN.DAL
{
    class UsuarioDAL
    {
        #region Metodos

        /// <summary>
        /// Metodo que devuleve una Lista de Usuarios de la base de datos
        /// </summary>
        /// <returns></returns>
        public static List<UsuarioTable> ObtenerUsuarios()
        {
            string sql = @"select Usuario.CodigoUsuario, Usuario.Usuario, Usuario.Perfil, Usuario.Contrasena 
                           from Usuario";

            List<UsuarioTable> lista = new List<UsuarioTable>();

            SqlCommand command = new SqlCommand(sql);

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                DataSet ds = db.ExecuteReader(command, "consulta");

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    try
                    {
                        UsuarioTable usuario = new UsuarioTable();
                        usuario.codigoUsuario = Convert.ToInt32(dr["CodigoUsuario"].ToString());
                        usuario.usuario = dr["Usuario"].ToString();
                        usuario.perfil = dr["Perfil"].ToString();
                        usuario.contrasena = dr["Contrasena"].ToString();
                        lista.Add(usuario);
                    }
                    catch (Exception)
                    {

                    }
                }
            }
            return lista;


        }

        /// <summary>
        /// Optiene un usuario por el nombre
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns></returns>
        public static List<UsuarioTable> ObtenerUsuariosporNombre(string nombre)
        {
            string sql = @"select Usuario.Usuario, Usuario.Perfil 
                           from Usuario
                           where Usuario.Usuario = @Usuario";

            List<UsuarioTable> lista = new List<UsuarioTable>();

            SqlCommand command = new SqlCommand(sql);
            command.Parameters.AddWithValue("@Usuario", nombre);

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                DataSet ds = db.ExecuteReader(command, "consulta");

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    try
                    {
                        UsuarioTable usuario = new UsuarioTable();
                        usuario.usuario = dr["Usuario"].ToString();
                        usuario.perfil = dr["Perfil"].ToString();

                        lista.Add(usuario);
                    }
                    catch (Exception)
                    {

                    }
                }
            }
            return lista;


        }

        /// <summary>
        /// Metodo que Guarda un Usuario en la base de datos
        /// </summary>
        /// <param name="usuario"></param>
        public static void GuardarUsuario(UsuarioTable usuario)
        {
            StringBuilder sql = new StringBuilder();

            sql.AppendFormat(" USE [master] ");
            sql.AppendFormat(" CREATE LOGIN {0} WITH PASSWORD=N'{1}', DEFAULT_DATABASE=[SIMEUTN], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF ", usuario.usuario, usuario.contrasena);
            sql.AppendFormat(" EXEC master..sp_addsrvrolemember @loginame = N'{0}', @rolename = N'sysadmin'", usuario.usuario);
            sql.AppendFormat("USE [SIMEUTN] CREATE USER [{0}] FOR LOGIN [{0}]", usuario.usuario);



            sql.AppendFormat(@"use SIMEUTN; insert into Usuario(Usuario,Perfil,Contrasena)values ('{0}','{1}','{2}')", usuario.usuario, usuario.perfil, usuario.contrasena);


            SqlCommand command = new SqlCommand(sql.ToString());




            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                db.ExecuteNonQuery(command);
            }

        }



        /// <summary>
        /// Metodo que devuelve una Lista de Usuarios, por medio del Codigo de Usuario
        /// </summary>
        /// <returns></returns>
        internal static List<UsuarioTable> OptenerId()
        {
            string sql = @"select MAX(Usuario.CodigoUsuario)+1 as ID
                          FROM Usuario";

            List<UsuarioTable> lista = new List<UsuarioTable>();
            SqlCommand command = new SqlCommand(sql);

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                DataSet ds = db.ExecuteReader(command, "consulta");
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    try
                    {
                        UsuarioTable usuario = new UsuarioTable();
                        usuario.codigoUsuario = Convert.ToInt32(dr["ID"]);
                        lista.Add(usuario);
                    }
                    catch (Exception)
                    {
                        UsuarioTable usuario = new UsuarioTable();
                        usuario.codigoUsuario = 1;
                        lista.Add(usuario);
                    }
                }
                return lista;

            }
        }


        /// <summary>
        /// Metodo que devuelve a un Usario de la base de datos, por medio del Codigo de Usuario
        /// </summary>
        /// <param name="CodigoUsuariop"></param>
        /// <returns></returns>
        public static UsuarioTable OptenerUsuarioID(int UserId)
        {
            string sql = @"select Usuario.CodigoUsuario,Usuario.Usuario,Usuario.Perfil,Usuario.Contrasena
                         from Usuario
                         where Usuario.CodigoUsuario = @CodigoUsuario";


            SqlCommand commando = new SqlCommand(sql);
            commando.Parameters.AddWithValue("@CodigoUsuario", UserId);

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                DataSet ds = db.ExecuteReader(commando, "consulta");

                if (ds.Tables[0].Rows.Count > 0)
                {

                    UsuarioTable usuario = new UsuarioTable();
                    usuario.codigoUsuario = Convert.ToInt32(ds.Tables[0].Rows[0]["CodigoUsuario"].ToString());
                    usuario.usuario = ds.Tables[0].Rows[0]["Usuario"].ToString();
                    usuario.perfil = ds.Tables[0].Rows[0]["Perfil"].ToString();
                    usuario.contrasena = ds.Tables[0].Rows[0]["Contrasena"].ToString();

                    return usuario;


                }
                else
                {
                    return null;
                }

            }

        }


        /// <summary>
        /// Metodo que elimina un Usuario de la base de datos
        /// </summary>
        /// <param name="UsuarioIdp"></param>
        /// <param name="UsuarioNombrep"></param>
        internal static void EliminarUsuario(int UsuarioIdp, string UsuarioNombrep)
        {
            StringBuilder sql = new StringBuilder();
            sql.AppendFormat("USE [master] DROP LOGIN [{0}] ", UsuarioNombrep);
            sql.AppendFormat("USE [SIMEUTN] DROP USER [{0}] ", UsuarioNombrep);
            sql.AppendFormat("delete from Usuario where Usuario.CodigoUsuario = {0} and Usuario.Usuario = '{1}'", UsuarioIdp, UsuarioNombrep);

            SqlCommand command = new SqlCommand(sql.ToString());



            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                db.ExecuteNonQuery(command);
            }

        }

        /// <summary>
        /// Metodo que actualiza el perfil de un Usuario ya creado
        /// </summary>
        /// <param name="usuariop"></param>
        internal static void ActualizarUsuario(UsuarioTable usuariop)
        {
            string sql = @"Update Usuario
                           set
                           Usuario =@Usuario,
                           Perfil =@Perfil
                           where Usuario.CodigoUsuario = @CodigoUsuario";

            SqlCommand command = new SqlCommand(sql);
            command.Parameters.AddWithValue("@Usuario", usuariop.usuario);
            command.Parameters.AddWithValue("@Perfil", usuariop.perfil);
            command.Parameters.AddWithValue("@CodigoUsuario", usuariop.codigoUsuario);

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                db.ExecuteNonQuery(command, IsolationLevel.ReadCommitted);
            }
        }
        #endregion

    }
}
