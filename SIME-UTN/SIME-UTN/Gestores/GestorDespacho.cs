﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIME_UTN.Entities;
using SIME_UTN.Factories;
using SIME_UTN.BLL;
using System.Windows.Forms;

namespace SIME_UTN.Gestores
{
    sealed class GestorDespacho
    {
        public static Despacho despacho;
        public static GestorDespacho instancia;

        public GestorDespacho()
        { despacho = new Despacho(); }

        public static GestorDespacho GetInstance()
        {
            if (instancia == null)
            {
                instancia = new GestorDespacho();
            }

            return instancia;
        }
        internal void AgregarDespacho(Despacho unDespacho)
        {
            despacho = unDespacho;
        }

        public void GuardarDespachoDetalle(int idDespacho, PBodega Bodegap)
        {
            DespachoBLL.GuardarDespacho(idDespacho, Bodegap);
        }

        public int GuardarDespacho(int idBodega, UsuarioTable user, string descripcion, Funcionario funcionario, Ubicacion ubicacion)
        {
            return DespachoBLL.GuardarDespacho(idBodega, user, descripcion, funcionario,ubicacion);
        }

        internal List<Despacho> ObtenerDespachos()
        {
            return DespachoBLL.ObtenerDespachos();
        }
    }
}
