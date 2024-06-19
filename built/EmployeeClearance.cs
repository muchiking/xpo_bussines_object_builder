
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
    
        
        public class EmployeeClearance : XPObject
        { 
            //[FieldSize(FieldSizeAttribute.Unlimited)]
            public EmployeeClearance(Session session)
                : base(session)
            {
            } 
        private ClearanceStatusEnum _ClearanceStatus;
        public ClearanceStatusEnum ClearanceStatus
        {
            get { return  _ClearanceStatus; }
            set { SetPropertyValue(nameof( ClearanceStatus), ref _ClearanceStatus, value); }
    
        }

    public enum ClearanceStatusEnum
            {
             Pending,Complete
            
            }

            
             

            public override void AfterConstruction()
            {
                base.AfterConstruction();
    
            }
            //public DateTime Date {get; set;}
        }
    }