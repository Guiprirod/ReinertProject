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

    public partial class Mieter : XPLiteObject
    {
        int fID;
        [Key]
        public int ID
        {
            get { return fID; }
            set { SetPropertyValue<int>(nameof(ID), ref fID, value); }
        }
        string fName;
        [Size(255)]
        public string Name
        {
            get { return fName; }
            set { SetPropertyValue<string>(nameof(Name), ref fName, value); }
        }
        string fVorname;
        [Size(255)]
        public string Vorname
        {
            get { return fVorname; }
            set { SetPropertyValue<string>(nameof(Vorname), ref fVorname, value); }
        }
        string fPersoNummer;
        [Size(255)]
        public string PersoNummer
        {
            get { return fPersoNummer; }
            set { SetPropertyValue<string>(nameof(PersoNummer), ref fPersoNummer, value); }
        }
        bool fProbleme;
        public bool Probleme
        {
            get { return fProbleme; }
            set { SetPropertyValue<bool>(nameof(Probleme), ref fProbleme, value); }
        }
        DateTime fMieterSeit;
        public DateTime MieterSeit
        {
            get { return fMieterSeit; }
            set { SetPropertyValue<DateTime>(nameof(MieterSeit), ref fMieterSeit, value); }
        }
    }

}
