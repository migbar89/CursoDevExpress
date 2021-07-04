using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btexportar_Click(object sender, EventArgs e)
        {
            csimprimirgridview imprimir = new csimprimirgridview();
            imprimir.imprimirGridView("Todos los productos", DateTime.Today.ToShortDateString(), gridView1);
        }

        private void btrespaldo_Click(object sender, EventArgs e)
        {
            frmrestore respaldo = new frmrestore();
            respaldo.ShowDialog();
            
        }
    }
}
