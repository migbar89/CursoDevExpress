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

    [Persistent(@"mora")]
    public partial class Mora : XPLiteObject
    {
        int fIdmora;
        [Key(true)]
        [Persistent(@"idmora")]
        public int Idmora
        {
            get { return fIdmora; }
            set { SetPropertyValue<int>(nameof(Idmora), ref fIdmora, value); }
        }
        double fMonto;
        [Persistent(@"monto")]
        public double Monto
        {
            get { return fMonto; }
            set { SetPropertyValue<double>(nameof(Monto), ref fMonto, value); }
        }
        DateTime fFecha;
        [Persistent(@"fecha")]
        public DateTime Fecha
        {
            get { return fFecha; }
            set { SetPropertyValue<DateTime>(nameof(Fecha), ref fFecha, value); }
        }
        Prestamo fIdprestamo;
        [Persistent(@"idprestamo")]
        [Association(@"MoraReferencesPrestamo")]
        public Prestamo Idprestamo
        {
            get { return fIdprestamo; }
            set { SetPropertyValue<Prestamo>(nameof(Idprestamo), ref fIdprestamo, value); }
        }
        double fSaldo;
        [Persistent(@"saldo")]
        public double Saldo
        {
            get { return fSaldo; }
            set { SetPropertyValue<double>(nameof(Saldo), ref fSaldo, value); }
        }
    }

}
