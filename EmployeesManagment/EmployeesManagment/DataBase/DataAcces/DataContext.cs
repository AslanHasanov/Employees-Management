using EmployeesManagment.DataBase.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeesManagment.DataBase.DataAcces
{

    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-KU9654JN;Database=Employee-Managment;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
