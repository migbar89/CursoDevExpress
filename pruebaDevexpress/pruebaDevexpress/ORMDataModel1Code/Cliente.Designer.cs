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
namespace pruebaDevexpress.venta
{

    [Persistent(@"cliente")]
    public partial class Cliente : XPLiteObject
    {
        int fCodigo;
        [Key(true)]
        [Persistent(@"codigo")]
        public int Codigo
        {
            get { return fCodigo; }
            set { SetPropertyValue<int>(nameof(Codigo), ref fCodigo, value); }
        }
        string fNombre;
        [Size(45)]
        public string Nombre
        {
            get { return fNombre; }
            set { SetPropertyValue<string>(nameof(Nombre), ref fNombre, value); }
        }
        string fApellido;
        [Size(45)]
        public string Apellido
        {
            get { return fApellido; }
            set { SetPropertyValue<string>(nameof(Apellido), ref fApellido, value); }
        }
        string fSexo;
        [Size(1)]
        public string Sexo
        {
            get { return fSexo; }
            set { SetPropertyValue<string>(nameof(Sexo), ref fSexo, value); }
        }
        string fDireccion;
        [Size(200)]
        public string Direccion
        {
            get { return fDireccion; }
            set { SetPropertyValue<string>(nameof(Direccion), ref fDireccion, value); }
        }
        [Association(@"VentaReferencesCliente")]
        public XPCollection<Venta> Ventas { get { return GetCollection<Venta>(nameof(Ventas)); } }
    }

}