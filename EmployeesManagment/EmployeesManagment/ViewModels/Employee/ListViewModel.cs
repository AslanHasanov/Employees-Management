﻿namespace EmployeesManagment.ViewModels.Employee
{
    public class AddViewModel
    {
    
       
        public string Name { get; set; }
        public string Surname { get; set; }
        public string FatherName { get; set; }
        public string FIN { get; set; }
        public string Email { get; set; }


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
