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
using DevExpress.Persistent.Validation;
using DevExpress.ExpressApp.DC;
namespace ReinertProject.Module.BusinessObjects.Database
{

    public partial class Objekt : XPLiteObject
    {
        int fID;
        [Key]
        [RuleRequiredField, RuleUniqueValue]
        [XafDisplayName("Identifier")]


        public int ID
        {
            get { return fID; }
            set { SetPropertyValue<int>(nameof(ID), ref fID, value); }
        }
        string fStrasse;
        [Size(255)]
        [RuleRequiredField]

        public string Strasse
        {
            get { return fStrasse; }
            set { SetPropertyValue<string>(nameof(Strasse), ref fStrasse, value); }
        }
        int fHausnummer;
        public int Hausnummer
        {
            get { return fHausnummer; }
            set { SetPropertyValue<int>(nameof(Hausnummer), ref fHausnummer, value); }
        }
        string fPostleitzahl;
        [Size(255)]
        public string Postleitzahl
        {
            get { return fPostleitzahl; }
            set { SetPropertyValue<string>(nameof(Postleitzahl), ref fPostleitzahl, value); }
        }
        string fOrt;
        [Size(255)]
        [RuleRequiredField]

        public string Ort
        {
            get { return fOrt; }
            set { SetPropertyValue<string>(nameof(Ort), ref fOrt, value); }
        }
        string fLand;
        [Size(255)]
        [RuleRequiredField]

        public string Land
        {
            get { return fLand; }
            set { SetPropertyValue<string>(nameof(Land), ref fLand, value); }
        }
        int fMandant;
        public int Mandant
        {
            get { return fMandant; }
            set { SetPropertyValue<int>(nameof(Mandant), ref fMandant, value); }
        }
    }

}
