namespace ChapterFive_PartTwo_Template
{
    public class MainWindowViewModel
    {

        #region Properties 
        private Employee _empDetails;
        public Employee EmpDetails
        {
            get { return _empDetails; }
            set { _empDetails = value; }
        }

        #endregion

        #region Constructor 
        public MainWindowViewModel()
        {
            EmpDetails = new Employee()
            {
                EmpId = 1,
                EmpName = "Alex",
                Designation = "Software Engineer"
            };
        }
        #endregion
    }
}
