
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
        [DefaultClassOptions]
    
        
        public class Manager : XPObject
        { 
            //[FieldSize(FieldSizeAttribute.Unlimited)]
            public Manager(Session session)
                : base(session)
            {
            } 

            //public DateTime Date {get; set;}
             private string _ManagerName;
        public string ManagerName
        {
            get { return  _ManagerName; }
            set { SetPropertyValue(nameof( ManagerName), ref _ManagerName, value); }
    
        }
            public override void AfterConstruction()
            {
                base.AfterConstruction();
    
            }

        }
    }