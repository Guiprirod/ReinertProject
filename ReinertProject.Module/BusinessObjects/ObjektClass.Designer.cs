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
namespace ReinertProject.Module.BusinessObjects.Database
{

    [Persistent(@"Objekt")]
    public partial class ObjektClass : XPLiteObject
    {
        int fIDProperty;
        [Key]
        [Persistent(@"ID")]
        public int IDProperty
        {
            get { return fIDProperty; }
            set { SetPropertyValue<int>(nameof(IDProperty), ref fIDProperty, value); }
        }
        string fStrasseProperty;
        [Size(255)]
        [Persistent(@"Strasse")]
        public string StrasseProperty
        {
            get { return fStrasseProperty; }
            set { SetPropertyValue<string>(nameof(StrasseProperty), ref fStrasseProperty, value); }
        }
        int fHausnummerProperty;
        [Persistent(@"Hausnummer")]
        public int HausnummerProperty
        {
            get { return fHausnummerProperty; }
            set { SetPropertyValue<int>(nameof(HausnummerProperty), ref fHausnummerProperty, value); }
        }
        string fPostleitzahlProperty;
        [Size(255)]
        [Persistent(@"Postleitzahl")]
        public string PostleitzahlProperty
        {
            get { return fPostleitzahlProperty; }
            set { SetPropertyValue<string>(nameof(PostleitzahlProperty), ref fPostleitzahlProperty, value); }
        }
        string fOrtProperty;
        [Size(255)]
        [Persistent(@"Ort")]
        public string OrtProperty
        {
            get { return fOrtProperty; }
            set { SetPropertyValue<string>(nameof(OrtProperty), ref fOrtProperty, value); }
        }
        string fLandProperty;
        [Size(255)]
        [Persistent(@"Land")]
        public string LandProperty
        {
            get { return fLandProperty; }
            set { SetPropertyValue<string>(nameof(LandProperty), ref fLandProperty, value); }
        }
        int fMandantProperty;
        [Persistent(@"Mandant")]
        public int MandantProperty
        {
            get { return fMandantProperty; }
            set { SetPropertyValue<int>(nameof(MandantProperty), ref fMandantProperty, value); }
        }
    }

}