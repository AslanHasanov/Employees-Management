using EmployeesManagment.DataBase.DataAcces;
using EmployeesManagment.DataBase.Models;
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

        [HttpGet("add", Name = "employee-add")]
        public IActionResult Add()
        {
            return View();
        }


        [HttpPost("add", Name = "employee-add")]
        public IActionResult Add(AddViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            DataContext dataContext = new DataContext();


            dataContext.Employees.Add(new Employee
            {
                Name = model.Name,
                Surname = model.Surname,
                FatherName = model.FatherName,
                FIN=model.FIN,
                Email= model.Email

            });

            return RedirectToAction(nameof(List));
        }


        #endregion
    }
}
