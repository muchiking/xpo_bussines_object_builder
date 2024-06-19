
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
    
        
        public class CareerDevelopment : XPObject
        { 
            //[FieldSize(FieldSizeAttribute.Unlimited)]
            public CareerDevelopment(Session session)
                : base(session)
            {
            } 
             private string _PromotionReveiwStatus;
        public string PromotionReveiwStatus
        {
            get { return  _PromotionReveiwStatus; }
            set { SetPropertyValue(nameof( PromotionReveiwStatus), ref _PromotionReveiwStatus, value); }
    
        }private string _CurrentPay;
        public string CurrentPay
        {
            get { return  _CurrentPay; }
            set { SetPropertyValue(nameof( CurrentPay), ref _CurrentPay, value); }
    
        }private string _ExtraBenefits;
        public string ExtraBenefits
        {
            get { return  _ExtraBenefits; }
            set { SetPropertyValue(nameof( ExtraBenefits), ref _ExtraBenefits, value); }
    
        }private string _CurrentEmployeeProject;
        public string CurrentEmployeeProject
        {
            get { return  _CurrentEmployeeProject; }
            set { SetPropertyValue(nameof( CurrentEmployeeProject), ref _CurrentEmployeeProject, value); }
    
        }
            public override void AfterConstruction()
            {
                base.AfterConstruction();
    
            }

        }
    }