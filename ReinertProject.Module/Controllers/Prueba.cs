using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Layout;
using DevExpress.ExpressApp.Model.NodeGenerators;
using DevExpress.ExpressApp.SystemModule;
using DevExpress.ExpressApp.Templates;
using DevExpress.ExpressApp.Utils;
using DevExpress.ExpressApp.Xpo;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using ReinertProject.Module.BusinessObjects.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace ReinertProject.Module.Controllers
{
    // For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppViewControllertopic.aspx.
    public partial class Prueba : ViewController
    {
        // Use CodeRush to create Controllers and Actions with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/403133/
        SimpleAction Completer;

        public Prueba()
        {
            TargetObjectType = typeof(Objekt);
            Completer = new SimpleAction(this, "Completer", PredefinedCategory.Edit);

            Completer.Execute += Complete_Execute;

            TargetViewType = ViewType.DetailView;
            TargetObjectType = typeof(Mandant);

            SimpleAction mySimpleAction = new SimpleAction(this, "MySimpleAction", "MyCategory")
            {
                Caption = "Button",
                ConfirmationMessage = "My Simple Action Shows a Message",


            };
            mySimpleAction.Execute += MySimpleAction_Execute;
            InitializeComponent();
            // Target required Views (via the TargetXXX properties) and create their Actions.
        }

        void Complete_Execute(object sender, SimpleActionExecuteEventArgs e)
        {

            var totalCost = 0.00;

            XPQuery<Reparatur> query = new XPQuery<Reparatur>((this.View.ObjectSpace as XPObjectSpace).Session);
            var list = from p in query
                       select p;

            foreach (var item in list)
            {
                totalCost += Convert.ToDouble(item.Betrag);
            }


            //var prueba = this.View.ObjectSpace.CreateCollection(typeof(Objekt));
            // var people = prueba.Count;

            // foreach (Objekt item in prueba)
            // {
            //     var personID = item.ID;
            // }
            // Console.WriteLine("Number of people:" + people);

        }
        public double GetEmployeesSimpleDataOrdered()
        {
            var totalCost = 0.00;

            XPQuery<Reparatur> query = new XPQuery<Reparatur>((this.View.ObjectSpace as XPObjectSpace).Session);
            var list = from p in query
                       select p;

            foreach (var item in list)
            {
                totalCost += Convert.ToDouble(item.Betrag);
            }
            return totalCost;
        }
        private void MySimpleAction_Execute(Object sender, SimpleActionExecuteEventArgs e)
        {
            // ...
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
