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
namespace PersonalizarGridControl.credito_mauricio
{

    [Persistent(@"cliente")]
    public partial class Cliente : XPLiteObject
    {
        int fClienteid;
        [Key(true)]
        [Persistent(@"clienteid")]
        public int Clienteid
        {
            get { return fClienteid; }
            set { SetPropertyValue<int>(nameof(Clienteid), ref fClienteid, value); }
        }
        string fNombre;
        [Size(45)]
        [Persistent(@"nombre")]
        public string Nombre
        {
            get { return fNombre; }
            set { SetPropertyValue<string>(nameof(Nombre), ref fNombre, value); }
        }
        string fApellido;
        [Size(45)]
        [Persistent(@"apellido")]
        public string Apellido
        {
            get { return fApellido; }
            set { SetPropertyValue<string>(nameof(Apellido), ref fApellido, value); }
        }
        string fCedula;
        [Size(20)]
        [Persistent(@"cedula")]
        public string Cedula
        {
            get { return fCedula; }
            set { SetPropertyValue<string>(nameof(Cedula), ref fCedula, value); }
        }
        string fTelefono;
        [Size(11)]
        [Persistent(@"telefono")]
        public string Telefono
        {
            get { return fTelefono; }
            set { SetPropertyValue<string>(nameof(Telefono), ref fTelefono, value); }
        }
        string fDireccion;
        [Size(200)]
        [Persistent(@"direccion")]
        public string Direccion
        {
            get { return fDireccion; }
            set { SetPropertyValue<string>(nameof(Direccion), ref fDireccion, value); }
        }
        int fOrden;
        [Persistent(@"orden")]
        public int Orden
        {
            get { return fOrden; }
            set { SetPropertyValue<int>(nameof(Orden), ref fOrden, value); }
        }
        string fCorreo;
        [Size(200)]
        [Persistent(@"correo")]
        public string Correo
        {
            get { return fCorreo; }
            set { SetPropertyValue<string>(nameof(Correo), ref fCorreo, value); }
        }
        Informacio_negocio fIdnegocio;
        [Persistent(@"idnegocio")]
        [Association(@"ClienteReferencesInformacio_negocio")]
        public Informacio_negocio Idnegocio
        {
            get { return fIdnegocio; }
            set { SetPropertyValue<Informacio_negocio>(nameof(Idnegocio), ref fIdnegocio, value); }
        }
        [Association(@"PrestamoReferencesCliente")]
        public XPCollection<Prestamo> Prestamoes { get { return GetCollection<Prestamo>(nameof(Prestamoes)); } }
        [Association(@"ReferenciasReferencesCliente")]
        public XPCollection<Referencias> ReferenciasCollection { get { return GetCollection<Referencias>(nameof(ReferenciasCollection)); } }
        [Association(@"TelefonoReferencesCliente")]
        public XPCollection<Telefono> Telefonoes { get { return GetCollection<Telefono>(nameof(Telefonoes)); } }
    }

}
