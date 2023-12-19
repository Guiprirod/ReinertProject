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

    [Persistent(@"Wohnung")]
    public partial class WohnungClass : XPLiteObject
    {
        int fIDProperty;
        [Key]
        [Persistent(@"ID")]
        public int IDProperty
        {
            get { return fIDProperty; }
            set { SetPropertyValue<int>(nameof(IDProperty), ref fIDProperty, value); }
        }
        string fBezeichnungProperty;
        [Size(255)]
        [Persistent(@"Bezeichnung")]
        public string BezeichnungProperty
        {
            get { return fBezeichnungProperty; }
            set { SetPropertyValue<string>(nameof(BezeichnungProperty), ref fBezeichnungProperty, value); }
        }
        int fAnzahlSchluesselProperty;
        [Persistent(@"AnzahlSchluessel")]
        public int AnzahlSchluesselProperty
        {
            get { return fAnzahlSchluesselProperty; }
            set { SetPropertyValue<int>(nameof(AnzahlSchluesselProperty), ref fAnzahlSchluesselProperty, value); }
        }
        int fAnzahlZimmerProperty;
        [Persistent(@"AnzahlZimmer")]
        public int AnzahlZimmerProperty
        {
            get { return fAnzahlZimmerProperty; }
            set { SetPropertyValue<int>(nameof(AnzahlZimmerProperty), ref fAnzahlZimmerProperty, value); }
        }
        int fAnzahlQMProperty;
        [Persistent(@"AnzahlQM")]
        public int AnzahlQMProperty
        {
            get { return fAnzahlQMProperty; }
            set { SetPropertyValue<int>(nameof(AnzahlQMProperty), ref fAnzahlQMProperty, value); }
        }
        bool fVermietetProperty;
        [Persistent(@"Vermietet")]
        public bool VermietetProperty
        {
            get { return fVermietetProperty; }
            set { SetPropertyValue<bool>(nameof(VermietetProperty), ref fVermietetProperty, value); }
        }
        DateTime fLetzteModernisierungProperty;
        [Persistent(@"LetzteModernisierung")]
        public DateTime LetzteModernisierungProperty
        {
            get { return fLetzteModernisierungProperty; }
            set { SetPropertyValue<DateTime>(nameof(LetzteModernisierungProperty), ref fLetzteModernisierungProperty, value); }
        }
        int fObjektProperty;
        [Persistent(@"Objekt")]
        public int ObjektProperty
        {
            get { return fObjektProperty; }
            set { SetPropertyValue<int>(nameof(ObjektProperty), ref fObjektProperty, value); }
        }
    }

}