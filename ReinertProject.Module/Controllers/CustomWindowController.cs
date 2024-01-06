using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReinertProject.Module.Controllers
{
    public class CustomWindowController : WindowController
    {

        public SimpleAction MyCustomAction { get; private set; }

        public CustomWindowController()
        {

            MyCustomAction = new SimpleAction(this, nameof(MyCustomAction), DevExpress.Persistent.Base.PredefinedCategory.Menu)
            {
                //Specify the Action's button caption.
                Caption = "Action",
                //Specify the confirmation message that pops up when a user executes an Action.
                ConfirmationMessage = "This is a simple action",
                //Specify the icon of the Action's button in the interface.
                ImageName = "Action_Clear"
            };


            MyCustomAction.Execute += MyCustomAction_Execute;
        }

        private void MyCustomAction_Execute(object sender, EventArgs e)
        {

        }
    }
}
