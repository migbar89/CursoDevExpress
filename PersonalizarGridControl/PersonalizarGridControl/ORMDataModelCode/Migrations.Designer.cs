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

    [Persistent(@"migrations")]
    public partial class Migrations : XPLiteObject
    {
        uint fId;
        [Key]
        [Persistent(@"id")]
        public uint Id
        {
            get { return fId; }
            set { SetPropertyValue<uint>(nameof(Id), ref fId, value); }
        }
        string fMigration;
        [Size(255)]
        [Persistent(@"migration")]
        public string Migration
        {
            get { return fMigration; }
            set { SetPropertyValue<string>(nameof(Migration), ref fMigration, value); }
        }
        int fBatch;
        [Persistent(@"batch")]
        public int Batch
        {
            get { return fBatch; }
            set { SetPropertyValue<int>(nameof(Batch), ref fBatch, value); }
        }
    }

}