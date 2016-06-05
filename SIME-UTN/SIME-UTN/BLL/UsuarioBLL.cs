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


        internal static void GuardarUsuario(UsuarioTable usuariop)
        {
            if (UsuarioDAL.OptenerUsuarioID(usuariop.codigoUsuario) == null)
            {

                UsuarioDAL.GuardarUsuario(usuariop);
            }
            else
            {
                UsuarioDAL.ActualizarUsuario(usuariop);
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

        internal static UsuarioTable OptenerUsuarioID(int usuarioIdp)
        {
            return UsuarioDAL.OptenerUsuarioID(usuarioIdp);
        }

        internal static void EliminarUsuario(int UsuarioIdp, string UsuarioNombrep)
        {
            UsuarioDAL.EliminarUsuario(UsuarioIdp, UsuarioNombrep);
        }

        internal static int ValidarUsuario(string usuariop)
        {
           return UsuarioDAL.ValidarUsuario(usuariop);
        }

        internal static bool CambiarContrasenna(string usuariop, string contrasenaAntiguap, string contrasenaNuevap)
        {
            return UsuarioDAL.CambiarContrasenna(usuariop, contrasenaAntiguap, contrasenaNuevap);
        }
    }
}
