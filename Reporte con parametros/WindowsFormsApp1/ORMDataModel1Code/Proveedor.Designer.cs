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

    [Persistent(@"proveedor")]
    public partial class Proveedor : XPLiteObject
    {
        int fIdProveedor;
        [Key(true)]
        [Persistent(@"idProveedor")]
        public int IdProveedor
        {
            get { return fIdProveedor; }
            set { SetPropertyValue<int>(nameof(IdProveedor), ref fIdProveedor, value); }
        }
        int fIdMunicipio;
        [Persistent(@"idMunicipio")]
        public int IdMunicipio
        {
            get { return fIdMunicipio; }
            set { SetPropertyValue<int>(nameof(IdMunicipio), ref fIdMunicipio, value); }
        }
        string fCedula;
        [Indexed(Name = @"cedula", Unique = true)]
        [Size(20)]
        [Persistent(@"cedula")]
        public string Cedula
        {
            get { return fCedula; }
            set { SetPropertyValue<string>(nameof(Cedula), ref fCedula, value); }
        }
        string fNombres;
        [Persistent(@"nombres")]
        public string Nombres
        {
            get { return fNombres; }
            set { SetPropertyValue<string>(nameof(Nombres), ref fNombres, value); }
        }
        string fApellidos;
        [Persistent(@"apellidos")]
        public string Apellidos
        {
            get { return fApellidos; }
            set { SetPropertyValue<string>(nameof(Apellidos), ref fApellidos, value); }
        }
        char fIdSexo;
        [Persistent(@"idSexo")]
        public char IdSexo
        {
            get { return fIdSexo; }
            set { SetPropertyValue<char>(nameof(IdSexo), ref fIdSexo, value); }
        }
        sbyte fIdEstadoCivil;
        [Persistent(@"idEstadoCivil")]
        public sbyte IdEstadoCivil
        {
            get { return fIdEstadoCivil; }
            set { SetPropertyValue<sbyte>(nameof(IdEstadoCivil), ref fIdEstadoCivil, value); }
        }
        DateTime fFechaNacimiento;
        [Persistent(@"fechaNacimiento")]
        public DateTime FechaNacimiento
        {
            get { return fFechaNacimiento; }
            set { SetPropertyValue<DateTime>(nameof(FechaNacimiento), ref fFechaNacimiento, value); }
        }
        string fTelefono;
        [Size(20)]
        [Persistent(@"telefono")]
        public string Telefono
        {
            get { return fTelefono; }
            set { SetPropertyValue<string>(nameof(Telefono), ref fTelefono, value); }
        }
        string fCelular;
        [Size(20)]
        [Persistent(@"celular")]
        public string Celular
        {
            get { return fCelular; }
            set { SetPropertyValue<string>(nameof(Celular), ref fCelular, value); }
        }
        string fDireccion;
        [Persistent(@"direccion")]
        public string Direccion
        {
            get { return fDireccion; }
            set { SetPropertyValue<string>(nameof(Direccion), ref fDireccion, value); }
        }
        string fEmail;
        [Persistent(@"email")]
        public string Email
        {
            get { return fEmail; }
            set { SetPropertyValue<string>(nameof(Email), ref fEmail, value); }
        }
    }

}
