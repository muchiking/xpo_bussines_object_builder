
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
    
        
        public class CareerReveiw : XPObject
        { 
            //[FieldSize(FieldSizeAttribute.Unlimited)]
            public CareerReveiw(Session session)
                : base(session)
            {
            } 

            //public DateTime Date {get; set;}
             private string _PerformanceStatus;
        public string PerformanceStatus
        {
            get { return  _PerformanceStatus; }
            set { SetPropertyValue(nameof( PerformanceStatus), ref _PerformanceStatus, value); }
    
        }private string _GoalDescription;
        public string GoalDescription
        {
            get { return  _GoalDescription; }
            set { SetPropertyValue(nameof( GoalDescription), ref _GoalDescription, value); }
    
        }private string _FeedBack;
        public string FeedBack
        {
            get { return  _FeedBack; }
            set { SetPropertyValue(nameof( FeedBack), ref _FeedBack, value); }
    
        }private string _Report;
        public string Report
        {
            get { return  _Report; }
            set { SetPropertyValue(nameof( Report), ref _Report, value); }
    
        }
            public override void AfterConstruction()
            {
                base.AfterConstruction();
    
            }

        }
    }
