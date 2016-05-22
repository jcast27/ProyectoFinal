using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Threading;
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;

namespace SIME_UTN.UI
{
    public partial class frmMDI : DevExpress.XtraEditors.XtraForm
    {
        public frmMDI()
        {
            Thread tardar = new Thread(new ThreadStart(this.SplashScreen));
            tardar.Start();
            Thread.Sleep(6000); // Tardanza para iniciar aplicacion (6000)
            InitializeComponent();
            tardar.Abort();
            // Handling the QueryControl event that will populate all automatically generated Documents
            this.windowsUIView1.QueryControl += windowsUIView1_QueryControl;
        }

        public void SplashScreen()
        {
            Application.Run(new frmSplashScreen());
        }

        // Assigning a required content for each auto generated Document
        void windowsUIView1_QueryControl(object sender, DevExpress.XtraBars.Docking2010.Views.QueryControlEventArgs e)
        {

            if (e.Document == frmUsuariosDocument)
                e.Control = new SIME_UTN.UI.frmUsuarios();
            if (e.Document == frmProductosDocument)
                e.Control = new SIME_UTN.UI.frmProductos();

            if (e.Control == null)
                e.Control = new System.Windows.Forms.Control();
        }

        private void bBtnUsuarios_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            /* Form unForm = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "frmUsuarios").SingleOrDefault<Form>();
             if (unForm != null)
             {
                 // MessageBox.Show("El formulario 2 esta abierto");
                 unForm.Close();

             }*/
            
                frmUsuariosTile.Visible = true;
              
            
           
        }
        private FlyoutAction createCloseAction(Flyout flyout)
        {
            FlyoutAction closeaction = new FlyoutAction() { Caption = "Confirmacion", Description = "Desea Cerrar Esta Aplicacion?" };
            // closeaction.Description = "Desea Cerrar Esta Aplicacion?";
            FlyoutCommand comandoYes = new FlyoutCommand() { Text = "Si", Result = System.Windows.Forms.DialogResult.Yes };
            FlyoutCommand comandoNO = new FlyoutCommand() { Text = "No", Result = System.Windows.Forms.DialogResult.No };
            closeaction.Commands.Add(comandoYes);
            closeaction.Commands.Add(comandoNO);
            return closeaction;
        }

        private void frmMDI_FormClosing(object sender, FormClosingEventArgs e)
        {
            FlyoutCloseAction.Action = this.createCloseAction(FlyoutCloseAction);
            if (windowsUIView1.ShowFlyoutDialog(FlyoutCloseAction) != System.Windows.Forms.DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        private void windowsUIView1_BackButtonClick(object sender, BackButtonClickEventArgs e)
        {
            /*
           Form unForm = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "frmUsuarios").SingleOrDefault<Form>();
           if (unForm != null)
           {
               // MessageBox.Show("El formulario 2 esta abierto");
               unForm.Close();

           }

             foreach (Form frm in Application.OpenForms)
              {
                  if (frm.GetType() != typeof(frmMDI))
                  {

                      frm.Close();

                      break;
                  }
              }*/
          //  frmUsuariosTile.Visible = false;
        }

        private void rCMenu_Click(object sender, EventArgs e)
        {
            frmUsuariosTile.Visible = false;
        }
    }
}