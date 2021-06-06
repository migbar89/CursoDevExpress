using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace PersonalizarGridControl.credito_mauricio
{

    public partial class Mora
    {
        public Mora(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
