﻿using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using DevExpress.Persistent.Base;
using DevExpress.ExpressApp.ConditionalAppearance;
namespace ReinertProject.Module.BusinessObjects.Database
{
    [NavigationItem("Reinert")]

    public partial class Reparatur
    {
        public Reparatur(Session session) : base(session) { }
        public override void AfterConstruction() { 
            base.AfterConstruction();  
            Status = Status.ToDo;
        }
    }

}
