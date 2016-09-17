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
            List<int> ids = new List<int>();
            GestorProducto gP = new GestorProducto();
            GestorUbicacion gU = new GestorUbicacion();
            GestorFuncionario gF = new GestorFuncionario();
            listaP = gP.ObtenerProductos();
            listaU = gU.ObtenerUbicacion();
            listaF = gF.ObtenerFuncionarios();
            foreach (Producto p in listaP)
            {
                ids.Add(p.idProducto);
            }
            e.ParametersInformation[0].Parameter.Value = ids;
            ids.Clear();
            foreach (Ubicacion u in listaU)
            {
                ids.Add(u.idUbicacion);
            }
            e.ParametersInformation[1].Parameter.Value = ids;
            ids.Clear();
            foreach (Funcionario f in listaF)
            {
                ids.Add(f.idFuncionario);
            }
            e.ParametersInformation[2].Parameter.Value = ids;
        }
    }
}
