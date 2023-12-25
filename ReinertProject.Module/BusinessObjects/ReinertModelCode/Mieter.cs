using System;
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

    public partial class Mieter
    {
        public Mieter(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }

        [Action(Caption = "Enable", ConfirmationMessage = "Are you sure?", ImageName = "Check", TargetObjectsCriteria = "Probleme=False", AutoCommit = true)]

        public void EnableVermietet()
        {
            this.Probleme = true;
        }
        [Action(Caption = "Disable", ConfirmationMessage = "Are you sure?", ImageName = "Cancel", TargetObjectsCriteria = "Probleme=True", AutoCommit = true)]
        public void DisabledVermietet()
        {
            this.Probleme = false;
        }                                               
    }

}
