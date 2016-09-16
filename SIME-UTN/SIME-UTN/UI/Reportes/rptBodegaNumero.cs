using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using SIME_UTN.DataSets.Reportes;
using DevExpress.DataAccess.Native.Sql;
using SIME_UTN.Gestores;
using SIME_UTN.Entities;
using SIME_UTN.DTOs;

namespace SIME_UTN.UI.Reportes
{
    public partial class rptBodegaNumero : DevExpress.XtraReports.UI.XtraReport
    {
        public rptBodegaNumero(string user)
        {
            InitializeComponent();
            lblUser.Text = user;
        }

        private void rptBodegaNumero_ParametersRequestBeforeShow(object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
        {
            List<Producto> listaP = new List<Producto>();
            List<int> ids = new List<int>();
            List<RegistroBodegaTipoBodegaDTO> listaBodega = new List<RegistroBodegaTipoBodegaDTO>();
            List<int> idsBodega = new List<int>();
            GestorProducto gP = new GestorProducto();
            GestorRegistroBodega gRB = new GestorRegistroBodega();
            listaP=gP.ObtenerProductos();
            listaBodega = gRB.ObtenertBodegas();
            foreach (Producto p in listaP)
            {
                ids.Add(p.idProducto);
            }
            foreach (RegistroBodegaTipoBodegaDTO b in listaBodega)
            {
                idsBodega.Add(b.idregistrobodega);
            }
            e.ParametersInformation[0].Parameter.Value = idsBodega;
            e.ParametersInformation[1].Parameter.Value = ids;
        }
    }
}
