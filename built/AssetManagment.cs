
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
    
        
        public class AssetManagment : XPObject
        { 
            //[FieldSize(FieldSizeAttribute.Unlimited)]
            public AssetManagment(Session session)
                : base(session)
            {
            } 

            
             
        private string _AssetName;
        public string AssetName
        {
            get { return  _AssetName; }
            set { SetPropertyValue(nameof( AssetName), ref _AssetName, value); }
    
        }
        private string _GivingCondition;
        public string GivingCondition
        {
            get { return  _GivingCondition; }
            set { SetPropertyValue(nameof( GivingCondition), ref _GivingCondition, value); }
    
        }
        private string _ReturnCondition;
        public string ReturnCondition
        {
            get { return  _ReturnCondition; }
            set { SetPropertyValue(nameof( ReturnCondition), ref _ReturnCondition, value); }
    
        }
            public override void AfterConstruction()
            {
                base.AfterConstruction();
    
            }
            //public DateTime Date {get; set;}
        }
    }