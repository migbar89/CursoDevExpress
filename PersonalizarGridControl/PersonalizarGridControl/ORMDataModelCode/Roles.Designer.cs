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

    [Persistent(@"roles")]
    public partial class Roles : XPLiteObject
    {
        ulong fId;
        [Key]
        [Persistent(@"id")]
        public ulong Id
        {
            get { return fId; }
            set { SetPropertyValue<ulong>(nameof(Id), ref fId, value); }
        }
        string fName;
        [Indexed(@"Guard_name", Name = @"roles_name_guard_name_unique", Unique = true)]
        [Size(255)]
        [Persistent(@"name")]
        public string Name
        {
            get { return fName; }
            set { SetPropertyValue<string>(nameof(Name), ref fName, value); }
        }
        string fGuard_name;
        [Size(255)]
        [Persistent(@"guard_name")]
        public string Guard_name
        {
            get { return fGuard_name; }
            set { SetPropertyValue<string>(nameof(Guard_name), ref fGuard_name, value); }
        }
    }

}
