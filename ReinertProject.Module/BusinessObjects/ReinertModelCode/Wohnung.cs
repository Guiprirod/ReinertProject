﻿using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using DevExpress.Persistent.Base;
namespace ReinertProject.Module.BusinessObjects.Database
{
    [NavigationItem("Reinert")]

    public partial class Wohnung
    {
        public Wohnung(Session session) : base(session) { }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            Reset();
        }
        private void Reset()
        {
            fNumberApartaments = null;
        }

        [Action(Caption = "Enable", ConfirmationMessage = "Are you sure?", ImageName = "Check", TargetObjectsCriteria = "Vermietet=False", AutoCommit = true)]
        public void EnableVermietet()
        {
            this.Vermietet = true;
        }
        [Action(Caption = "Disable", ConfirmationMessage = "Are you sure?", ImageName = "Cancel", TargetObjectsCriteria = "Vermietet=True", AutoCommit = true)]
        public void DisabledVermietet()
        {
            this.Vermietet = false;
        }

    }


}
