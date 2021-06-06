using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace PersonalizarGridControl.credito_mauricio
{

    public partial class Prestamo
    {
        public Prestamo(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }

        public string nombreCompleto
        {
            get
            {
                return Cliente_clienteid.Nombre + " " + Cliente_clienteid.Apellido;
            }
        }
        public string esActivo
        {
            get
            {
                return Activo ==true ? "SI" : "NO";
            }
        }
    }

}
