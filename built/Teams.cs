
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

namespace IFC.Module.BusinessObjects
{
    [DefaultClassOptions]
  //[XafDisplayName("Company Information")]
  //[ImageName("BO_Address")]
  //[Appearance("lockDetails church information", TargetItems = "*;LockDetails", Criteria = "LockDetails = 'True'", Enabled = false)]
        
    public class Teams : XPLiteObject
    { 
        //[FieldSize(FieldSizeAttribute.Unlimited)]
        public Teams(Session session)
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
         
        private string _teamName;
        [XafDisplayName("TeamName")]
        //[RuleRequiredField("", DefaultContexts.Save, "Company Telephone Is Mandatory Please Specify !")]
        //[VisibleInDetailView(false)]
        //[VisibleInListView(false)]
        //[VisibleInLookupListView(false)]  
        //[ImmediatePostData()]      
        public string TeamName
        {
            get { return  _teamName; }
            set { SetPropertyValue(nameof(TeamName), ref _teamName, value); }
    
        }
        
        private string _code;
        [XafDisplayName("Code")]
        //[RuleRequiredField("", DefaultContexts.Save, "Company Telephone Is Mandatory Please Specify !")]
        //[VisibleInDetailView(false)]
        //[VisibleInListView(false)]
        //[VisibleInLookupListView(false)]  
        //[ImmediatePostData()]      
        public string Code
        {
            get { return  _code; }
            set { SetPropertyValue(nameof(Code), ref _code, value); }
    
        }
        
        private string _isActive;
        [XafDisplayName("IsActive")]
        //[RuleRequiredField("", DefaultContexts.Save, "Company Telephone Is Mandatory Please Specify !")]
        //[VisibleInDetailView(false)]
        //[VisibleInListView(false)]
        //[VisibleInLookupListView(false)]  
        //[ImmediatePostData()]      
        public string IsActive
        {
            get { return  _isActive; }
            set { SetPropertyValue(nameof(IsActive), ref _isActive, value); }
    
        }
        

        private string _created_by;
        [XafDisplayName("Created By")]
        //[VisibleInDetailView(false)]
        [VisibleInListView(false)]
        [VisibleInLookupListView(false)]
        public string created_by
        {
            get {  return _created_by; }
            set { SetPropertyValue<string>(nameof(created_by), ref _created_by, value); }
        }
        private DateTime _created_on;
        [XafDisplayName("Created On")]
        [ModelDefault("DisplayFormat", "{0: dd-MMM-yyyy}")]
        [ModelDefault("EditMask", "dd-MMM-yyyy")]
        //[VisibleInDetailView(false)]
        [VisibleInListView(false)]
        [VisibleInLookupListView(false)]
        public DateTime created_on
        {
            get { return _created_on; }
            set { SetPropertyValue<DateTime>(nameof(created_on), ref _created_on, value); }
        }
        private string _altered_by;
        [XafDisplayName("Altered By")]
        //[VisibleInDetailView(false)]
        [VisibleInListView(false)]
        [VisibleInLookupListView(false)]
        public string altered_by
        {
            get {  return _altered_by; }
            set { SetPropertyValue<string>(nameof(altered_by), ref _altered_by, value); }
        }
        private DateTime _date_altered;
        [XafDisplayName("Altered On")]
        [ModelDefault("DisplayFormat", "{0: dd-MMM-yyyy}")]
        [ModelDefault("EditMask", "dd-MMM-yyyy")]
        //[VisibleInDetailView(false)]
        [VisibleInListView(false)]
        [VisibleInLookupListView(false)]
        public DateTime date_altered
        {
            get { return _date_altered; }
            set { SetPropertyValue<DateTime>(nameof(date_altered), ref _date_altered, value); }
        }
        //public DateTime Date {get; set;}

        protected override void OnSaving()
        {
            base.OnSaving();

            if (Session.IsNewObject(this))
            {
                created_by = SecuritySystem.CurrentUserName; 
                created_on = DateTime.Now;
            }
            else
            {
                date_altered = DateTime.Now;
                //altered_by = SystemMessaging.CleanString(SecuritySystem.CurrentUserName);
                altered_by = SecuritySystem.CurrentUserName;
            }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
   
        }

      
    }
}