using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using SIME_UTN.Gestores;
using SIME_UTN.Entities;
using SIME_UTN.DTOs;

namespace SIME_UTN.UI.Reportes
{
    public partial class rptTrasladoEspecifico : DevExpress.XtraReports.UI.XtraReport
    {
        public rptTrasladoEspecifico(string user)
        {
            InitializeComponent();
            lblUser.Text = user;
        }

        private void rptTrasladoUser_ParametersRequestBeforeShow(object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
        {
            List<UsuarioTable> listU = new List<UsuarioTable>();
            List<TrasladoProducto> listTP = new List<TrasladoProducto>();
            List<int> intlistU = new List<int>();
            List<int> intlistTP = new List<int>();
            GestorUsuarioTable gU = new GestorUsuarioTable();
            GestorTrasladoProducto gTP = new GestorTrasladoProducto();
            listU = gU.ObtenerUsuarios();
            listTP = gTP.ObtenerTraslados();
            foreach (UsuarioTable u in listU)
            {
                intlistU.Add(u.codigoUsuario);
            }
            e.ParametersInformation[0].Parameter.Value = intlistU;
            foreach (TrasladoProducto t in listTP)
            {
                intlistTP.Add(t.idTraslado);
            }
            e.ParametersInformation[1].Parameter.Value = intlistTP;
        }
    }
}
