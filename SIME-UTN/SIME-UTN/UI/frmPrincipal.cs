using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
using System.Threading;

namespace SIME_UTN.UI
{
    public partial class frmPrincipal : DevExpress.XtraEditors.XtraForm
    {
      
        public frmPrincipal()
        {
           
            Thread tardar = new Thread(new ThreadStart(this.SplashScreen));
            tardar.Start();
            Thread.Sleep(6000); // Tardanza para iniciar aplicacion (6000)
            InitializeComponent();
            tardar.Abort();
            // Handling the QueryControl event that will populate all automatically generated Documents
           
        }
        public void SplashScreen()
        {
            Application.Run(new frmSplashScreen());
        }

        // Assigning a required content for each auto generated Document
     

        private void bBtnUsuarios_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() != typeof(frmPrincipal))
                {
                    frm.Close();
                    break;
                }
            }
                    frmUsuarios ofrmUsuarios = new frmUsuarios();
                    ofrmUsuarios.MdiParent = this;
                    ofrmUsuarios.Show();
                   

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

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            FlyoutCloseAction.Action = this.createCloseAction(FlyoutCloseAction);
            if (wUIVIEW.ShowFlyoutDialog(FlyoutCloseAction) != System.Windows.Forms.DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        private void wUIVIEW_BackButtonClick(object sender, BackButtonClickEventArgs e)
        {
            /* Form unForm = new Form();
             List<Form> listaForms = new List<Form>();
             //unForm = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "frmUsuarios").SingleOrDefault<Form>();
             for (int i = 0; i < Application.OpenForms.Count; i++)
             {
                 unForm = new Form();
                 unForm = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "frmUsuarios").SingleOrDefault<Form>();
                 if (unForm != null)
                 {
                     // MessageBox.Show("El formulario 2 esta abierto");
                     unForm.Close();

                 }
             }*/
            foreach(Form frm in Application.OpenForms)
            {
                if (frm.GetType() != typeof(frmPrincipal))
                {
                    frm.Close();
                    break;
                }
            }

        }

     
    }
}