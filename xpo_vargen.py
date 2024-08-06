import os
# def datetime(obj):
#     string=""
#     for entry in obj:
#         string+=f'public DateTime {entry} {{get; set;}}'
    

def format_word(word):
    formatted_word = "_" + word[0].lower() + word[1:]

    return formatted_word

def print_entries_in_both_cases(arr):
    string=" "
    for entry in arr:
        #print(f"Uppercase: {entry.upper()}, Lowercase: {entry.lower()}")
        variablename=(format_word(entry))
        functionname=entry
        list= f"""
        private string {variablename};
        [XafDisplayName("{entry}")]
        //[RuleRequiredField("", DefaultContexts.Save, "{entry} Is Mandatory Please Specify !")]
        //[Appearance("", Visibility = ViewItemVisibility.Hide, Criteria = "!IsNullOrEmpty(client_type) && ![client_type.isIndividual]")]
        //[VisibleInDetailView(false)]
        //[VisibleInListView(false)]
        //[VisibleInLookupListView(false)]  
        //[ImmediatePostData()]      
        public string {entry}
        {{
            get {{ return  {variablename}; }}
            set {{ SetPropertyValue(nameof({entry}), ref {variablename}, value); }}
    
        }}
        """
        string+=list

    return (string)


    #print(f"Formatted word: {formatted_word}")

if __name__ == "__main__":
    my_array =   [
    "TeamName",
    "Code",
    "IsActive"         
]
    vars = print_entries_in_both_cases(my_array)
    # print(vars)
    classname="Teams"
    project="IFSys"


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
using System.Globalization;

namespace { project}.Module.BusinessObjects
{{
    [DefaultClassOptions]
  //[XafDisplayName("Company Information")]
  //[ImageName("BO_Address")]
  //[Appearance("lockDetails  information", TargetItems = "*;LockDetails", Criteria = "LockDetails = 'True'", Enabled = false)]
        
    public class {classname} : XPLiteObject
    {{ 
        //[FieldSize(FieldSizeAttribute.Unlimited)]
        public {classname}(Session session)
            : base(session)
        {{
        }} 
        int oid;
        [Key(AutoGenerate = true), Browsable(false)]
        public int Oid
        {{
            get => oid;
            set => SetPropertyValue(nameof(Oid), ref oid, value);
        }}  
        {vars}

        private string _created_by;
        [XafDisplayName("Created By")]
        [ModelDefault("AllowEdit", "false")]
        //[VisibleInDetailView(false)]
        [VisibleInListView(false)]
        [VisibleInLookupListView(false)]
        public string created_by
        {{
            get {{  return _created_by; }}
            set {{ SetPropertyValue<string>(nameof(created_by), ref _created_by, value); }}
        }}
        private DateTime _created_on;
        [XafDisplayName("Created On")]
        [ModelDefault("AllowEdit", "false")]
        [ModelDefault("DisplayFormat", "{{0: dd-MMM-yyyy}}")]
        [ModelDefault("EditMask", "dd-MMM-yyyy")]
        //[VisibleInDetailView(false)]
        [VisibleInListView(false)]
        [VisibleInLookupListView(false)]
        public DateTime created_on
        {{
            get {{ return _created_on; }}
            set {{ SetPropertyValue<DateTime>(nameof(created_on), ref _created_on, value); }}
        }}
        private string _altered_by;
        [XafDisplayName("Altered By")]
        [ModelDefault("AllowEdit", "false")]
        //[VisibleInDetailView(false)]
        [VisibleInListView(false)]
        [VisibleInLookupListView(false)]
        public string altered_by
        {{
            get {{  return _altered_by; }}
            set {{ SetPropertyValue<string>(nameof(altered_by), ref _altered_by, value); }}
        }}
        private DateTime _date_altered;
        [XafDisplayName("Altered On")]
        [ModelDefault("AllowEdit", "false")]
        [ModelDefault("DisplayFormat", "{{0: dd-MMM-yyyy}}")]
        [ModelDefault("EditMask", "dd-MMM-yyyy")]
        //[VisibleInDetailView(false)]
        [VisibleInListView(false)]
        [VisibleInLookupListView(false)]
        public DateTime date_altered
        {{
            get {{ return _date_altered; }}
            set {{ SetPropertyValue<DateTime>(nameof(date_altered), ref _date_altered, value); }}
        }}
        //public DateTime Date {{get; set;}}

        protected override void OnSaving()
        {{
            base.OnSaving();

            if (Session.IsNewObject(this))
            {{
                created_by = SecuritySystem.CurrentUserName; 
                created_on = DateTime.Now;
            }}
            else
            {{
                date_altered = DateTime.Now;
                //altered_by = SystemMessaging.CleanString(SecuritySystem.CurrentUserName);
                altered_by = SecuritySystem.CurrentUserName;
            }}
        }}

        public override void AfterConstruction()
        {{
            base.AfterConstruction();
   
        }}

      
    }}
}}'''
    save="built/"+classname+".cs"
    f=open(save,"w+")
    f.write(basefile)
    f.close()
    # print(basefile)





