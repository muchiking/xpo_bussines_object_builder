import os
# def datetime(obj):
#     string=""
#     for entry in obj:
#         string+=f'public DateTime {entry} {{get; set;}}'
    

def format_word(word):
    formatted_word = "_" + word[0].upper() + word[1:]

    return formatted_word

def print_entries_in_both_cases(arr):
    string=" "
    for entry in arr:
        #print(f"Uppercase: {entry.upper()}, Lowercase: {entry.lower()}")
        variablename=(format_word(entry))
        functionname=entry
        list= f"""
        private string {variablename};
        public string {entry}
        {{
            get {{ return  {variablename}; }}
            set {{ SetPropertyValue(nameof( {entry}), ref {variablename}, value); }}
    
        }}"""
        string+=list

    return (string)


    #print(f"Formatted word: {formatted_word}")

if __name__ == "__main__":
    my_array =   [
    "FirstName",
    "MiddleName",
    "LastName",
    "IdNo",
    "PhoneNumber",
    "EmailAddress",
    "Location",
    "Age",
    "DateRegistered",
    "IsDiscipled",
    "MaritalStatus",
    "IsBaptized",
    "IsNewBeliever",
    "Status"
]
    vars = print_entries_in_both_cases(my_array)
    # print(vars)
    classname="Members"
    project="IfcSystem"


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
      //public DateTime Date {{get; set;}}
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





