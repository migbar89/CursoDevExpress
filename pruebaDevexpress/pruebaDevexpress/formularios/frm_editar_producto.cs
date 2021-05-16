using DevExpress.Xpo;
using pruebaDevexpress.venta;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pruebaDevexpress.formularios
{
    public partial class frm_editar_producto : Form
    {
        public Producto producto_select = null;
        public UnitOfWork unit = null;
        public frm_editar_producto()
        {
            InitializeComponent();
        }

        private void frm_editar_producto_Load(object sender, EventArgs e)
        {
            ctnombre.Text = producto_select.Nombre;
            ctfechavencimiento.DateTime = producto_select.FechaVencimiento;
            ctprecio.Text = producto_select.Precio.ToString();
            ctestante.Text = producto_select.Estante.ToString() ;

        }

        private void btguardar_Click(object sender, EventArgs e)
        {
            producto_select.Nombre = ctnombre.Text;
            producto_select.FechaVencimiento = ctfechavencimiento.DateTime;
            producto_select.Precio = float.Parse(ctprecio.Text);
            producto_select.Estante = int.Parse(ctestante.Text);
            unit.CommitChanges();
            this.Close();

          
        }
    }
}
