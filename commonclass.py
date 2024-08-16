def createclass(classfile):
    fin = f'''
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

    namespace {classfile}.Module.BusinessObjects
    {{
        [DefaultClassOptions]
        //[ImageName("BO_Contact")]
        //[DefaultProperty("DisplayMemberNameForLookupEditorsOfThisType")]
        //[DefaultListViewOptions(MasterDetailMode.ListViewOnly, false, NewItemRowPosition.None)]
        //[Persistent("DatabaseTableName")]
        // Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
        public class CommonClasses : XPLiteObject
        {{ // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
            // Use CodeRush to create XPO classes and properties with a few keystrokes.
            // https://docs.devexpress.com/CodeRushForRoslyn/118557
            public CommonClasses(Session session)
                : base(session)
            {{
            }}

            private string _created_by;
            [XafDisplayName("Created By")]
            [ModelDefault("AllowEdit", "false")]
            //[VisibleInDetailView(false)]
            [VisibleInListView(false)]
            [VisibleInLookupListView(false)]
            public string created_by
            {{
                get {{ return _created_by; }}
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
                get {{ return _altered_by; }}
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
                    altered_by = SecuritySystem.CurrentUserName;
                }}

        
            }}

            public override void AfterConstruction()
            {{
                base.AfterConstruction();
                // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
            }}

        }}
    }}
    '''
    return fin

