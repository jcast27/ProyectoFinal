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
            string sql = @"select * from Usuario order by CodigoUsuario";

            List<UsuarioTable> lista = new List<UsuarioTable>();

            SqlCommand command = new SqlCommand(sql);

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                DataSet ds = db.ExecuteReader(command, "consulta");

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    try
                    {
                        UsuarioTable unUsuario = new UsuarioTable();
                        unUsuario.codigoUsuario = Convert.ToInt32(dr["CodigoUsuario"].ToString());
                        unUsuario.usuario = dr["Usuario"].ToString();
                        unUsuario.nombre = dr["Nombre"].ToString();
                        unUsuario.apellido1 = dr["Apellido1"].ToString();
                        unUsuario.apellido2 = dr["Apellido2"].ToString();
                        unUsuario.perfil = dr["Perfil"].ToString();
                        unUsuario.contrasena = dr["Contrasena"].ToString();
                        unUsuario.estado = Convert.ToInt32(dr["Estado"].ToString());
                        lista.Add(unUsuario);
                    }
                    catch (Exception)
                    {

                    }
                }
            }
            return lista;


        }

        internal static bool CambiarContrasenna(string usuariop, string contrasenaAntiguap, string contrasenaNuevap)
        {
            Encriptar encriptar = new Encriptar();
            String contrasennaEncriptada = encriptar.Cifrar(contrasenaNuevap);
            bool cambioEfectuado = false;
            string sql = @"Update Usuario set Contrasena =@contrasena where Usuario = @usuario;
                           ALTER LOGIN "+ usuariop+ " WITH PASSWORD = '"+ contrasenaNuevap+ "' OLD_PASSWORD = '"+ contrasenaAntiguap+"'";

            SqlCommand command = new SqlCommand(sql);
            command.Parameters.AddWithValue("@contrasena",contrasennaEncriptada);
            command.Parameters.AddWithValue("@usuario",usuariop);
            try
            {
                using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
                {
                    db.ExecuteNonQuery(command, IsolationLevel.ReadCommitted);
                }
                cambioEfectuado = true;
            }
            catch (Exception)
            {
                cambioEfectuado = false;
            }
            return cambioEfectuado;
        }


        /// <summary>
        /// Metodo que devuleve el Usuario que esta logueado en la base de datos
        /// </summary>
        /// <returns></returns>
        internal static string ObtenerUsuarioLogeado()
        {
            string usuarioLogueado = "";
            string sql = @"select SUSER_SNAME() as UsuarioLogueado";

            SqlCommand command = new SqlCommand(sql);

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                DataSet ds = db.ExecuteReader(command, "consulta");

                if (ds.Tables[0].Rows.Count > 0)
                {

                    usuarioLogueado = ds.Tables[0].Rows[0]["UsuarioLogueado"].ToString();

                }
            }
            return usuarioLogueado;
        }


        /// <summary>
        /// Metodo que valida si el Usuario ya existe, si existe llama al metodo "obtenerNumeroDeUsuario()", para obtener el consecutivo
        /// </summary>
        /// <param name="usuariop"></param>
        /// <returns></returns>
        internal static int ValidarUsuario(string usuariop)
        {
            int numero = 0;
            string sql = @" SELECT * FROM [SIMEUTN].[dbo].[Usuario] WHERE Usuario like'%"+ usuariop+ "%'and  CodigoUsuario= (SELECT MAX(CodigoUsuario) from [SIMEUTN].[dbo].[Usuario] where Usuario like'%" + usuariop + "%')";

            List<UsuarioTable> lista = new List<UsuarioTable>();

            SqlCommand command = new SqlCommand(sql);
            command.Parameters.AddWithValue("@usuario", usuariop);

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                DataSet ds = db.ExecuteReader(command, "consulta");

                if (ds.Tables[0].Rows.Count > 0)
                {

                    UsuarioTable unUsuario = new UsuarioTable();
                    unUsuario.usuario = ds.Tables[0].Rows[0]["Usuario"].ToString();

                    numero = obtenerNumeroDeUsuario(unUsuario.usuario);


                }
            }
            return numero;
        }


        /// <summary>
        /// Metodo que devuelve un conseutivo de Usuario, si este ya existe
        /// </summary>
        /// <param name="usuariop"></param>
        /// <returns></returns>
        internal static int obtenerNumeroDeUsuario(string usuariop)
        {
            int numero = 0;
            string sql = @"SELECT dbo.udf_ObtenerNumero(Usuario) as Numero FROM [SIMEUTN].[dbo].[Usuario] where Usuario=@usuario";

            SqlCommand command = new SqlCommand(sql);
            command.Parameters.AddWithValue("@usuario", usuariop);

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                DataSet ds = db.ExecuteReader(command, "consulta");

                if (ds.Tables[0].Rows.Count > 0)
                {

                   string numero1 = ds.Tables[0].Rows[0]["Numero"].ToString();
                    if (numero1 == "")
                    {
                        numero = 1;
                    }else
                    {
                        numero = int.Parse(numero1)+1;
                    }





                }
            }
            return numero;
        }

        /// <summary>
        /// Optiene un usuario por el nombre
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns></returns>
        public static List<UsuarioTable> ObtenerUsuariosporNombre(string nombrep)
        {
            string sql = @"select Usuario.Usuario, Usuario.Perfil 
                           from Usuario
                           where Usuario.Usuario = @Usuario";

            List<UsuarioTable> lista = new List<UsuarioTable>();

            SqlCommand command = new SqlCommand(sql);
            command.Parameters.AddWithValue("@Usuario", nombrep);

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                DataSet ds = db.ExecuteReader(command, "consulta");

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    try
                    {
                        UsuarioTable unUsuario = new UsuarioTable();
                        unUsuario.usuario = dr["Usuario"].ToString();
                        unUsuario.perfil = dr["Perfil"].ToString();

                        lista.Add(unUsuario);
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
        public static void GuardarUsuario(UsuarioTable usuariop)
        {
         
            StringBuilder sql = new StringBuilder();
            Encriptar encriptar = new Encriptar();
            String contrasennaEncriptada = encriptar.Cifrar(usuariop.contrasena);

            sql.AppendFormat(" USE [master] ");
            sql.AppendFormat(" CREATE LOGIN {0} WITH PASSWORD=N'{1}', DEFAULT_DATABASE=[SIMEUTN], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF ", usuariop.usuario, usuariop.contrasena);
            sql.AppendFormat(" EXEC master..sp_addsrvrolemember @loginame = N'{0}', @rolename = N'sysadmin'", usuariop.usuario);
            sql.AppendFormat("USE [SIMEUTN] CREATE USER [{0}] FOR LOGIN [{0}]", usuariop.usuario);



            sql.AppendFormat(@"use SIMEUTN; insert into Usuario(Usuario,Nombre,Apellido1,Apellido2,Perfil,Contrasena,Estado)values ('{0}','{1}','{2}','{3}','{4}','{5}',{6})", usuariop.usuario,usuariop.nombre,usuariop.apellido1,usuariop.apellido2, usuariop.perfil,contrasennaEncriptada, usuariop.estado);


            SqlCommand command = new SqlCommand(sql.ToString());




            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                db.ExecuteNonQuery(command);
            }

        }



        /// <summary>
        /// Metodo que devuelve a un Usario de la base de datos, por medio del Codigo de Usuario
        /// </summary>
        /// <param name="CodigoUsuariop"></param>
        /// <returns></returns>
        public static UsuarioTable ObtenerUsuarioID(int UserIdp)
        {
            string sql = @"select Usuario.CodigoUsuario,Usuario.Usuario,Usuario.Perfil,Usuario.Contrasena
                         from Usuario
                         where Usuario.CodigoUsuario = @CodigoUsuario";


            SqlCommand commando = new SqlCommand(sql);
            commando.Parameters.AddWithValue("@CodigoUsuario", UserIdp);

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                DataSet ds = db.ExecuteReader(commando, "consulta");

                if (ds.Tables[0].Rows.Count > 0)
                {

                    UsuarioTable unUsuario = new UsuarioTable();
                    unUsuario.codigoUsuario = Convert.ToInt32(ds.Tables[0].Rows[0]["CodigoUsuario"].ToString());
                    unUsuario.usuario = ds.Tables[0].Rows[0]["Usuario"].ToString();
                    unUsuario.perfil = ds.Tables[0].Rows[0]["Perfil"].ToString();
                    unUsuario.contrasena = ds.Tables[0].Rows[0]["Contrasena"].ToString();

                    return unUsuario;


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
                           Nombre =@Nombre,
                           Apellido1=@Apellido1,
                           Apellido2=@Apellido2,
                           Perfil =@Perfil
                           where Usuario.CodigoUsuario = @CodigoUsuario";

            SqlCommand command = new SqlCommand(sql);
            command.Parameters.AddWithValue("@Nombre", usuariop.nombre);
            command.Parameters.AddWithValue("@Apellido1", usuariop.apellido1);
            command.Parameters.AddWithValue("@Apellido2", usuariop.apellido2);
            command.Parameters.AddWithValue("@Perfil", usuariop.perfil);
            command.Parameters.AddWithValue("@CodigoUsuario", usuariop.codigoUsuario);

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                db.ExecuteNonQuery(command, IsolationLevel.ReadCommitted);
            }
        }
        #endregion

        /// <summary>
        /// Metodo que valida si el usuarios existe por medio el usuario
        /// </summary>
        /// <param name="usuariop"></param>
        public static UsuarioTable ValidarUsuarioPorUsuario(string usuariop)
        {

            UsuarioTable unUsuario = null;
            string sql = @"use SIMEUTN; select * from Usuario where Usuario= @Usuario";


            SqlCommand commando = new SqlCommand(sql);
            commando.Parameters.AddWithValue("@Usuario", usuariop);

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                DataSet ds = db.ExecuteReader(commando, "consulta");

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    try
                    {
                        unUsuario = new UsuarioTable();
                        unUsuario.codigoUsuario = Convert.ToInt32(dr["CodigoUsuario"].ToString());
                        unUsuario.usuario = dr["Usuario"].ToString();
                        unUsuario.nombre = dr["Nombre"].ToString();
                        unUsuario.apellido1 = dr["Apellido1"].ToString();
                        unUsuario.apellido2 = dr["Apellido2"].ToString();
                        unUsuario.perfil = dr["Perfil"].ToString();
                        unUsuario.contrasena = dr["Contrasena"].ToString();
                        unUsuario.estado = Convert.ToInt32(dr["Estado"].ToString());

                    }
                    catch (Exception)
                    {

                    }
                }

            }
            return unUsuario;
        }

    }
}
