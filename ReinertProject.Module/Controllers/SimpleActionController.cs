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
    public partial class SimpleActionController : ViewController
    {
        // Use CodeRush to create Controllers and Actions with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/403133/
        public SimpleActionController()
        {
            InitializeComponent();
            //Activate the Controller only in the Detail View
            TargetViewType = ViewType.DetailView;


            //Specify the type of objects that can use the Controller, If you do not specify the TargetObjectType property, the application displays the controller’s actions for all Detail Views.
            //TargetObjectType = typeof(Mandant);


            //ADD A POP
            SimpleAction SimpleAction = new SimpleAction(this, "Simpleaction", PredefinedCategory.View)
            {
                //Specify the Action's button caption.
                Caption = "Simple action",
                //Specify the confirmation message that pops up when a user executes an Action.
                ConfirmationMessage = "This is a simple action",
                //Specify the icon of the Action's button in the interface.
                ImageName = "Action_Clear"
            };
            SimpleAction.Execute += SimpleAction_Execute;
        }
        private void SimpleAction_Execute(Object sender, SimpleActionExecuteEventArgs e)
        {
           //
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
