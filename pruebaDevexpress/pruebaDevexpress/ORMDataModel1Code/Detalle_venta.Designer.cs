//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace pruebaDevexpress.venta
{

    [Persistent(@"detalle_venta")]
    public partial class Detalle_venta : XPLiteObject
    {
        int fIddetalleVenta;
        [Key(true)]
        [Persistent(@"iddetalle_venta")]
        public int IddetalleVenta
        {
            get { return fIddetalleVenta; }
            set { SetPropertyValue<int>(nameof(IddetalleVenta), ref fIddetalleVenta, value); }
        }
        int fCantidad;
        [Persistent(@"cantidad")]
        public int Cantidad
        {
            get { return fCantidad; }
            set { SetPropertyValue<int>(nameof(Cantidad), ref fCantidad, value); }
        }
        string fSubtotal;
        [Size(45)]
        [Persistent(@"subtotal")]
        public string Subtotal
        {
            get { return fSubtotal; }
            set { SetPropertyValue<string>(nameof(Subtotal), ref fSubtotal, value); }
        }
        Producto fProductoId;
        [Persistent(@"producto_Id")]
        [Association(@"Detalle_ventaReferencesProducto")]
        public Producto ProductoId
        {
            get { return fProductoId; }
            set { SetPropertyValue<Producto>(nameof(ProductoId), ref fProductoId, value); }
        }
        Venta fVentaIdventa;
        [Persistent(@"venta_idVenta")]
        [Association(@"Detalle_ventaReferencesVenta")]
        public Venta VentaIdventa
        {
            get { return fVentaIdventa; }
            set { SetPropertyValue<Venta>(nameof(VentaIdventa), ref fVentaIdventa, value); }
        }
    }

}
