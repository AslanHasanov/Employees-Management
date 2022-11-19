using EmployeesManagment.DataBase.DataAcces;
using EmployeesManagment.ViewModels.Employee;
using Microsoft.AspNetCore.Mvc;

namespace EmployeesManagment.Controllers
{
    public class EmployeeController : Controller
    {
        #region List
        public IActionResult List()
        {
            DataContext dataContext = new DataContext();

            var empModel = dataContext.Employees.Select( e => new ListViewModel(e.EmployeeCode , e.Name , e.Surname , e.FatherName)).ToList();

            return View(empModel);
        }
        #endregion

        #region Add
        public IActionResult Add()
        {

            return View();
        }
        #endregion
    }
}
