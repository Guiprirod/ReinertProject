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
using DevExpress.Persistent.Base;
using System.ComponentModel.DataAnnotations.Schema;
namespace ReinertProject.Module.BusinessObjects.Database
{

    public partial class Wohnung : XPLiteObject
    {
        int fID;
        [Key]
        [RuleRequiredField, RuleUniqueValue]
        [XafDisplayName("Identifier")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int ID
        {
            get { return fID; }
            set { SetPropertyValue<int>(nameof(ID), ref fID, value); }
        }
        string fBezeichnung;
        [Size(255)]
        [RuleRequiredField]

        public string Bezeichnung
        {
            get { return fBezeichnung; }
            set { SetPropertyValue<string>(nameof(Bezeichnung), ref fBezeichnung, value); }
        }
        int fAnzahlSchluessel;
        public int AnzahlSchluessel
        {
            get { return fAnzahlSchluessel; }
            set { SetPropertyValue<int>(nameof(AnzahlSchluessel), ref fAnzahlSchluessel, value); }
        }
        int fAnzahlZimmer;
        public int AnzahlZimmer
        {
            get { return fAnzahlZimmer; }
            set { SetPropertyValue<int>(nameof(AnzahlZimmer), ref fAnzahlZimmer, value); }
        }
        int fAnzahlQM;
        public int AnzahlQM
        {
            get { return fAnzahlQM; }
            set { SetPropertyValue<int>(nameof(AnzahlQM), ref fAnzahlQM, value); }
        }
        bool fVermietet;
        public bool Vermietet
        {
            get { return fVermietet; }
            set { SetPropertyValue<bool>(nameof(Vermietet), ref fVermietet, value); }
        }
        DateTime fLetzteModernisierung;
        public DateTime LetzteModernisierung
        {
            get { return fLetzteModernisierung; }
            set { SetPropertyValue<DateTime>(nameof(LetzteModernisierung), ref fLetzteModernisierung, value); }
        }
        int fObjekt;
        public int Objekt
        {
            get { return fObjekt; }
            set { SetPropertyValue<int>(nameof(Objekt), ref fObjekt, value); }
        }

        //Get all data from Wohnung
        public static XPCollection<Wohnung> GetAllData(Session session)
        {
            return new XPCollection<Wohnung>(session);
        }
        [NonPersistent]
        [NotMapped]
        string fNumberApartaments = null;
        public string? NumberApartaments
        {
            get
            {
                if (!IsLoading && !IsSaving && fNumberApartaments == null)
                {
                    CalculateNumberApartaments(false);
                }
                return fNumberApartaments;
            }
        }
        public void CalculateNumberApartaments(bool forceChangeEvents)
        {
            Session session = this.Session;
            var dataList = GetAllData(session);
            List<string> apartaments = new List<string>();

            foreach (var data in dataList)
            {
                if (!apartaments.Contains(data.Bezeichnung))
                {
                    apartaments.Add(data.Bezeichnung);
                }


            }
            
            fNumberApartaments = Convert.ToString(apartaments.Count());
            OnChanged(nameof(NumberApartaments), null, fNumberApartaments);
        }


    }

}
