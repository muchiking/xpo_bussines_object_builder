
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
    
        
        public class EmployeeTraining : XPObject
        { 
            //[FieldSize(FieldSizeAttribute.Unlimited)]
            public EmployeeTraining(Session session)
                : base(session)
            {
            } 
        private Employee _Employee;
        [Association("Employee-EmployeeTraining")]
        public Employee Employee
        {
            get =>_Employee;
            set => SetPropertyValue(nameof(Employee), ref _Employee, value);
        }
        private Department _Department;
       [Association("Department-EmployeeTraining")]
        public Department Department
        {
            get =>_Department;
            set => SetPropertyValue(nameof(Department), ref _Department, value);
        }

        private OutPost _OutPost;
       [Association("OutPost-EmployeeTraining")]
        public OutPost OutPost
        {
            get =>_OutPost;
            set => SetPropertyValue(nameof(OutPost), ref _OutPost, value);
        }

        private string _TrainingFeedBack;
        public string TrainingFeedBack
        {
            get { return  _TrainingFeedBack; }
            set { SetPropertyValue(nameof( TrainingFeedBack), ref _TrainingFeedBack, value); }
    
        }
        private string _TrainingName;
        public string TrainingName
        {
            get { return  _TrainingName; }
            set { SetPropertyValue(nameof( TrainingName), ref _TrainingName, value); }
    
        }
        private string _TrainingType;
        public string TrainingType
        {
            get { return  _TrainingType; }
            set { SetPropertyValue(nameof( TrainingType), ref _TrainingType, value); }
    
        }
        private string _Location;
        public string Location
        {
            get { return  _Location; }
            set { SetPropertyValue(nameof( Location), ref _Location, value); }
    
        }
            public override void AfterConstruction()
            {
                base.AfterConstruction();
    
            }
        private TrainingTypeEnum _TrainingType;
        public TrainingTypeEnum TrainingType
        {
            get { return  _TrainingType; }
            set { SetPropertyValue(nameof( TrainingType), ref _TrainingType, value); }
    
        }

    public enum TrainingTypeEnum
            {
             Managerial,Technical
            
            }
            
            public DateTime TrainingStartDate {get; set;}
            public DateTime TrainingEndDate {get; set;}

        }
    }