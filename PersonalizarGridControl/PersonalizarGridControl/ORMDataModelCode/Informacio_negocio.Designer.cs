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

    [Persistent(@"informacio_negocio")]
    public partial class Informacio_negocio : XPLiteObject
    {
        int fIdnegocios;
        [Key(true)]
        [Persistent(@"idnegocios")]
        public int Idnegocios
        {
            get { return fIdnegocios; }
            set { SetPropertyValue<int>(nameof(Idnegocios), ref fIdnegocios, value); }
        }
        string fNombre_negocio;
        [Size(200)]
        [Persistent(@"nombre_negocio")]
        public string Nombre_negocio
        {
            get { return fNombre_negocio; }
            set { SetPropertyValue<string>(nameof(Nombre_negocio), ref fNombre_negocio, value); }
        }
        string fActividad;
        [Size(45)]
        [Persistent(@"actividad")]
        public string Actividad
        {
            get { return fActividad; }
            set { SetPropertyValue<string>(nameof(Actividad), ref fActividad, value); }
        }
        int fCantidad_trabajadores;
        [Persistent(@"cantidad_trabajadores")]
        public int Cantidad_trabajadores
        {
            get { return fCantidad_trabajadores; }
            set { SetPropertyValue<int>(nameof(Cantidad_trabajadores), ref fCantidad_trabajadores, value); }
        }
        int fAnyos_experiencia;
        [Persistent(@"anyos_experiencia")]
        public int Anyos_experiencia
        {
            get { return fAnyos_experiencia; }
            set { SetPropertyValue<int>(nameof(Anyos_experiencia), ref fAnyos_experiencia, value); }
        }
        string fTenencia_de_local;
        [Size(45)]
        [Persistent(@"tenencia_de_local")]
        public string Tenencia_de_local
        {
            get { return fTenencia_de_local; }
            set { SetPropertyValue<string>(nameof(Tenencia_de_local), ref fTenencia_de_local, value); }
        }
        string fDireccion_negocio;
        [Size(200)]
        [Persistent(@"direccion_negocio")]
        public string Direccion_negocio
        {
            get { return fDireccion_negocio; }
            set { SetPropertyValue<string>(nameof(Direccion_negocio), ref fDireccion_negocio, value); }
        }
        int fDB;
        public int DB
        {
            get { return fDB; }
            set { SetPropertyValue<int>(nameof(DB), ref fDB, value); }
        }
        int fDM;
        public int DM
        {
            get { return fDM; }
            set { SetPropertyValue<int>(nameof(DM), ref fDM, value); }
        }
        int fDP;
        public int DP
        {
            get { return fDP; }
            set { SetPropertyValue<int>(nameof(DP), ref fDP, value); }
        }
        string fNombre;
        [Size(200)]
        [Persistent(@"nombre")]
        public string Nombre
        {
            get { return fNombre; }
            set { SetPropertyValue<string>(nameof(Nombre), ref fNombre, value); }
        }
        string fDireccion;
        [Size(200)]
        [Persistent(@"direccion")]
        public string Direccion
        {
            get { return fDireccion; }
            set { SetPropertyValue<string>(nameof(Direccion), ref fDireccion, value); }
        }
        [Association(@"ClienteReferencesInformacio_negocio")]
        public XPCollection<Cliente> Clientes { get { return GetCollection<Cliente>(nameof(Clientes)); } }
    }

}