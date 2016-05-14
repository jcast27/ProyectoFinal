using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIME_UTN.Entities;
using SIME_UTN.Factories;

namespace SIME_UTN.Gestores
{
    sealed class GestorUsuario
    {
    public static Usuario usuario;
    public static string NombreUsuario;
    public static GestorUsuario instancia;

        public GestorUsuario()
        {
            usuario = FactoryUsuario.CrearUsuario();
        }
        public static GestorUsuario GetInstance()
        {
            if (instancia == null)
            {
                instancia = new GestorUsuario();
            }

            return instancia;
        }
        public void InsertarNombreUsuario(string nombre)
        {
            NombreUsuario = nombre;
        }
        public string OptenerNombreUsuario()
        {
            return NombreUsuario;
        }
    }
  
}
