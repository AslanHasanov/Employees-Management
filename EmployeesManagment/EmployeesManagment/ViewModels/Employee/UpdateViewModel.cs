using EmployeesManagment.CustomAtribute;
using System.ComponentModel.DataAnnotations;

namespace EmployeesManagment.ViewModels.Employee
{

    public class UpdateViewModel
    {
        [RegularExpression(@"[A-Za-z]{3,20}", ErrorMessage = "Name must be upper than 3 char and must consist of letters")]
        [Required]
        public string Name { get; set; }

        [RegularExpression(@"[A-Za-z]{3,20}", ErrorMessage = "Name must be upper than 3 char and must consist of letters")]
        [Required]
        public string Surname { get; set; }

        [RegularExpression(@"[A-Za-z]{3,20}", ErrorMessage = "Name must be upper than 3 char and must consist of letters")]
        [Required]
        public string FatherName { get; set; }

        [Required]

        [CustomFin(ErrorMessage = "Finn code must be exist of 7 char , less 1 fiqure and less 1 letter")]
        public string FIN { get; set; }

        [Required]
        [EmailAddress]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }


        [Required]
        public string EmployeeCode { get; set; }

        public UpdateViewModel()
        {

        }
        public UpdateViewModel(string name, string surname, string fatherName, string email, string fin, string employeeCode)
        {

            Name = name;
            Surname = surname;
            FatherName = fatherName;
            Email = email;
            FIN = fin;
            EmployeeCode = employeeCode;
        }
    }
}
