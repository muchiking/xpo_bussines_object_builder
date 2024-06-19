
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
    
        
        public class LeaveManagment : XPObject
        { 
            //[FieldSize(FieldSizeAttribute.Unlimited)]
            public LeaveManagment(Session session)
                : base(session)
            {
            } 
                   private LeaveStatusEnum _LeaveStatus;
        public LeaveStatusEnum LeaveStatus
        {
            get { return  _LeaveStatus; }
            set { SetPropertyValue(nameof( LeaveStatus), ref _LeaveStatus, value); }
    
        }
               private LeaveTypeEnum _LeaveType;
        public LeaveTypeEnum LeaveType
        {
            get { return  _LeaveType; }
            set { SetPropertyValue(nameof( LeaveType), ref _LeaveType, value); }
    
        }

  


        private Employee _Employee;
       [Association("Employee-LeaveManagment")]
        public Employee Employee
        {
            get =>_Employee;
            set => SetPropertyValue(nameof(Employee), ref _Employee, value);
        }


            
             

            public override void AfterConstruction()
            {
                base.AfterConstruction();
    
            }
            public DateTime LeaveStartDate  {get; set;}
            public DateTime LeaveEndDate {get; set;}
        }
            public enum LeaveStatusEnum
            {
             Working,OnLeave
            
            }
              public enum LeaveTypeEnum
            {
             BereavementLeave,UnpaidLeave,SickLeave,ParentalLeave,VacationLeave
            
            }
    }