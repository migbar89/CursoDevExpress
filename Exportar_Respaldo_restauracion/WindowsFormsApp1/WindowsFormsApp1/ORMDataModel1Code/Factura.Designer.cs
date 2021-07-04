﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace WindowsFormsApp1.facturacion
{

    [Persistent(@"factura")]
    public partial class Factura : XPLiteObject
    {
        int fIdFactura;
        [Key(true)]
        [Persistent(@"idFactura")]
        public int IdFactura
        {
            get { return fIdFactura; }
            set { SetPropertyValue<int>(nameof(IdFactura), ref fIdFactura, value); }
        }
        int fIdCliente;
        [Indexed(Name = @"FK_Factura_idCliente")]
        [Persistent(@"idCliente")]
        public int IdCliente
        {
            get { return fIdCliente; }
            set { SetPropertyValue<int>(nameof(IdCliente), ref fIdCliente, value); }
        }
        Empleado fIdEmpleado;
        [Persistent(@"idEmpleado")]
        [Association(@"FacturaReferencesEmpleado")]
        public Empleado IdEmpleado
        {
            get { return fIdEmpleado; }
            set { SetPropertyValue<Empleado>(nameof(IdEmpleado), ref fIdEmpleado, value); }
        }
        DateTime fFechaFactura;
        [Persistent(@"fechaFactura")]
        public DateTime FechaFactura
        {
            get { return fFechaFactura; }
            set { SetPropertyValue<DateTime>(nameof(FechaFactura), ref fFechaFactura, value); }
        }
        decimal fIva;
        [Persistent(@"iva")]
        public decimal Iva
        {
            get { return fIva; }
            set { SetPropertyValue<decimal>(nameof(Iva), ref fIva, value); }
        }
        decimal fDescuento;
        [Persistent(@"descuento")]
        public decimal Descuento
        {
            get { return fDescuento; }
            set { SetPropertyValue<decimal>(nameof(Descuento), ref fDescuento, value); }
        }
        decimal fTotal;
        [Persistent(@"total")]
        public decimal Total
        {
            get { return fTotal; }
            set { SetPropertyValue<decimal>(nameof(Total), ref fTotal, value); }
        }
        decimal fSaldo;
        [Persistent(@"saldo")]
        public decimal Saldo
        {
            get { return fSaldo; }
            set { SetPropertyValue<decimal>(nameof(Saldo), ref fSaldo, value); }
        }
        [Association(@"FacturaabonoReferencesFactura")]
        public XPCollection<Facturaabono> Facturaabonoes { get { return GetCollection<Facturaabono>(nameof(Facturaabonoes)); } }
        [Association(@"FacturadetalleReferencesFactura")]
        public XPCollection<Facturadetalle> Facturadetalles { get { return GetCollection<Facturadetalle>(nameof(Facturadetalles)); } }
    }

}
