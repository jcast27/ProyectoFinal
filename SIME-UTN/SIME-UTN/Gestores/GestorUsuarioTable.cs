using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIME_UTN.Entities;
using SIME_UTN.Factories;
using SIME_UTN.BLL;
using System.Windows.Forms;
using SIME_UTN.DTOs;

namespace SIME_UTN.Gestores
{
    sealed class GestorUsuarioTable
    {
    public static UsuarioTable usuario;
    public static string NombreUsuario;
    public static GestorUsuarioTable instancia;

        public GestorUsuarioTable()
        {
            usuario = FactoryUsuarioTable.CrearUsuario();
        }
        public static GestorUsuarioTable GetInstance()
        {
            if (instancia == null)
            {
                instancia = new GestorUsuarioTable();
            }

            return instancia;
        }
        /// <summary>
        /// Metodo que invoca a ObtenerUsuarios de la BLL y que devulve una lista de Usuarios
        /// </summary>
        /// <returns></returns>
        public List<UsuarioTable> ObtenerUsuarios()
        {
            return UsuarioBLL.ObtenerUsuarios();
        }

        internal UsuarioTable ValidarUsuarioPorUsuario(string usuariop)
        {

            return UsuarioBLL.ValidarUsuarioPorUsuario(usuariop);
        }

        internal string ObtenerUsuarioLogeado()
        {
            return UsuarioBLL.ObtenerUsuarioLogeado();
        }

        public List<UsuarioTable> ObtenerUsuariosporNombre(string nombrep)
        {
            return UsuarioBLL.ObtenerUsuariosporNombre(nombrep);
        }


        /// <summary>
        /// Metodo que Agrega un Usuario ya creado
        /// </summary>
        /// <param name="usuariop"></param>
        public void AgregarUsuario(UsuarioTable usuariop)
        {
            usuario = usuariop;
        }

        /// <summary>
        /// Metodo que optiene el Usuario ya creado
        /// </summary>
        /// <returns></returns>
        public UsuarioTable ObtenerUsuario()
        {
            return usuario;
        }


        /// <summary>
        /// Metodo que invoca a GuardarUsuario de la BLL
        /// </summary>
        public void GuardarUsuario(string usuarioLogueado)
        {
            UsuarioBLL.GuardarUsuario(usuario, usuarioLogueado);
        }


        /// <summary>
        /// Metodo que invoca a ObtenerUsuarios por ID de la BLL y que devuleve un usuario
        /// </summary>
        /// <returns></returns>
        public UsuarioTable ObtenerUsuarioId(int usuarioIdp)
        {
            return UsuarioBLL.ObtenerUsuarioID(usuarioIdp);
        }


        /// <summary>
        /// Metodo que permite cambiar la contrasenna
        /// </summary>
        /// <param name="usuariop"></param>
        /// <param name="contrasenap"></param>
        /// <returns></returns>
        internal bool CambiarContrasenna(string usuariop, string contrasenaAntiguap,string contrasenaNuevap)
        {
            return UsuarioBLL.CambiarContrasenna(usuariop, contrasenaAntiguap, contrasenaNuevap);
        }

        /// <summary>
        /// Metodo que invoca a EliminarUsario de la BLL y que lo elimina de la base de datos
        /// </summary>
        /// <param name="UsuarioIdp"></param>
        /// <param name="UsuarioNombrep"></param>
        public void EliminarUsuario(int UsuarioIdp, string UsuarioNombrep, string usuarioLogueadop)
        {
            UsuarioBLL.EliminarUsuario(UsuarioIdp, UsuarioNombrep, usuarioLogueadop);
        }


        /// <summary>
        /// Metodo que valida si el Usuario ya existe
        /// </summary>
        /// <param name="usuariop"></param>
        internal int ValidarUsuario(string usuariop)
        {
            return UsuarioBLL.ValidarUsuario(usuariop);
        }

        public void InsertarNombreUsuario(string nombrep)
        {
            NombreUsuario = nombrep;
        }

        public string ObtenerNombreUsuario()
        {
            return NombreUsuario;
        }

        internal UsuarioTable ObtenerUsuarioPorNombreUsuario(string usuarioLogueado)
        {
            return UsuarioBLL.ObtenerUsuarioPorNombreUsuario(usuarioLogueado);
        }
    }
  
}
