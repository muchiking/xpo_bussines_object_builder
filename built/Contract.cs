
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
    
        
        public class Contract : XPObject
        { 
            //[FieldSize(FieldSizeAttribute.Unlimited)]
            public Contract(Session session)
                : base(session)
            {
            } 

            
             
        private string _ContractType;
        public string ContractType
        {
            get { return  _ContractType; }
            set { SetPropertyValue(nameof( ContractType), ref _ContractType, value); }
    
        }
        private string _ContractStartDate;
        public string ContractStartDate
        {
            get { return  _ContractStartDate; }
            set { SetPropertyValue(nameof( ContractStartDate), ref _ContractStartDate, value); }
    
        }
        private string _ContractEndDate;
        public string ContractEndDate
        {
            get { return  _ContractEndDate; }
            set { SetPropertyValue(nameof( ContractEndDate), ref _ContractEndDate, value); }
    
        }
         private Employee _Employee;
       [Association("Employee-Contract")]
        public Employee Employee
        {
            get =>_Employee;
            set => SetPropertyValue(nameof(Employee), ref _Employee, value);
        }
            public override void AfterConstruction()
            {
                base.AfterConstruction();
    
            }
            //public DateTime Date {get; set;}
        }
    }