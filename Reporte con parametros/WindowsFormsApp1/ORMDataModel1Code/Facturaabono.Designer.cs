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

    [Persistent(@"facturaabono")]
    public partial class Facturaabono : XPLiteObject
    {
        int fIdFacturaAbono;
        [Key(true)]
        [Persistent(@"idFacturaAbono")]
        public int IdFacturaAbono
        {
            get { return fIdFacturaAbono; }
            set { SetPropertyValue<int>(nameof(IdFacturaAbono), ref fIdFacturaAbono, value); }
        }
        Factura fIdFactura;
        [Persistent(@"idFactura")]
        [Association(@"FacturaabonoReferencesFactura")]
        public Factura IdFactura
        {
            get { return fIdFactura; }
            set { SetPropertyValue<Factura>(nameof(IdFactura), ref fIdFactura, value); }
        }
        decimal fMontoAbono;
        [Persistent(@"montoAbono")]
        public decimal MontoAbono
        {
            get { return fMontoAbono; }
            set { SetPropertyValue<decimal>(nameof(MontoAbono), ref fMontoAbono, value); }
        }
        DateTime fFechaAbono;
        [Persistent(@"fechaAbono")]
        public DateTime FechaAbono
        {
            get { return fFechaAbono; }
            set { SetPropertyValue<DateTime>(nameof(FechaAbono), ref fFechaAbono, value); }
        }
    }

}