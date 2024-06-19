['PromotionReveiwStatus',
'CurrentPay',
'ExtraBenefits',
'CurrentEmployeeProject']

['PerformanceStatus','GoalDescription','FeedBack',Report]
[year]



//fk
[magerid]


format 
```c#
 private Department _department;
        [Association("Department-Employees")]
        public Department Department
        {
            get => _department;
            set => SetPropertyValue(nameof(Department), ref _department, value);
        }
```

  [Association("Department-Employees")]
        public XPCollection<Employee> Employees => GetCollection<Employee>(nameof(Employees));



        //association(one to bestored where)

        //share one relationship with another class 

        ```python
        '''
         private {shared} {sharedsmall};
        [Association("{shared}-(masterclass)")]
        public {shared} {shared}
        {{
            get =>{sharedsmall};
            set => SetPropertyValue(nameof({shared}), ref {sharedsmall}, value);
        }}
        
        [Association("{shared}-(masterclass)")]
        public XPCollection<(masterclass)>(_masterclass) => GetCollection<(masterclass)>(nameof((_masterclass)));
        '''
        ```

        ```c#
        
        
        private ProjectTaskStatus _status;
        public ProjectTaskStatus Status
        {
            get { return _status; }
            set { SetPropertyValue(nameof(Status), ref _status, value); }
        }

           public enum ProjectTaskStatus
        {
            NotStarted =0,
            InProgres=1,
            Completed=2,
            Deferred=3,
        }

        create table outpost

        ```

        skills

        skils
        ```
        SkillName
        ```
        SuccesionPlanning
        ```

        
        ```
        workforceplanning
        ```
        employee
        manager
        position
        department

        outpost
        Contrat
  

        remove employeetasks
        ```

        Employeetraining
        ```
        remove datetime
        training types -manegerial ,technical

        TrainingFeedBack
        TrainingName
        TrainingType
        Location
        TrainingStartDate
        TrainingEndDate
        Employee
        Department
        OutPost
        ```
        
        SkillInventory
        ```
        SkillName


        
        Employee
        Position
        DepartMent
        Training
        outpost

        ```

        EmegencyContact
        ```
        Employee

        FirstNextofkin
        PhoneNo
        Email
        PhysicalAddress
        POBox
        Relationship
        SecondNextofkin
        PhoneNumber
        Email
        PhysicalAddress
        POBox
        Relationship


        ```

        LeaveDays
        ```
        LeaveStatus 
        leavetype
        

        Employee
        LeaveStartDate
        LeaveEndDate
        ```
        LeaveType
        ```
        BereavementLeave
        UnpaidLeave
        SickLeave
        ParentalLeave
        VacationLeave
        ```

        AssetManagment

        ```
        AssetName

        AssetType
        GivingCondition
        ReturnCondition
        AssetStatus

        AssetsharedDate
        AssetreturnedDate

        Employee

        ```
        ["vehicles","peripheralsAndAccessories","softwareLicenses","officeFurniture","Computers"]

        ```xml
        	<connectionStrings>
		<add name=" test"

        
        </connectionStrings>
        ```

        "DefaultConnection":"server=localhost;port=3306;database=HRM;user=root;password=root;"


