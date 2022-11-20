using EmployeesManagment.CustomAtribute;
using System.ComponentModel.DataAnnotations;
namespace EmployeesManagment.ViewModels
{
    public class AddViewModel
    {

        [Required]
        [RegularExpression(@"[A-Za-z]{3,20}")]
        public string Name { get; set; }
        [Required]
        [RegularExpression(@"[A-Za-z]{3,20}")]
        public string Surname { get; set; }
        [Required]
        [RegularExpression(@"[A-Za-z]{3,20}")]
        public string FatherName { get; set; }
        
        [Required]

        [CustomFin(ErrorMessage = "Finn code must be exist of 7 char , less 1 fiqure and less 1 letter")]
        public string FIN { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }


        public AddViewModel() { }


        public AddViewModel(string name, string surname, string fatherName, string fin, string email)
        {
          
            Name = name;
            Surname = surname;
            FatherName = fatherName;
            FIN= fin;
            Email = email;
           
        }
    }
}
