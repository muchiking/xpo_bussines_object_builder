
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
    
        
        public class EmegencyContact : XPObject
        { 
            //[FieldSize(FieldSizeAttribute.Unlimited)]
            public EmegencyContact(Session session)
                : base(session)
            {
            } 

            
             
        private string _FirstNextofkin;
        public string FirstNextofkin
        {
            get { return  _FirstNextofkin; }
            set { SetPropertyValue(nameof( FirstNextofkin), ref _FirstNextofkin, value); }
    
        }
        private string _PhoneNo;
        public string PhoneNo
        {
            get { return  _PhoneNo; }
            set { SetPropertyValue(nameof( PhoneNo), ref _PhoneNo, value); }
    
        }
        private string _Email;
        public string Email
        {
            get { return  _Email; }
            set { SetPropertyValue(nameof( Email), ref _Email, value); }
    
        }
        private string _PhysicalAddress;
        public string PhysicalAddress
        {
            get { return  _PhysicalAddress; }
            set { SetPropertyValue(nameof( PhysicalAddress), ref _PhysicalAddress, value); }
    
        }
        private string _POBox;
        public string POBox
        {
            get { return  _POBox; }
            set { SetPropertyValue(nameof( POBox), ref _POBox, value); }
    
        }
        private string _Relationship;
        public string Relationship
        {
            get { return  _Relationship; }
            set { SetPropertyValue(nameof( Relationship), ref _Relationship, value); }
    
        }
            public override void AfterConstruction()
            {
                base.AfterConstruction();
    
            }
            //public DateTime Date {get; set;}
        }
    }