using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Heladeria.FronEnd;


namespace Heladeria
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
           //Application.Run(new frm_AltaUsuarios());
           //Application.Run(new frm_ABM_Usuario());
            Application.Run(new frm_Escritorio());
        }
    }
}
