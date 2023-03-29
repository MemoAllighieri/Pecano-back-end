using proyectotecnicotecano.Dto;
using proyectotecnicotecano.Interfaces;
using proyectotecnicotecano.Modals.Response;
using proyectotecnicotecano.Utils;

namespace proyectotecnicotecano.Services
{
    public class EmployeeServices : IEmployeeServices
    {
        Util _util = new Util();
        public EmployeeServices() { }

        public List<Employee> GetEmployees()
        {
            List<Employee> list = new List<Employee>();

            IEnumerable<DtoEmployee> employees = _util.GetEmployees();

            foreach (var employee in employees)
            {
                Employee emp = new Employee() 
                { 
                    DNI = employee.DNI,
                    Salary = _util.GetEmployeeSalary(employee),
                    Type = employee.Type,
                };

                list.Add(emp);
            }

            return list;
        }
        public Employee GetEmployee(string dni)
        {
            Employee emp = new Employee();

            DtoEmployee employee = _util.GetEmployees().FirstOrDefault(x => x.DNI.Equals(dni))!;

            emp = new Employee()
            {
                DNI = employee.DNI,
                Salary = _util.GetEmployeeSalary(employee),
                Type = employee.Type,
            };

            return emp;
        }
    }
}