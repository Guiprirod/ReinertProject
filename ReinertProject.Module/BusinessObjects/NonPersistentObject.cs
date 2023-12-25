using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.ConditionalAppearance;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using ReinertProject.Module.BusinessObjects.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace ReinertProject.Module.BusinessObjects
{
    [DefaultClassOptions()]
    [DomainComponent]

    //[ImageName("BO_Unknown")]
    //[DefaultProperty("SampleProperty")]
    //[DefaultListViewOptions(MasterDetailMode.ListViewOnly, false, NewItemRowPosition.None)]
    // Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    public class NonPersistentObject:NonPersistentBaseObject  /*IXafEntityObject, INotifyPropertyChanged*/
    {
        private Reparatur precio { get; set; }
        public Reparatur Precio
        {
            get
            {
                return precio;
            }
            set { precio = value; }
        }

        public decimal repairCosts
        {
            get
            {
                if (precio != null)
                {
                    return precio.Betrag;
                }
                else
                {
                    return decimal.Zero;
                }
            }
            set { precio.Betrag = value; }
        }





        //private IObjectSpace objectSpace;
        //private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        //{
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        //}
        //private string properties;
        //[XafDisplayName("Number of properties"), ToolTip("My hint message")]
        //public string Properties
        //{
        //    get { return properties; }
        //    set{

        //        properties = "1";
        //    }
        //}

        //private string apartaments;
        //[XafDisplayName("Number of apartaments"), ToolTip("My hint message")]
        //public string Apartaments
        //{
        //    get { return apartaments; }
        //    set{

        //        apartaments = Mandant.Fields.ToString();
        //    }
        //} 
        //private string rental;
        //[XafDisplayName("Total rental income"), ToolTip("My hint message")]
        //public string Rental
        //{
        //    get { return rental; }
        //    set{

        //        rental = Mandant.Fields.ToString();

        //    }
        //}
        //private string repair;
        //[XafDisplayName("Total repair costs"), ToolTip("My hint message")]
        //public string Repair
        //{
        //    get { return repair; }
        //    set{

        //        repair = Mandant.Fields.ToString();
        //    }
        //}
        //#region IXafEntityObject members (see https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppIXafEntityObjecttopic.aspx)
        //void IXafEntityObject.OnCreated()
        //{
        //    //Place the entity initialization code here.
        //    // You can initialize reference properties using Object Space methods; e.g.:
        //    // this.Address = objectSpace.CreateObject<Address>();

        //    var prueba = objectSpace.CreateObject<Reparatur>();
        //    properties = prueba.Betrag.ToString();


        //}
        //void IXafEntityObject.OnLoaded()
        //{

        //    //Place the code that is executed each time the entity is loaded here.
        //}
        //void IXafEntityObject.OnSaving()
        //{
        //    // Place the code that is executed each time the entity is saved here.
        //}
        //#endregion

        ////#region IObjectSpaceLink members (see https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppIObjectSpaceLinktopic.aspx)
        ////// If you implement this interface, handle the NonPersistentObjectSpace.ObjectGetting event and find or create a copy of the source object in the current Object Space.
        ////// Use the Object Space to access other entities (see https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113707.aspx).
        //////IObjectSpace IObjectSpaceLink.ObjectSpace {
        //////    get { return objectSpace; }
        //////    set { objectSpace = value; }
        //////}
        ////#endregion

        //#region INotifyPropertyChanged members (see http://msdn.microsoft.com/en-us/library/system.componentmodel.inotifypropertychanged(v=vs.110).aspx)
        //public event PropertyChangedEventHandler PropertyChanged;
        //#endregion
    }
}
