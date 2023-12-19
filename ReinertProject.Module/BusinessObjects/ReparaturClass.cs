using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace ReinertProject.Module.BusinessObjects.Database
{

    public partial class ReparaturClass
    {
        public ReparaturClass(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
