namespace EmployeeCRUDApp.Model.Service;

public interface IEmployeeService
{
    Task<bool> AddEmployee(Employee employee);
    Task<bool> DeleteEmployee(Employee employee);
    Task<ObservableCollection<Employee>> GetEmployees();
    Task<bool> UpdateEmployee(Employee employee);
}
