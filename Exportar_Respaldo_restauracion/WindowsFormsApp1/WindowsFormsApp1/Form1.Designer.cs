namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.xpproducto = new DevExpress.Xpo.XPCollection(this.components);
            this.unitOfWork1 = new DevExpress.Xpo.UnitOfWork(this.components);
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProducto1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrecio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExistencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExistenciaMinima = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExistenciaMaxima = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReservacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btexportar = new DevExpress.XtraEditors.SimpleButton();
            this.btrespaldo = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.xpproducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // xpproducto
            // 
            this.xpproducto.ObjectType = typeof(WindowsFormsApp1.facturacion.Producto);
            this.xpproducto.Session = this.unitOfWork1;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.xpproducto;
            this.gridControl1.Location = new System.Drawing.Point(12, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(917, 430);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdProducto,
            this.gridColumn1,
            this.gridColumn2,
            this.colProducto1,
            this.colPrecio,
            this.colExistencia,
            this.colExistenciaMinima,
            this.colExistenciaMaxima,
            this.colReservacion});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colIdProducto
            // 
            this.colIdProducto.FieldName = "IdProducto";
            this.colIdProducto.MinWidth = 25;
            this.colIdProducto.Name = "colIdProducto";
            this.colIdProducto.Visible = true;
            this.colIdProducto.VisibleIndex = 0;
            this.colIdProducto.Width = 94;
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "IdCategoria!";
            this.gridColumn1.MinWidth = 25;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            this.gridColumn1.Width = 94;
            // 
            // gridColumn2
            // 
            this.gridColumn2.FieldName = "IdCategoria!Key";
            this.gridColumn2.MinWidth = 25;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            this.gridColumn2.Width = 94;
            // 
            // colProducto1
            // 
            this.colProducto1.FieldName = "Producto1";
            this.colProducto1.MinWidth = 25;
            this.colProducto1.Name = "colProducto1";
            this.colProducto1.Visible = true;
            this.colProducto1.VisibleIndex = 3;
            this.colProducto1.Width = 94;
            // 
            // colPrecio
            // 
            this.colPrecio.FieldName = "Precio";
            this.colPrecio.MinWidth = 25;
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.Visible = true;
            this.colPrecio.VisibleIndex = 4;
            this.colPrecio.Width = 94;
            // 
            // colExistencia
            // 
            this.colExistencia.FieldName = "Existencia";
            this.colExistencia.MinWidth = 25;
            this.colExistencia.Name = "colExistencia";
            this.colExistencia.Visible = true;
            this.colExistencia.VisibleIndex = 5;
            this.colExistencia.Width = 94;
            // 
            // colExistenciaMinima
            // 
            this.colExistenciaMinima.FieldName = "ExistenciaMinima";
            this.colExistenciaMinima.MinWidth = 25;
            this.colExistenciaMinima.Name = "colExistenciaMinima";
            this.colExistenciaMinima.Visible = true;
            this.colExistenciaMinima.VisibleIndex = 6;
            this.colExistenciaMinima.Width = 94;
            // 
            // colExistenciaMaxima
            // 
            this.colExistenciaMaxima.FieldName = "ExistenciaMaxima";
            this.colExistenciaMaxima.MinWidth = 25;
            this.colExistenciaMaxima.Name = "colExistenciaMaxima";
            this.colExistenciaMaxima.Visible = true;
            this.colExistenciaMaxima.VisibleIndex = 7;
            this.colExistenciaMaxima.Width = 94;
            // 
            // colReservacion
            // 
            this.colReservacion.FieldName = "Reservacion";
            this.colReservacion.MinWidth = 25;
            this.colReservacion.Name = "colReservacion";
            this.colReservacion.Visible = true;
            this.colReservacion.VisibleIndex = 8;
            this.colReservacion.Width = 94;
            // 
            // btexportar
            // 
            this.btexportar.Location = new System.Drawing.Point(1009, 60);
            this.btexportar.Name = "btexportar";
            this.btexportar.Size = new System.Drawing.Size(94, 29);
            this.btexportar.TabIndex = 1;
            this.btexportar.Text = "Exportar";
            this.btexportar.Click += new System.EventHandler(this.btexportar_Click);
            // 
            // btrespaldo
            // 
            this.btrespaldo.Location = new System.Drawing.Point(984, 140);
            this.btrespaldo.Name = "btrespaldo";
            this.btrespaldo.Size = new System.Drawing.Size(94, 29);
            this.btrespaldo.TabIndex = 3;
            this.btrespaldo.Text = "Respaldo";
            this.btrespaldo.Click += new System.EventHandler(this.btrespaldo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1667, 716);
            this.Controls.Add(this.btrespaldo);
            this.Controls.Add(this.btexportar);
            this.Controls.Add(this.gridControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.xpproducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Xpo.XPCollection xpproducto;
        private DevExpress.Xpo.UnitOfWork unitOfWork1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProducto;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn colProducto1;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecio;
        private DevExpress.XtraGrid.Columns.GridColumn colExistencia;
        private DevExpress.XtraGrid.Columns.GridColumn colExistenciaMinima;
        private DevExpress.XtraGrid.Columns.GridColumn colExistenciaMaxima;
        private DevExpress.XtraGrid.Columns.GridColumn colReservacion;
        private DevExpress.XtraEditors.SimpleButton btexportar;
        private DevExpress.XtraEditors.SimpleButton btrespaldo;
    }
}

