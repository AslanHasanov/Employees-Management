namespace EmployeesManagment.ViewModels.Employee
{
    public class ListViewModel
    {

        public string EmployeeCode { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string FatherName { get; set; }
        public bool IsDeleted { get; set; }



        public ListViewModel(string employeeCode , string name, string surname, string fatherName, bool ısDeleted)
        {

            EmployeeCode = employeeCode;
            Name = name;
            Surname = surname;
            FatherName = fatherName;
            IsDeleted = ısDeleted;
        }
    }
}
