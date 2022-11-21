using EmployeesManagment.DataBase.DataAcces;
using EmployeesManagment.DataBase.Models;
using EmployeesManagment.Migrations;
using EmployeesManagment.ViewModels;
using EmployeesManagment.ViewModels.Employee;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using Employee = EmployeesManagment.DataBase.Models.Employee;

namespace EmployeesManagment.Controllers
{
    [Route("Employee")]
    public class EmployeeController : Controller
    {
        #region List
        [HttpGet("List",Name = "employee-list")]
        public IActionResult List()
        {
            DataContext dataContext = new DataContext();

            var empModel = dataContext.Employees.Select( e => new ListViewModel(e.EmployeeCode , e.Name , e.Surname , e.FatherName,e.IsDeleted)).ToList();

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
                EmployeeCode = TableAutoIncrementEmployeeCode.RandomEmpCode,
                Name = model.Name,
                Surname = model.Surname,
                FatherName = model.FatherName,
                FIN=model.FIN,
                Email= model.Email,
                IsDeleted= false
                
                
                

            });;
            dataContext.SaveChanges();

            return RedirectToAction(nameof(List));
        }


        #endregion


        #region Delete

        [HttpGet("Delete/{empcode}", Name = "employee-delete")]
        public ActionResult Delete(string empcode)
        {
            using DataContext dataContext = new DataContext();

            var emp = dataContext.Employees.FirstOrDefault(e => e.EmployeeCode == empcode);


            if (emp == null)
            {
                return NotFound();
            }

            emp.IsDeleted = true;

            dataContext.SaveChanges();

            return RedirectToAction(nameof(List));

        }

        #endregion


        #region update

        [HttpGet("Update/{empcode}", Name = "employee-update-empcode")]
        public ActionResult Update(string empcode)
        {
            using DataContext dataContext = new DataContext();

            var emp = dataContext.Employees.FirstOrDefault(e => e.EmployeeCode == empcode);

            if (emp == null && emp.IsDeleted == true)
            {
                return NotFound();
            }

            var oldEmp =new UpdateViewModel(emp.Name, emp.Surname, emp.FatherName, emp.Email, emp.FIN, emp.EmployeeCode);
            return View("~/Views/Employee/Update.cshtml", oldEmp);
        }
        [HttpPost("Update", Name = "employee-update")]
        public ActionResult Update(UpdateViewModel updatedModel)
        {
            using DataContext dataContext=new DataContext();

            var emp = dataContext.Employees.FirstOrDefault(e => e.EmployeeCode == updatedModel.EmployeeCode);

            if (emp == null && emp.IsDeleted == true)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                return View("~/Views/Employee/Update.cshtml", updatedModel);
            }
            emp.Name = updatedModel.Name;
            emp.Surname = updatedModel.Surname;
            emp.FatherName = updatedModel.FatherName;
            emp.FIN = updatedModel.FIN;
            emp.Email = updatedModel.Email;

            dataContext.SaveChanges();



            return RedirectToAction(nameof(List));
        }

        #endregion

    }
}
