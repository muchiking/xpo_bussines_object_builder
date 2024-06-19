
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

    namespace HRM.Module.BusinessObjects
    {
        [DefaultClassOptions]
    
        
        public class OutPost : XPObject
        { 
            //[FieldSize(FieldSizeAttribute.Unlimited)]
            public OutPost(Session session)
                : base(session)
            {
            } 

            
             
        private string _OutstationName;
        public string OutstationName
        {
            get { return  _OutstationName; }
            set { SetPropertyValue(nameof( OutstationName), ref _OutstationName, value); }
    
        }
        private string _Location;
        public string Location
        {
            get { return  _Location; }
            set { SetPropertyValue(nameof( Location), ref _Location, value); }
    
        }
            public override void AfterConstruction()
            {
                base.AfterConstruction();
    
            }
            //public DateTime Date {get; set;}
        }
    }