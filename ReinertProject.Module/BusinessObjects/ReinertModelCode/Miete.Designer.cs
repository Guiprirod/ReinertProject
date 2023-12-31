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

    public partial class Miete : XPLiteObject
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

        decimal fBetrag;
        [RuleRequiredField]

        public decimal Betrag
        {
            get { return fBetrag; }
            set { SetPropertyValue<decimal>(nameof(Betrag), ref fBetrag, value); }
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

        //Save all data from Miete
        public static XPCollection<Miete> GetAllData(Session session)
        {
            return new XPCollection<Miete>(session);
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
            foreach (Miete detail in dataList)
                tempTotal += detail.fBetrag;
            fTotalCosts = tempTotal;
            OnChanged(nameof(TotalCosts), oldOrdersTotal, fTotalCosts);
        }


    }

}
