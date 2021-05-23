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
    public partial class frmventa : Form
    {
        Venta venta;
        Cliente cliente_seleccionado=null;
        Producto producto_seleccionado = null;
        public frmventa()
        {
            InitializeComponent();
        }

        private void searchLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
          cliente_seleccionado= (Cliente)searchViewCliente.GetFocusedRow();
        }

        private void searchLookUpEdit2_EditValueChanged(object sender, EventArgs e)
        {
            calcularSubtotal();
            ctcantidad.Focus();
            btagregar.Enabled = true;
           
        }
        void calcularSubtotal()
        {
            if (ctcantidad.Text.Trim().Length == 0)
                return;
            producto_seleccionado= (Producto)searchViewProducto.GetFocusedRow();
            lbPrecio.Text = "Precio:" + producto_seleccionado.Precio.ToString();
            int cantidad = Convert.ToInt32(ctcantidad.Text);
            lbsubtotal.Text = "Subtotal:" + (producto_seleccionado.Precio * cantidad).ToString();

        }

        private void ctcantidad_EditValueChanged(object sender, EventArgs e)
        {
            calcularSubtotal();
        }

        private void frmventa_Load(object sender, EventArgs e)
        {  venta = new Venta(unitOfWork1);
        }

        private void btagregar_Click(object sender, EventArgs e)
        {

          Detalle_venta  detalle = new Detalle_venta(unitOfWork1);

            int cantidad = Convert.ToInt32(ctcantidad.Text);           

            detalle.Cantidad =Convert.ToInt32( ctcantidad.Text);
            detalle.ProductoId = producto_seleccionado;
            detalle.Subtotal = (producto_seleccionado.Precio * cantidad).ToString();
            detalle.Save();
            venta.Detalle_ventas.Add(detalle);

            gridControlDetalle.DataSource = venta.Detalle_ventas;
            obtenerTotal();
        }
        void obtenerTotal()
        {
            float total=0;
            foreach(Detalle_venta detalle in venta.Detalle_ventas)
            {
                total += float.Parse(detalle.Subtotal);

            }
            lbtotal.Text = "Total:" + total.ToString();
        }

        private void btguardar_Click(object sender, EventArgs e)
        {
           
            if(cliente_seleccionado==null)
            {
                MessageBox.Show("Seleccione un Cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
             }
            if(venta.Detalle_ventas.Count==0)
            {
                MessageBox.Show("Agregue productos a la venta!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            venta.ClienteCodigo = cliente_seleccionado;
            venta.Fecha = DateTime.Today;
            venta.Save();

            unitOfWork1.CommitChanges();
        }
    }
}
