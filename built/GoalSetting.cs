
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
    
        
        public class GoalSetting : XPObject
        { 
            //[FieldSize(FieldSizeAttribute.Unlimited)]
            public GoalSetting(Session session)
                : base(session)
            {
            } 

            
             
        private string _GoalName;
        public string GoalName
        {
            get { return  _GoalName; }
            set { SetPropertyValue(nameof( GoalName), ref _GoalName, value); }
    
        }
        private string _GoalDescription;
        public string GoalDescription
        {
            get { return  _GoalDescription; }
            set { SetPropertyValue(nameof( GoalDescription), ref _GoalDescription, value); }
    
        }
            public override void AfterConstruction()
            {
                base.AfterConstruction();
    
            }
            //public DateTime Date {get; set;}
        }
    }