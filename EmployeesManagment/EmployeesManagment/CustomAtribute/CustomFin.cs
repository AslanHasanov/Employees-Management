using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace EmployeesManagment.CustomAtribute
{
    public class CustomFin: ValidationAttribute

    {
        public override bool IsValid(object? value)
        {
            var fin = value.ToString();

            string regexed = @"^([A-Z0-9]{7}$)";

            return Regex.IsMatch(fin, regexed);


        }
    }
}
