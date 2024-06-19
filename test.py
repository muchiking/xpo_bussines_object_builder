basefile=f'''
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
{{
    //#[DefaultClassOptions]
 
    
    public class Customers : XPObject
    {{ 
        //[FieldSize(FieldSizeAttribute.Unlimited)]






        public Customers(Session session)
            : base(session)
        {{
        }}
        public override void AfterConstruction()
        {{
            base.AfterConstruction();
  
        }}

    }}
}}'''
print(basefile)