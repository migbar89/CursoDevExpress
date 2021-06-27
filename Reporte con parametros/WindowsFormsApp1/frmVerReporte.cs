using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.facturacion;
using WindowsFormsApp1.Reportes;

namespace WindowsFormsApp1
{
    public partial class frmVerReporte : Form
    {
        public frmVerReporte()
        {
            InitializeComponent();
        }

        private void searchLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            Categoria cat =(Categoria) searchLookUpEdit1View.GetFocusedRow();
            Report1 report1 = new Report1();
            report1.Parameters["nombre_categoria"].Value = cat.Categoria1;
            report1.Parameters["nombre_categoria"].Visible = false;

            ReportPrintTool print = new ReportPrintTool(report1);
            print.ShowRibbonPreview();
        }
    }
}
