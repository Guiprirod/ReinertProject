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
    public partial class MyViewController : ViewController
    {
        public MyViewController()
        {
            TargetViewType = ViewType.DetailView;
            TargetObjectType = typeof(Mandant);

            SimpleAction mySimpleAction = new SimpleAction(this, "MySimpleAction", "MyCategory")
            {
                Caption = "Button",
                ConfirmationMessage = "My Simple Action Shows a Message",

               
            };
            mySimpleAction.Execute += MySimpleAction_Execute;
        }
        private void MySimpleAction_Execute(Object sender, SimpleActionExecuteEventArgs e)
        {
            // ...
        }

    }
}
