
   
        private TrainingStatusEnum _TrainingStatus;
        public TrainingStatusEnum TrainingStatus
        {
            get { return  _TrainingStatus; }
            set { SetPropertyValue(nameof( TrainingStatus), ref _TrainingStatus, value); }
    
        }

    public enum TrainingStatusEnum
            {
             Enroled,Completed
            
            }