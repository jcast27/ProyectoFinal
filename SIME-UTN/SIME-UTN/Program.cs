using SIME_UTN.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIME_UTN
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            //Instancia a Login
            frmInicio ofrmInicio = new frmInicio();
            Application.Run(ofrmInicio);


            //frmMDI ofrmMDI = new frmMDI();
            //Application.Run(ofrmMDI);
            bool cambiarModulo = true;
            string name = "";
            //  si el resultado fue OK con el DialogResult
            if (ofrmInicio.DialogResult == DialogResult.OK)
            {
                Thread tardar = new Thread(new ThreadStart(SplashScreen));
                tardar.Start();
                Thread.Sleep(2000); // Tardanza para iniciar aplicacion (6000)
                tardar.Abort();

                if (ofrmInicio.Modulo == 0)
                {
                    name = "Formulario";
                }
                else if (ofrmInicio.Modulo == 1)
                {
                    name = "Bodega";
                }

                do
                {
                    if (name.Equals("Formulario"))
                    {
                        UI.Bodega.frmMDI frm = new UI.Bodega.frmMDI();
                        Application.Run(frm);
                        cambiarModulo = frm.modulo;
                        name = frm.name;
                    }
                    else if (name.Equals("Bodega"))
                    {
                        UI.Formulario.frmMDIForm frm = new UI.Formulario.frmMDIForm();
                        Application.Run(frm);
                        cambiarModulo = frm.modulo;
                        name = frm.name;
                    }
                } while (cambiarModulo);
            }
        }

        static void SplashScreen()
        {
            Application.Run(new frmSplashScreen());
        }
    }
}
