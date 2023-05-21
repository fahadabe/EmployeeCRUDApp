

namespace EmployeeCRUDApp.Model.Service;

public class EmployeeService : IEmployeeService
{
    private readonly IDatabase _database;
    private SQLiteAsyncConnection _dbConnection;
    public EmployeeService(IDatabase database)
    {
        _database = database;
    }

    private async Task GetConnection()
    {
        _dbConnection = await _database.GetDatabase();
    }

    public async Task<bool> AddEmployee(Employee employee)
    {
        try
        {
            await GetConnection();
                var result = await _dbConnection.InsertAsync(employee);
                if (result > 0)
                {
                    await Toast.Make($"Employee '{employee.FirstName} {employee.LastName}' successfully saved!").Show();
                    return true;
                }
                else
                {
                    await Toast.Make("Sorry, we couldn't save your employee. Please try again.").Show();
                    return false;
                }
            
        }
        catch (Exception ex)
        {
            await Toast.Make($"An error occurred while adding the employee: {ex.Message}. Please try again.").Show();
            return false;
        }
    }

    public async Task<ObservableCollection<Employee>> GetEmployees()
    {
        try
        {
            await GetConnection();
            var employees = await _dbConnection.Table<Employee>().ToListAsync();
                return new ObservableCollection<Employee>(employees);
            
        }
        catch (Exception ex)
        {
            await Toast.Make($"An error occurred while retrieving employees: {ex.Message}. Please try again.").Show();
            return null;
        }
    }

    public async Task<bool> UpdateEmployee(Employee employee)
    {
        try
        {
            await GetConnection();
            var result = await _dbConnection.UpdateAsync(employee);
                if (result > 0)
                {
                    await Toast.Make($"Employee '{employee.FirstName} {employee.LastName}' successfully updated!").Show();
                    return true;
                }
                else
                {
                    await Toast.Make("Sorry, we couldn't update employee. Please try again.").Show();
                    return false;
                }
            
        }
        catch (Exception ex)
        {
            await Toast.Make($"An error occurred while updating the employee: {ex.Message}. Please try again.").Show();
            return false;
        }
    }

    public async Task<bool> DeleteEmployee(Employee employee)
    {
        try
        {
            await GetConnection();
            var result = await _dbConnection.Table<Employee>().DeleteAsync(x => x.Id == employee.Id);
                if (result > 0)
                {
                    await Toast.Make($"Employee '{employee.FirstName} {employee.LastName}' successfully deleted!").Show();
                    return true;
                }
                else
                {
                    await Toast.Make("Sorry, we couldn't delete employee. Please try again.").Show();
                    return false;
                }
            
        }
        catch (Exception ex)
        {
            await Toast.Make($"An error occurred while deleting the employee: {ex.Message}. Please try again.").Show();
            return false;
        }
    }
}
