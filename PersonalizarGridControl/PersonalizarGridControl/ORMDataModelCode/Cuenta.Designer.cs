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
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace PersonalizarGridControl.credito_mauricio
{

    [Persistent(@"cuenta")]
    public partial class Cuenta : XPLiteObject
    {
        int fIdCuenta;
        [Key(true)]
        [Persistent(@"idCuenta")]
        public int IdCuenta
        {
            get { return fIdCuenta; }
            set { SetPropertyValue<int>(nameof(IdCuenta), ref fIdCuenta, value); }
        }
        string fNombre;
        [Size(200)]
        public string Nombre
        {
            get { return fNombre; }
            set { SetPropertyValue<string>(nameof(Nombre), ref fNombre, value); }
        }
        [Association(@"PrestamoReferencesCuenta")]
        public XPCollection<Prestamo> Prestamoes { get { return GetCollection<Prestamo>(nameof(Prestamoes)); } }
    }

}
