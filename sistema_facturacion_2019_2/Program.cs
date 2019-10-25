using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_facturacion_2019_2
{
    static class Program
    {
        /// <summary>
        /// Aplicación Sistemas de Facturación.
        /// Creado por Lina María Montaño Ramírez 
        /// Materia Herramientas de programación III
        /// Creado el 28 de Agosto del 2019
        /// calypsobronte.me
        /// Licencia MIT
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmLogin());
            //Application.Run(new FrmPrincipal());
        }
    }
}
