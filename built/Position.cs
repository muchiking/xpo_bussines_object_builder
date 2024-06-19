
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
    
        
        public class Position : XPObject
        { 
            //[FieldSize(FieldSizeAttribute.Unlimited)]
            public Position(Session session)
                : base(session)
            {
            } 

            //public DateTime Date {get; set;}
             private string _PositionName;
        public string PositionName
        {
            get { return  _PositionName; }
            set { SetPropertyValue(nameof( PositionName), ref _PositionName, value); }
    
        }
            public override void AfterConstruction()
            {
                base.AfterConstruction();
    
            }

        }
    }