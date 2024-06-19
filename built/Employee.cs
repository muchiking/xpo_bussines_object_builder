
    using DevExpress.CodeParser;
    using DevExpress.Data.Filtering;
    using DevExpress.ExpressApp;
    using DevExpress.ExpressApp.DC;
    using DevExpress.ExpressApp.Model;
    using DevExpress.Persistent.Base;
    using DevExpress.Persistent.BaseImpl;
    using DevExpress.Persistent.Validation;
    using DevExpress.Xpo;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;
    using System.Text;

    namespace projname.Module.BusinessObjects
    {
        //#[DefaultClassOptions]
    
        
        public class Employee : XPObject
        { 
            //[FieldSize(FieldSizeAttribute.Unlimited)]
            public Employee(Session session)
                : base(session)
            {
            } 
             private string _Name;
        public string Name
        {
            get { return  _Name; }
            set { SetPropertyValue(nameof( Name), ref _Name, value); }
    
        }private string _FirstName;
        public string FirstName
        {
            get { return  _FirstName; }
            set { SetPropertyValue(nameof( FirstName), ref _FirstName, value); }
    
        }private string _LastName;
        public string LastName
        {
            get { return  _LastName; }
            set { SetPropertyValue(nameof( LastName), ref _LastName, value); }
    
        }private string _Email;
        public string Email
        {
            get { return  _Email; }
            set { SetPropertyValue(nameof( Email), ref _Email, value); }
    
        }private string _Phone;
        public string Phone
        {
            get { return  _Phone; }
            set { SetPropertyValue(nameof( Phone), ref _Phone, value); }
    
        }private string _Address;
        public string Address
        {
            get { return  _Address; }
            set { SetPropertyValue(nameof( Address), ref _Address, value); }
    
        }
            public override void AfterConstruction()
            {
                base.AfterConstruction();
    
            }

        }
    }