
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
    
        
        public class SkillInventory : XPObject
        { 
            //[FieldSize(FieldSizeAttribute.Unlimited)]
            public SkillInventory(Session session)
                : base(session)
            {
            } 

            
             
        private string _SkillName;
        public string SkillName
        {
            get { return  _SkillName; }
            set { SetPropertyValue(nameof( SkillName), ref _SkillName, value); }
    
        }
        private Employee _Employee;
       [Association("Employee-SkillInventory")]
        public Employee Employee
        {
            get =>_Employee;
            set => SetPropertyValue(nameof(Employee), ref _Employee, value);
        }
        private Position _Position;
       [Association("Position-SkillInventory")]
        public Position Position
        {
            get =>_Position;
            set => SetPropertyValue(nameof(Position), ref _Position, value);
        }
        private Department _Department;
       [Association("Department-SkillInventory")]
        public Department Department
        {
            get =>_Department;
            set => SetPropertyValue(nameof(Department), ref _Department, value);
        }

        private EmployeeTraining _EmployeeTraining;
       [Association("EmployeeTraining-SkillInventory")]
        public EmployeeTraining EmployeeTraining
        {
            get =>_EmployeeTraining;
            set => SetPropertyValue(nameof(EmployeeTraining), ref _EmployeeTraining, value);
        }
                private OutPost _OutPost;
       [Association("OutPost-SkillInventory")]
        public OutPost OutPost
        {
            get =>_OutPost;
            set => SetPropertyValue(nameof(OutPost), ref _OutPost, value);
        }



            public override void AfterConstruction()
            {
                base.AfterConstruction();
    
            }
            //public DateTime Date {get; set;}
        }
    }