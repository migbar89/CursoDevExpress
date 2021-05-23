using DevExpress.Xpo;
using pruebaDevexpress.formularios;
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

namespace pruebaDevexpress
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btguardar_Click(object sender, EventArgs e)
        {
           

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void btregistrarproducto_Click(object sender, EventArgs e)
        {
            //Crear un unitofwork
            UnitOfWork unit = new UnitOfWork();

            //Crear un objeto
            Producto prod = new Producto(unit);

            //llenar con datos el objeto
            prod.Nombre = ctnombre.Text;
            prod.FechaVencimiento = ctfechavencimiento.DateTime;
            prod.Precio =float.Parse( ctprecio.Text);
            prod.Estante = int.Parse(ctestante.Text);

            //guardar el objeto
            prod.Save();

            unit.CommitChanges();

            MessageBox.Show("Producto "+prod.Nombre+" Guardado Correctamente");
        }

        private void bteliminar_Click(object sender, EventArgs e)
        {
            Producto p =(Producto) gridViewProductos.GetFocusedRow();
            // MessageBox.Show(p.Nombre);
            unitOfWork1.Delete(p);
            unitOfWork1.CommitChanges();
        }

        private void btlimpiar_Click(object sender, EventArgs e)
        {
            ctnombre.Text = "";
            ctfechavencimiento.DateTime = DateTime.Today;
            ctprecio.Text = "0";
            ctestante.Text = "";
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            unitOfWork1.CommitChanges();
        }

        private void gridViewProductos_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
          
        }

        private void gridViewProductos_DoubleClick(object sender, EventArgs e)
        {
          
         Producto producto_seleccionado=(Producto)gridViewProductos.GetFocusedRow();
          //  MessageBox.Show(p.Nombre);
            frm_editar_producto frmeditar = new frm_editar_producto();
            frmeditar.producto_select = producto_seleccionado;
            frmeditar.unit = unitOfWork1;
            frmeditar.ShowDialog();

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            csimprimirgridview imprimir = new csimprimirgridview();
            imprimir.imprimirGridView("Titulo 1", "Exportando", gridViewProductos);
        }
    }
}
