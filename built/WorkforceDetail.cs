
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
    
        
        public class WorkforceDetail : XPObject
        { 
            //[FieldSize(FieldSizeAttribute.Unlimited)]
            public WorkforceDetail(Session session)
                : base(session)
            {
            } 

            
             
        private string _OrientationStatus;
        public string OrientationStatus
        {
            get { return  _OrientationStatus; }
            set { SetPropertyValue(nameof( OrientationStatus), ref _OrientationStatus, value); }
    
        }
            public override void AfterConstruction()
            {
                base.AfterConstruction();
    
            }
            //public DateTime Date {get; set;}
        }
    }