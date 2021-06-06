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

    [Persistent(@"referencias")]
    public partial class Referencias : XPLiteObject
    {
        int fIdreferencias;
        [Key(true)]
        [Persistent(@"idreferencias")]
        public int Idreferencias
        {
            get { return fIdreferencias; }
            set { SetPropertyValue<int>(nameof(Idreferencias), ref fIdreferencias, value); }
        }
        string fNombre_referencia;
        [Size(200)]
        [Persistent(@"nombre_referencia")]
        public string Nombre_referencia
        {
            get { return fNombre_referencia; }
            set { SetPropertyValue<string>(nameof(Nombre_referencia), ref fNombre_referencia, value); }
        }
        string fTelefono_referencia;
        [Size(45)]
        [Persistent(@"telefono_referencia")]
        public string Telefono_referencia
        {
            get { return fTelefono_referencia; }
            set { SetPropertyValue<string>(nameof(Telefono_referencia), ref fTelefono_referencia, value); }
        }
        string fParentesco_referencia;
        [Size(45)]
        [Persistent(@"parentesco_referencia")]
        public string Parentesco_referencia
        {
            get { return fParentesco_referencia; }
            set { SetPropertyValue<string>(nameof(Parentesco_referencia), ref fParentesco_referencia, value); }
        }
        string fDireccion_referencia;
        [Size(200)]
        [Persistent(@"direccion_referencia")]
        public string Direccion_referencia
        {
            get { return fDireccion_referencia; }
            set { SetPropertyValue<string>(nameof(Direccion_referencia), ref fDireccion_referencia, value); }
        }
        Cliente fClienteid;
        [Persistent(@"clienteid")]
        [Association(@"ReferenciasReferencesCliente")]
        public Cliente Clienteid
        {
            get { return fClienteid; }
            set { SetPropertyValue<Cliente>(nameof(Clienteid), ref fClienteid, value); }
        }
        string fNombre_completo;
        [Size(200)]
        [Persistent(@"nombre_completo")]
        public string Nombre_completo
        {
            get { return fNombre_completo; }
            set { SetPropertyValue<string>(nameof(Nombre_completo), ref fNombre_completo, value); }
        }
        string fTelefono;
        [Size(45)]
        [Persistent(@"telefono")]
        public string Telefono
        {
            get { return fTelefono; }
            set { SetPropertyValue<string>(nameof(Telefono), ref fTelefono, value); }
        }
        string fParentesco;
        [Size(45)]
        [Persistent(@"parentesco")]
        public string Parentesco
        {
            get { return fParentesco; }
            set { SetPropertyValue<string>(nameof(Parentesco), ref fParentesco, value); }
        }
        string fDireccion;
        [Size(20)]
        [Persistent(@"direccion")]
        public string Direccion
        {
            get { return fDireccion; }
            set { SetPropertyValue<string>(nameof(Direccion), ref fDireccion, value); }
        }
    }

}
