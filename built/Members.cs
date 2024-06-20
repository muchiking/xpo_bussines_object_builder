
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
using System.Globalization;

namespace IfcSystem.Module.BusinessObjects
{
    [DefaultClassOptions]
  //[XafDisplayName("Company Information")]
  //[ImageName("BO_Address")]
        
    public class Members : XPLiteObject
    { 
        //[FieldSize(FieldSizeAttribute.Unlimited)]
        public Members(Session session)
            : base(session)
        {
        } 
        int oid;
        [Key(AutoGenerate = true), Browsable(false)]
        public int Oid
        {
            get => oid;
            set => SetPropertyValue(nameof(Oid), ref oid, value);
        }    
         
        private string _FirstName;
        public string FirstName
        {
            get { return  _FirstName; }
            set { SetPropertyValue(nameof( FirstName), ref _FirstName, value); }
    
        }
        private string _MiddleName;
        public string MiddleName
        {
            get { return  _MiddleName; }
            set { SetPropertyValue(nameof( MiddleName), ref _MiddleName, value); }
    
        }
        private string _LastName;
        public string LastName
        {
            get { return  _LastName; }
            set { SetPropertyValue(nameof( LastName), ref _LastName, value); }
    
        }
        private string _IdNo;
        public string IdNo
        {
            get { return  _IdNo; }
            set { SetPropertyValue(nameof( IdNo), ref _IdNo, value); }
    
        }
        private string _PhoneNumber;
        public string PhoneNumber
        {
            get { return  _PhoneNumber; }
            set { SetPropertyValue(nameof( PhoneNumber), ref _PhoneNumber, value); }
    
        }
        private string _EmailAddress;
        public string EmailAddress
        {
            get { return  _EmailAddress; }
            set { SetPropertyValue(nameof( EmailAddress), ref _EmailAddress, value); }
    
        }
        private string _Location;
        public string Location
        {
            get { return  _Location; }
            set { SetPropertyValue(nameof( Location), ref _Location, value); }
    
        }
        private string _Age;
        public string Age
        {
            get { return  _Age; }
            set { SetPropertyValue(nameof( Age), ref _Age, value); }
    
        }
        private string _DateRegistered;
        public string DateRegistered
        {
            get { return  _DateRegistered; }
            set { SetPropertyValue(nameof( DateRegistered), ref _DateRegistered, value); }
    
        }
        private string _IsDiscipled;
        public string IsDiscipled
        {
            get { return  _IsDiscipled; }
            set { SetPropertyValue(nameof( IsDiscipled), ref _IsDiscipled, value); }
    
        }
        private string _MaritalStatus;
        public string MaritalStatus
        {
            get { return  _MaritalStatus; }
            set { SetPropertyValue(nameof( MaritalStatus), ref _MaritalStatus, value); }
    
        }
        private string _IsBaptized;
        public string IsBaptized
        {
            get { return  _IsBaptized; }
            set { SetPropertyValue(nameof( IsBaptized), ref _IsBaptized, value); }
    
        }
        private string _IsNewBeliever;
        public string IsNewBeliever
        {
            get { return  _IsNewBeliever; }
            set { SetPropertyValue(nameof( IsNewBeliever), ref _IsNewBeliever, value); }
    
        }
        private string _Status;
        public string Status
        {
            get { return  _Status; }
            set { SetPropertyValue(nameof( Status), ref _Status, value); }
    
        }
      //public DateTime Date {get; set;}
        public override void AfterConstruction()
        {
            base.AfterConstruction();
   
        }
      
    }
}