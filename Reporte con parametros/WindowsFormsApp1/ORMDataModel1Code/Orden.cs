﻿using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace WindowsFormsApp1.facturacion
{

    public partial class Orden
    {
        public Orden(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
