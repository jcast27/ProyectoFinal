using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIME_UTN.Entities;
using SIME_UTN.Factories;
using SIME_UTN.BLL;

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
        public void GuardarUsuario()
        {
            UsuarioBLL.GuardarUsuario(usuario);
        }


        /// <summary>
        /// Metodo que invoca a OptenerUsuarios por ID de la BLL y que devuleve una lista de Usuarios
        /// </summary> 
        /// <returns></returns>
        public static List<UsuarioTable> OptenerId()
        {
            return UsuarioBLL.OptenerId();
        }

        /// <summary>
        /// Metodo que invoca a OptenerUsuarios por ID de la BLL y que devuleve un usuario
        /// </summary>
        /// <returns></returns>
        public UsuarioTable OptenerUsuarioId(int usuarioId)
        {
            return UsuarioBLL.OptenerUsuarioID(usuarioId);
        }

        /// <summary>
        /// Metodo que invoca a EliminarUsario de la BLL y que lo elimina de la base de datos
        /// </summary>
        /// <param name="UsuarioIdp"></param>
        /// <param name="UsuarioNombrep"></param>
        public void EliminarUsuario(int UsuarioIdp, string UsuarioNombrep)
        {
            UsuarioBLL.EliminarUsuario(UsuarioIdp, UsuarioNombrep);
        }




        public void InsertarNombreUsuario(string nombre)
        {
            NombreUsuario = nombre;
        }
        public string OptenerNombreUsuario()
        {
            return NombreUsuario;
        }

        internal int ValidarUsuario(string usuario)
        {
           return UsuarioBLL.ValidarUsuario(usuario);
        }
    }
  
}
