using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using SIME_UTN.Gestores;
using SIME_UTN.Entities;
using SIME_UTN.DTOs;
using System.Collections.Generic;

namespace SIME_UTN.UI.Reportes
{
    public partial class rptDespacho : DevExpress.XtraReports.UI.XtraReport
    {
        public rptDespacho(string user)
        {
            InitializeComponent();
            lblUser.Text = user;
        }

        private void rptDespacho_ParametersRequestBeforeShow(object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
        {
            List<Producto> listaP = new List<Producto>();
            List<Ubicacion> listaU = new List<Ubicacion>();
            List<Funcionario> listaF = new List<Funcionario>();
            List<Despacho> listaD = new List<Despacho>();
            List<int> idsistaP = new List<int>();
            List<int> idslistaU = new List<int>();
            List<int> idslistaF = new List<int>();
            List<int> idlistaD = new List<int>();
            GestorProducto gP = new GestorProducto();
            GestorUbicacion gU = new GestorUbicacion();
            GestorFuncionario gF = new GestorFuncionario();
            GestorDespacho gD = new GestorDespacho();
            listaP = gP.ObtenerProductos();
            listaU = gU.ObtenerUbicacion();
            listaF = gF.ObtenerFuncionarios();
            listaD = gD.ObtenerDespachos();
            foreach (Producto p in listaP)
            {
                idsistaP.Add(p.idProducto);
            }
            e.ParametersInformation[0].Parameter.Value = idsistaP;
            foreach (Ubicacion u in listaU)
            {
                idslistaU.Add(u.idUbicacion);
            }
            e.ParametersInformation[1].Parameter.Value = idslistaU;
            foreach (Funcionario f in listaF)
            {
                idslistaF.Add(f.idFuncionario);
            }
            e.ParametersInformation[2].Parameter.Value = idslistaF;
            foreach (Despacho D in listaD)
            {
                idlistaD.Add(D.idDespacho);
            }
            e.ParametersInformation[3].Parameter.Value = idlistaD;

        }
    }
}
