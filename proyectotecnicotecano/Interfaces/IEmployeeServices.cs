using proyectotecnicotecano.Modals.Response;

namespace proyectotecnicotecano.Interfaces
{
    public interface IEmployeeServices
    {
        public List<Employee> GetEmployees();
        public Employee GetEmployee(string dni);
    }
}