using PruebaPAV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoPAVI_Grupo2.ABM;
using TrabajoPAVI_Grupo2.Forms;

namespace TrabajoPAVI_Grupo2
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmInicioSesion());
        }
    }
}
