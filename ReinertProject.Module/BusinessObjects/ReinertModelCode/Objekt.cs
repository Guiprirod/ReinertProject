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

    public partial class Objekt
    {
        public Objekt(Session session) : base(session) { }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            Reset();

        }
        private void Reset()
        {

            fNumberProperties = null;

        }
    }

}
