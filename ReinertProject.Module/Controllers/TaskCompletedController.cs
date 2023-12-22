using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Layout;
using DevExpress.ExpressApp.Model.NodeGenerators;
using DevExpress.ExpressApp.SystemModule;
using DevExpress.ExpressApp.Templates;
using DevExpress.ExpressApp.Utils;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;
using ReinertProject.Module.BusinessObjects.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReinertProject.Module.Controllers
{
    // For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppViewControllertopic.aspx.
    public partial class TaskCompletedController : ViewController
    {
        SimpleAction Complete;
        public TaskCompletedController()
        {
            TargetObjectType = typeof(Reparatur);
            Complete = new SimpleAction(this, "Complete", PredefinedCategory.Edit);
            Complete.SelectionDependencyType = SelectionDependencyType.RequireSingleObject;
            Complete.Execute += Complete_Execute;
            InitializeComponent();
            // Target required Views (via the TargetXXX properties) and create their Actions.
        }
       void Complete_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            var currentObj = e.CurrentObject as Reparatur;
            if (currentObj != null)
            {
                currentObj.Status = Status.Completed;
            }
            if(this.ObjectSpace.IsModified)
            {
                this.ObjectSpace.CommitChanges();
            }
        }
        protected override void OnActivated()
        {
            base.OnActivated();
            // Perform various tasks depending on the target View.
        }
        protected override void OnViewControlsCreated()
        {
            base.OnViewControlsCreated();
            // Access and customize the target View control.
        }
        protected override void OnDeactivated()
        {
            // Unsubscribe from previously subscribed events and release other references and resources.
            base.OnDeactivated();
        }
    }
}
