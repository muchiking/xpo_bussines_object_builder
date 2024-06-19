 
        private Manager _Manager;
       [Association("Manager-Employee")]
        public Manager Manager
        {
            get =>_Manager;
            set => SetPropertyValue(nameof(Manager), ref _Manager, value);
        }
        //paste in slave class
        
       [Association("Manager-Employee")]
        public XPCollection<Employee>_Employee => GetCollection<Employee>(nameof(_Employee));