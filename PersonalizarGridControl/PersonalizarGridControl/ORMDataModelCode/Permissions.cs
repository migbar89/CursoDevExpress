using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace PersonalizarGridControl.credito_mauricio
{

    public partial class Permissions
    {
        public Permissions(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
