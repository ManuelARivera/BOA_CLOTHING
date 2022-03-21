using BOA_CLOTHING.Formularios;
using BOA_CLOTHING.Formularios.Formularios_Resportes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BOA_CLOTHING
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FrmLogin());
            Application.Run(new FrmLogin());
        }
    }
}
