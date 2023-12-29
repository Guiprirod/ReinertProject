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
using DevExpress.ExpressApp.ConditionalAppearance;
using System.ComponentModel.DataAnnotations.Schema;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
using DevExpress.XtraRichEdit.API.Layout;
namespace ReinertProject.Module.BusinessObjects.Database
{

    public partial class Reparatur : XPLiteObject
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
       
        string fBezeichnung;
        [RuleRequiredField]

        [Size(255)]
        public string Bezeichnung
        {
            get { return fBezeichnung; }
            set { SetPropertyValue<string>(nameof(Bezeichnung), ref fBezeichnung, value); }
        }
        DateTime fDatum;
        [RuleRequiredField]

        public DateTime Datum
        {
            get { return fDatum; }
            set { SetPropertyValue<DateTime>(nameof(Datum), ref fDatum, value); }
        }
        int fWohnung;
        public int Wohnung
        {
            get { return fWohnung; }
            set { SetPropertyValue<int>(nameof(Wohnung), ref fWohnung, value); }
        }

        Status fstatus;
        public Status Status
        {
            get => fstatus;
            set => SetPropertyValue(nameof(Status), ref fstatus, value);
        }

        decimal fBetrag;
        [RuleRequiredField]

        public decimal Betrag
        {
            get { return fBetrag; }
            set { SetPropertyValue<decimal>(nameof(Betrag), ref fBetrag, value); }
        }

        //Get all data from Reparatur
        public static XPCollection<Reparatur> GetAllData(Session session)
        {
            return new XPCollection<Reparatur>(session);
        }


        [NonPersistent]
        private decimal? fTotalCosts = null;
        public decimal? TotalCosts
        {
            get
            {
                if (!IsLoading && !IsSaving && fTotalCosts == null)
                {
                    UpdateTotalCosts(false);
                }
                return fTotalCosts;
            }
        }


        public void UpdateTotalCosts(bool forceChangeEvents)
        {
            Session session = this.Session;

            decimal? oldOrdersTotal = fTotalCosts;
            decimal tempTotal = 0;

            var dataList = GetAllData(session);
            foreach (Reparatur detail in dataList)
                tempTotal += detail.fBetrag;
            fTotalCosts = tempTotal;
            OnChanged(nameof(TotalCosts), oldOrdersTotal, fTotalCosts);
        }

    }

    public enum Status
    {
        ToDo = 0,
        InProgress = 1,
        Completed = 2,
        Error = 3

    }

}
