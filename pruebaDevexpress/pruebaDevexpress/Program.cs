using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using pruebaDevexpress.formularios;
using pruebaDevexpress.venta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pruebaDevexpress
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            XpoDefault.DataLayer = XpoDefault.GetDataLayer(
                 ConnectionHelper.ConnectionString, 
                 AutoCreateOption.DatabaseAndSchema);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           // Application.Run(new Form1());
            Application.Run(new frmventa());
        }
    }
}
