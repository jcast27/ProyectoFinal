using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIME_UTN.DAL;
using SIME_UTN.Entities;

namespace SIME_UTN.BLL
{
    class UsuarioBLL
    {
        #region Metodos

        /// <summary>
        /// Metodo que llama al Metodo ObtenerUsuarios de la DAL
        /// </summary>
        /// <returns></returns>
        public static List<UsuarioTable> ObtenerUsuarios()
        {
            return UsuarioDAL.ObtenerUsuarios();
        }

        public static List<UsuarioTable> ObtenerUsuariosporNombre(string nombrep)
        {
            return UsuarioDAL.ObtenerUsuariosporNombre(nombrep);
        }
        #endregion


        internal static void GuardarUsuario(UsuarioTable usuariop,string usuarioLogueado)
        {
            if (UsuarioDAL.ObtenerUsuarioID(usuariop.codigoUsuario) == null)
            {

                UsuarioDAL.GuardarUsuario(usuariop, usuarioLogueado);
            }
            else
            {
                UsuarioDAL.ActualizarUsuario(usuariop, usuarioLogueado);
            }
        }


        internal static UsuarioTable ValidarUsuarioPorUsuario(string usuariop)
        {
            return UsuarioDAL.ValidarUsuarioPorUsuario(usuariop);
        }

        internal static string ObtenerUsuarioLogeado()
        {
            return UsuarioDAL.ObtenerUsuarioLogeado();
        }

        internal static UsuarioTable ObtenerUsuarioID(int usuarioIdp)
        {
            return UsuarioDAL.ObtenerUsuarioID(usuarioIdp);
        }

        internal static void EliminarUsuario(int UsuarioIdp, string UsuarioNombrep, string usuarioLogueadop)
        {
          
            UsuarioDAL.EliminarUsuarioTable(UsuarioIdp, UsuarioNombrep, usuarioLogueadop);
        }

        internal static int ValidarUsuario(string usuariop)
        {
           return UsuarioDAL.ValidarUsuario(usuariop);
        }

        internal static bool CambiarContrasenna(string usuariop, string contrasenaAntiguap, string contrasenaNuevap)
        {
            return UsuarioDAL.CambiarContrasenna(usuariop, contrasenaAntiguap, contrasenaNuevap);
        }

        internal static UsuarioTable ObtenerUsuarioPorNombreUsuario(string usuarioLogueado)
        {
            return UsuarioDAL.ObtenerUsuarioPorUser(usuarioLogueado);
        }
    }
}
