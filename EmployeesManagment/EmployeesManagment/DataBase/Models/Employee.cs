namespace EmployeesManagment.DataBase.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string EmployeeCode { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string FatherName { get; set; }
        public string FIN { get; set; }
        public string Email { get; set; }
        public bool IsDeleted { get; set; }
    }
}
