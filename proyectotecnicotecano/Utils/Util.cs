using proyectotecnicotecano.Dto;
using proyectotecnicotecano.Modals.Response;

namespace proyectotecnicotecano.Utils
{
    public class Util
    {
        public IEnumerable<DtoEmployee> GetEmployees()
        {
            List<DtoEmployee> employees = new List<DtoEmployee>();
            var contents = File.ReadAllText("data-trabajadores.csv").Split('\n');
            for(int i = 1; i < contents.Length; i++)
            {
                var emp = contents[i].Split('|').ToArray();
                DtoEmployee employee = new DtoEmployee() 
                { 
                    DNI = emp[0],
                    Hours = Convert.ToInt32(emp[1]),
                    Days = Convert.ToInt32(emp[2]),
                    Absences = Convert.ToInt32(emp[2]),
                    Type = Convert.ToInt32(emp[4]),
                };
                employees.Add(employee);
            }
            return employees;
        }

        public decimal GetEmployeeSalary(DtoEmployee employee)
        {
            Salary slry = new Salary();
            decimal salary = 0;
            
            SalaryEmployee slryEmployee = slry.salaries.FirstOrDefault(x => x.Type.Equals(employee.Type))!;

            salary = ((employee.Hours * slryEmployee.Hour) - (employee.Absences * slryEmployee.Absence)) + slryEmployee.Bonus;
            salary = salary - ((salary * slryEmployee.Tax) / 100);

            return salary;
        }
    }
}